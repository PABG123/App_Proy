using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySqlConnector;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Proy
{
    public partial class Form1 : Form
    {
        MySqlConnection cnx;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            string cadena = "server=localhost;user=root;database=proyecto;port=3306;Contraseña=";
            cnx = new MySqlConnection(cadena);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            cnx.Open();                       //tabla id_Usuarios=2
            string sql = "SELECT * FROM usuarios WHERE   ID='" + txtUsuario.Text + "' and Contraseña='" + txtContraseña.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, cnx);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                Menu frm = new Menu();
                frm.Show();
                this.Opacity = 0;
            }
            else
            {
                MessageBox.Show("Checa tu Constraseña y tu Usuario");
                txtUsuario.Clear();
                txtContraseña.Clear();
            }
            cnx.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
