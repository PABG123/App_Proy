using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SautinSoft.Document;
using Aspose.Words;

namespace App_Proy
{
    public partial class frmWord : Form
    {
        public frmWord()
        {
            InitializeComponent();
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog exploradorArchivo = new OpenFileDialog();
            exploradorArchivo.Filter = "Documento De Word | *.doc;*.docx; | Texto | *.txt; *.cs;"; 
            {
                if (exploradorArchivo.ShowDialog() == DialogResult.OK)
                {
                    if (exploradorArchivo.FileName.EndsWith(".txt") || exploradorArchivo.FileName.EndsWith(".cs"))
                    {
                        rCw.Clear();
                        StreamReader lector = new StreamReader(exploradorArchivo.FileName);
                        rCw.Text = lector.ReadToEnd();
                        lector.Close();
                    }
                    else
                    {
                        txtArchivo.Text = exploradorArchivo.FileName;
                        try
                        {
                            object readOnly = true;
                            object visible = true;
                            object save = false;
                            object fileName = exploradorArchivo.FileName;
                            object missing = Type.Missing;
                            object newTemplate = false;
                            object docType = 0;

                            Microsoft.Office.Interop.Word._Document documento = null;
                            Microsoft.Office.Interop.Word._Application aplicacionWord = new Microsoft.Office.Interop.Word.Application()
                            { Visible = false };

                            documento = aplicacionWord.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing,
                                ref missing, ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing, ref visible,
                                ref missing, ref missing, ref missing, ref missing);

                            documento.ActiveWindow.Selection.WholeStory();
                            documento.ActiveWindow.Selection.Copy();
                            IDataObject contenidoWord = Clipboard.GetDataObject();
                            rCw.Rtf = contenidoWord.GetData(DataFormats.Rtf).ToString();
                            aplicacionWord.Quit(ref missing, ref missing, ref missing);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                       MessageBox.Show("Ya se cargó el documento");


                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word | *.docx; | Txt|*.txt; | CS | *.cs;";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName.EndsWith("docx"))
                {
                    rCw.SaveFile(Environment.CurrentDirectory + @"\Testdoc.rtf");

                    var newdoc = new Document(Environment.CurrentDirectory + @"\Testdoc.rtf");
                    newdoc.Save(saveFileDialog.FileName);
                    File.Delete(Environment.CurrentDirectory + @"\Testdoc.rtf");
                    
                }
                 
                else
                {
                    StreamWriter sw = File.CreateText(saveFileDialog.FileName);
                    sw.Write(rCw.Text);
                }
                
                if (MessageBox.Show("Ya se guardó")==DialogResult.OK)
                {
                    rCw.Clear();
                }
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu frm = new Menu();
            frm.Show();
        }

        private void directorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Directorio frm = new Directorio();
            frm.Show();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            XML frm = new XML();
            frm.Show();
        }

        private void editorDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Editor_De_Imagenes frm = new Editor_De_Imagenes();
            frm.Show();
        }

        private void reproductorDeVideoYAudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductordevideo frm = new Reproductordevideo();
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
