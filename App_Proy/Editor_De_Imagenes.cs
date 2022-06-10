using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace App_Proy
{
    public partial class Editor_De_Imagenes : Form
    {
        Image File;
        Boolean Abrir = false;
        OpenFileDialog abrir = new OpenFileDialog();
        public Editor_De_Imagenes()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        void Guardar_Imagen()
        {
            if (!Abrir)
            {
                MessageBox.Show("Primero carga una imagen");
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Imagenes|*.png*.bmp;*.jpg";
                ImageFormat Formato = ImageFormat.Png;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    String ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            Formato = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            Formato = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(sfd.FileName, Formato);
                }
            }
         

        }
        void OpenImage()
        {
            DialogResult dr = abrir.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File = Image.FromFile(abrir.FileName);
                pictureBox1.Image = File;
                Abrir = true;

            }

        }
        private void Borrar_PictureBox()
        {
            pictureBox1.Image = null;
            redbar.Value = 0;
            bluebar.Value = 0;
            greenbar.Value = 0;


        }
        void Bar()
        {
            float changered = redbar.Value * 0.1f;
            float changegreen = greenbar.Value * 0.1f;
            float changeblue = bluebar.Value * 0.1f;
            if (!Abrir)
            {

            }
            else
            {
                Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/
                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                   new float[]{1+changered, 0, 0, 0, 0},
                   new float[]{0, 1+changegreen, 0, 0, 0},
                   new float[]{0, 0, 1+changeblue, 0, 0},
                   new float[]{0, 0, 0, 1, 0},
                   new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */
                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox1.Image = bmpInverted;
            }
        }
        void Filtro1()
        {
            if (!Abrir)
            {
                MessageBox.Show("Primero carga una imagen");
            }
            else
            {
                Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{.393f, .349f, .272f+1.3f, 0, 0},
                    new float[]{.769f, .686f+0.5f, .534f, 0, 0},
                    new float[]{.189f+2.3f, .168f, .131f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */
                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox1.Image = bmpInverted;
            }
        }
        void Filtro2()
        {
            if (!Abrir)
            {
                MessageBox.Show("Primero carga una imagen");
            }
            else
            {
                Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{.393f, .349f+0.5f, .272f, 0, 0},
                    new float[]{.769f+0.3f, .686f, .534f, 0, 0},
                    new float[]{.189f, .168f, .131f+0.5f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox1.Image = bmpInverted;

            }
        }
        void Filtro3()
        {
            if (!Abrir)
            {
                MessageBox.Show("Primero carga una imagen");
            }
            else
            {

                Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{.393f+0.3f, .349f, .272f, 0, 0},
                    new float[]{.769f, .686f+0.2f, .534f, 0, 0},
                    new float[]{.189f, .168f, .131f+0.9f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox1.Image = bmpInverted;
            }
        }
        private void Quitar_Filtro()
        {
            if (!Abrir)
            {
                MessageBox.Show("Primero abre una imagen y despues aplica un filtro");
            }
            else
            {
                pictureBox1.Image = null;
                redbar.Value = 0;
                bluebar.Value = 0;
                greenbar.Value = 0;
                File = Image.FromFile(abrir.FileName);
                pictureBox1.Image = File;
                Abrir = true;
            }
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenImage();
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Guardar_Imagen();
        }
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quitar_Filtro();
        }
        private void filtro1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtro1();
        }
        private void filtro2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtro2();
        }
        private void filtro3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtro3();
        }

        private void reproductorDeVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductordevideo frm = new Reproductordevideo();
            frm.Show();
        }
    
        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            XML frm = new XML();
            frm.Show();
            this.Close();

        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void redbar_Scroll(object sender, EventArgs e)
        {
            if (!Abrir)
            {
                MessageBox.Show("Primero abre una imagen");
                redbar.Value = 0;
            }
            else
            {
                Bar();
            }
        }

        private void greenbar_Scroll(object sender, EventArgs e)
        {
            if (!Abrir)
            {
                MessageBox.Show("Primero abre una imagen");
                redbar.Value = 0;
            }
            else
            {
                Bar();
            }
        }

        private void bluebar_Scroll(object sender, EventArgs e)
        {
            if (!Abrir)
            {
                MessageBox.Show("Primero abre una imagen");
                redbar.Value = 0;
            }
            else
            {
                Bar();
            }
        }

        private void directorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directorio frm = new Directorio();
            frm.Show();
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu frm = new Menu();
            frm.Show();
            
        }

        private void archivosOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmWord frm = new frmWord();
            frm.Show();
        }
    }
}
