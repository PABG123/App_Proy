using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Proy
{
    public partial class Directorio : Form
    {
        public Directorio()
        {
            InitializeComponent();
        }
       

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }
        private void LlenarArbol(DirectoryInfo di, TreeNodeCollection tnc)
        {

            TreeNode nodo = tnc.Add(di.Name);
            foreach (FileInfo archivo in di.GetFiles())
            {
                nodo.Nodes.Add(archivo.FullName, archivo.Name);
            }
            foreach (DirectoryInfo sdi in di.GetDirectories())
            {
                LlenarArbol(sdi, nodo.Nodes);
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name.EndsWith("txt") || e.Node.Name.EndsWith("cs") || e.Node.Name.EndsWith("xml"))
            {
                richTextBox1.Clear();
                StreamReader lector = new StreamReader(e.Node.Name);
                richTextBox1.Text = lector.ReadToEnd();
                lector.Close();
                richTextBox1.Width = 250;
                pictureBox1.Width = 0;
            }
            if (e.Node.Name.EndsWith(".jpg") || e.Node.Name.EndsWith(".png"))
            {
                Image image = Image.FromFile(e.Node.Name);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = image;
                pictureBox1.Width = 250;
                richTextBox1.Width = 0;
            }
        }
        public void ChooseFolder()
        {
            FolderBrowserDialog dialogo = new FolderBrowserDialog();
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialogo.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(dialogo.SelectedPath);

                treeView1.AfterSelect += treeView1_AfterSelect;
                LlenarArbol(di, treeView1.Nodes);
            }
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Dock = DockStyle.Fill;
            Dock = DockStyle.Fill;
            WindowState = FormWindowState.Maximized;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Dock = DockStyle.None;
            Dock = DockStyle.Fill;
            WindowState = FormWindowState.Normal;
        }
        private void editorDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editor_De_Imagenes frm = new Editor_De_Imagenes();
            frm.Show();
            this.Close();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XML frm = new XML();
            frm.Show();
            this.Close();
        }
        private void cerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void reproductorDeVideoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductordevideo frm = new Reproductordevideo();
            frm.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu frm = new Menu();
            frm.Show();
        }

        private void organizadorDeArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            frmWord frm = new frmWord();
            frm.Show();
        }
    }
}
