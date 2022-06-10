using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Proy
{
    public partial class XML : Form
    {
        OpenFileDialog openFile1 = new OpenFileDialog();
        SaveFileDialog saveFile1 = new SaveFileDialog();
        public XML()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.xml";
            openFile1.Filter = "XML Files|*.xml";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                XmlTextReader xmlTextReader = new XmlTextReader(openFile1.FileName);
                string ultimaEtiqueta = "";
                while (xmlTextReader.Read())
                {
                    if (xmlTextReader.NodeType == XmlNodeType.Element)
                    {
                        richTextBox1.Text += (new string(' ', xmlTextReader.Depth * 3) + "<" + xmlTextReader.Name + ">");
                        ultimaEtiqueta = xmlTextReader.Name;
                        continue;
                    }
                    if (xmlTextReader.NodeType == XmlNodeType.EndElement)
                    {
                        richTextBox1.Text += xmlTextReader.ReadContentAsString() + "</" + ultimaEtiqueta + ">";
                    }
                    else
                        richTextBox1.Text += "\r";
                }
            }
           
            
        }
        private void editorDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Editor_De_Imagenes frm = new Editor_De_Imagenes();
            frm.Show();
        }
     
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (abrirToolStripMenuItem != null)
            {
                richTextBox1.Clear();

            }
        }
        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile1.DefaultExt = "*.xml";
            saveFile1.Filter = "XML Files|*.xml";
            if (saveFile1.ShowDialog() == DialogResult.OK &&
              saveFile1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void directorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Directorio frm = new Directorio();
            frm.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu frm = new Menu();
            frm.Show();
        }

        private void reproductorDeVideoYAudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductordevideo frm = new Reproductordevideo();
            frm.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void editorDeArchivosWXPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmWord frm = new frmWord();
            frm.Show();
        }
    }
}
