
namespace App_Proy
{
    partial class Editor_De_Imagenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.redbar = new System.Windows.Forms.TrackBar();
            this.bluebar = new System.Windows.Forms.TrackBar();
            this.greenbar = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizadorDeArchivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproductorDeVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivosOfficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1214, 408);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // redbar
            // 
            this.redbar.Location = new System.Drawing.Point(37, 457);
            this.redbar.Maximum = 100;
            this.redbar.Name = "redbar";
            this.redbar.Size = new System.Drawing.Size(508, 45);
            this.redbar.TabIndex = 1;
            this.redbar.TickFrequency = 10;
            this.redbar.Scroll += new System.EventHandler(this.redbar_Scroll);
            // 
            // bluebar
            // 
            this.bluebar.Location = new System.Drawing.Point(582, 457);
            this.bluebar.Maximum = 100;
            this.bluebar.Name = "bluebar";
            this.bluebar.Size = new System.Drawing.Size(508, 45);
            this.bluebar.TabIndex = 2;
            this.bluebar.TickFrequency = 10;
            this.bluebar.Scroll += new System.EventHandler(this.bluebar_Scroll);
            // 
            // greenbar
            // 
            this.greenbar.Location = new System.Drawing.Point(37, 508);
            this.greenbar.Maximum = 100;
            this.greenbar.Name = "greenbar";
            this.greenbar.Size = new System.Drawing.Size(508, 45);
            this.greenbar.TabIndex = 3;
            this.greenbar.TickFrequency = 10;
            this.greenbar.Scroll += new System.EventHandler(this.greenbar_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.filtrosToolStripMenuItem,
            this.organizadorDeArchivosToolStripMenuItem,
            this.reproductorDeVideoToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.archivosOfficeToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.directorioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.borrarToolStripMenuItem.Text = "Quitar filtros";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtro1ToolStripMenuItem,
            this.filtro2ToolStripMenuItem,
            this.filtro3ToolStripMenuItem});
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            // 
            // filtro1ToolStripMenuItem
            // 
            this.filtro1ToolStripMenuItem.Name = "filtro1ToolStripMenuItem";
            this.filtro1ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.filtro1ToolStripMenuItem.Text = "Filtro 1";
            this.filtro1ToolStripMenuItem.Click += new System.EventHandler(this.filtro1ToolStripMenuItem_Click);
            // 
            // filtro2ToolStripMenuItem
            // 
            this.filtro2ToolStripMenuItem.Name = "filtro2ToolStripMenuItem";
            this.filtro2ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.filtro2ToolStripMenuItem.Text = "Filtro 2";
            this.filtro2ToolStripMenuItem.Click += new System.EventHandler(this.filtro2ToolStripMenuItem_Click);
            // 
            // filtro3ToolStripMenuItem
            // 
            this.filtro3ToolStripMenuItem.Name = "filtro3ToolStripMenuItem";
            this.filtro3ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.filtro3ToolStripMenuItem.Text = "Filtro 3";
            this.filtro3ToolStripMenuItem.Click += new System.EventHandler(this.filtro3ToolStripMenuItem_Click);
            // 
            // organizadorDeArchivosToolStripMenuItem
            // 
            this.organizadorDeArchivosToolStripMenuItem.Name = "organizadorDeArchivosToolStripMenuItem";
            this.organizadorDeArchivosToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // reproductorDeVideoToolStripMenuItem
            // 
            this.reproductorDeVideoToolStripMenuItem.Name = "reproductorDeVideoToolStripMenuItem";
            this.reproductorDeVideoToolStripMenuItem.Size = new System.Drawing.Size(175, 20);
            this.reproductorDeVideoToolStripMenuItem.Text = "Reproductor de video y audio";
            this.reproductorDeVideoToolStripMenuItem.Click += new System.EventHandler(this.reproductorDeVideoToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // archivosOfficeToolStripMenuItem
            // 
            this.archivosOfficeToolStripMenuItem.Name = "archivosOfficeToolStripMenuItem";
            this.archivosOfficeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.archivosOfficeToolStripMenuItem.Text = "Word";
            this.archivosOfficeToolStripMenuItem.Click += new System.EventHandler(this.archivosOfficeToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // directorioToolStripMenuItem
            // 
            this.directorioToolStripMenuItem.Name = "directorioToolStripMenuItem";
            this.directorioToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.directorioToolStripMenuItem.Text = "Directorio";
            this.directorioToolStripMenuItem.Click += new System.EventHandler(this.directorioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.salirToolStripMenuItem.Text = "Cerrar";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Editor_De_Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1370, 563);
            this.Controls.Add(this.greenbar);
            this.Controls.Add(this.bluebar);
            this.Controls.Add(this.redbar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor_De_Imagenes";
            this.Text = "Editor_De_Imagenes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar redbar;
        private System.Windows.Forms.TrackBar bluebar;
        private System.Windows.Forms.TrackBar greenbar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizadorDeArchivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproductorDeVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivosOfficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtro1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtro2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtro3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    }
}