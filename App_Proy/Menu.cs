using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Proy
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void pbReproductor_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductordevideo frm = new Reproductordevideo();
            frm.Show();
        }
        private void pbXML_Click(object sender, EventArgs e)
        {
            this.Close();
            XML frm = new XML();
            frm.Show();
        }
        private void pbOffice_Click(object sender, EventArgs e)
        {
            this.Close();
            Directorio frm = new Directorio();
            frm.Show();
        }
        private void pbEditorImagen_Click(object sender, EventArgs e)
        {
            this.Close();
            Editor_De_Imagenes frm = new Editor_De_Imagenes();
            frm.Show();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
            frm.Opacity = 1;
        }

        private void pbWord_Click(object sender, EventArgs e)
        {
            this.Close();
            frmWord frm = new frmWord();
            frm.Show();
        }
    }
}
