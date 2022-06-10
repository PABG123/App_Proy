using System;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Drawing;
namespace App_Proy
{
    public partial class Reproductordevideo : Form
    {
        string[] rutas, nombres;
        public Reproductordevideo()
        {
            InitializeComponent();
        }
        private void siguiente()
        {
            if (Playlist.SelectedIndex < Playlist.Items.Count - 1)
            {
                Playlist.SelectedIndex = Playlist.SelectedIndex + 1;
            }
            
        }
        private void anterior()
        {
            if (Playlist.SelectedIndex > 0)
            { Playlist.SelectedIndex = Playlist.SelectedIndex - 1; }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (vlcControl1.IsPlaying)
            {
                sbTiempo.Maximum = (int)vlcControl1.Length / 1000;
                sbTiempo.Value = (int)vlcControl1.Time / 1000;
            }
            TimeSpan t = TimeSpan.FromMilliseconds(vlcControl1.Time);
            string time = string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
            lbTime.Text = time;
            TimeSpan t2 = TimeSpan.FromMilliseconds(vlcControl1.Length);
            string totalTime = string.Format("{0:D2}:{1:D2}", t2.Minutes, t2.Seconds);
            lbTotalTime.Text = totalTime;
            if (sbTiempo.Value >= sbTiempo.Maximum - 2)
            { siguiente(); }
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Audio|*.mp3;*.wmv;*.mp4;*.wav;*.flac;*.m4a;*.jpg*;";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nombres = openFileDialog.SafeFileNames;
                rutas = openFileDialog.FileNames;
                btnCompleta.Visible = true;
                btnAbrir.Visible = true;
                btnAleatorio.Visible = true;
                btnSiguiente.Visible = true;
                btnPausa.Visible = true;
                btnAnterior.Visible = true;
                btnPlay1.Visible = true;
                for (int i = 0; i < nombres.Length; i++)
                {
                    Playlist.Items.Add(nombres[i]);
                }
            }
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Audio|*.mp3;*.wmv;*.mp4;*.wav;*.flac;*.m4a;*.jpg*;";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nombres = openFileDialog.SafeFileNames;
                rutas = openFileDialog.FileNames;
                btnCompleta.Visible = true;
                btnAbrir.Visible = true;
                btnAleatorio.Visible = true;
                btnSiguiente.Visible = true;
                btnPausa.Visible = true;
                btnAnterior.Visible = true;
                btnPlay1.Visible = true;

                for (int i = 0; i < nombres.Length; i++)
                {
                    Playlist.Items.Add(nombres[i]);
                } 
            }
        }
        private void sbTiempo_Scroll(object sender, ScrollEventArgs e)
        {
            vlcControl1.Time = sbTiempo.Value * 1000;
        }
        private void Playlist_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            vlcControl1.Play(new Uri(rutas[Playlist.SelectedIndex]));

            TagLib.File file = TagLib.File.Create(rutas[Playlist.SelectedIndex]);
            var mStream = new MemoryStream();
            var firstPicture = file.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null)
            {
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                var bm = new Bitmap(mStream, false);
                mStream.Dispose();
                pbAlbum.Image = bm;
                pbAlbum.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            timer1.Start();
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Playlist.Items.Clear();
            Random rand1 = new Random();
            try
            {
                rutas = rutas.OrderBy(rutas => rand1.Next()).ToArray();
            }
            catch (Exception)
            { }
            for (int y = 0; y < rutas.Length; y++)
            {
                nombres[y] = Path.GetFileName(rutas[y]);
                Playlist.Items.Add(nombres[y]);
            }
        }
     
        private void pancom()
        {
            vlcControl1.Dock = DockStyle.Fill;
            Dock = DockStyle.Fill;
            WindowState = FormWindowState.Maximized;
            btnNormal.Visible = true;
            btnAbrir.Visible = false;
            btnCompleta.Visible = true;           
            btnAleatorio.Visible = false;
            btnSiguiente.Visible = false;
            btnPausa.Visible = false;
            btnAnterior.Visible = false;
            btnPlay1.Visible = false;

            btnAtras1.Visible = true;
            btnPlay.Visible = true;
            btnSiguiente1.Visible = true;
            btnPausa1.Visible = true;
            btnAle.Visible = true;
            btnAtras1.Visible = true;

            menuStrip1.Visible = false;
            pbAlbum.Visible = false;
            Playlist.Visible = false;


        }
        private void btnCompleta_Click(object sender, EventArgs e)
        {
            pancom();
        }
        private void btnNormal_Click(object sender, EventArgs e)
        {
            pannor();
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            siguiente();
        }

        private void btnSiguiente1_Click(object sender, EventArgs e)
        {
            siguiente();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            vlcControl1.Play();
        }

        private void btnAle_Click(object sender, EventArgs e)
        {
            Playlist.Items.Clear();
            Random rand1 = new Random();
            try
            {
                rutas = rutas.OrderBy(rutas => rand1.Next()).ToArray();
            }
            catch (Exception)
            { }
            for (int y = 0; y < rutas.Length; y++)
            {
                nombres[y] = Path.GetFileName(rutas[y]);
                Playlist.Items.Add(nombres[y]);
            }
        }

        private void btnAtras1_Click(object sender, EventArgs e)
        {
            anterior();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            anterior();
        }

        private void btnPausa1_Click(object sender, EventArgs e)
        {
            vlcControl1.Pause();
        }

        private void btnPlay1_Click(object sender, EventArgs e)
        {
            vlcControl1.Play();
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            vlcControl1.Pause();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void editorDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Editor_De_Imagenes frm = new Editor_De_Imagenes();
            frm.Show();
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

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            XML frm = new XML();
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void sbVolumen_Scroll(object sender, ScrollEventArgs e)
        {
            int nuevoValor = sbVolumen.Value;
            vlcControl1.Audio.Volume = nuevoValor;
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmWord frm = new frmWord();
            frm.Show();
        }

        private void pannor()
        {
            vlcControl1.Dock = DockStyle.None;
            Dock = DockStyle.Fill;
            WindowState = FormWindowState.Normal;
            btnAbrir.Visible = true;
            btnNormal.Visible = false;
            btnCompleta.Visible = true;
            btnAleatorio.Visible = true;
            btnSiguiente.Visible = true;
            btnPausa.Visible = true;
            btnAnterior.Visible = true;
            btnPlay1.Visible = true;

            btnAtras1.Visible = false;
            btnPlay.Visible = false;
            btnSiguiente1.Visible = false;
            btnPausa1.Visible = false;
            btnAle.Visible = false;
            btnAtras1.Visible = false;

            menuStrip1.Visible = true;
            pbAlbum.Visible = true;
            Playlist.Visible = true;
        }
    }
}
