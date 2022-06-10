namespace App_Proy
{
    partial class Reproductordevideo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductordevideo));
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDeImagenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.Playlist = new System.Windows.Forms.ListBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.sbTiempo = new System.Windows.Forms.HScrollBar();
            this.btnCompleta = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.lbTotalTime = new System.Windows.Forms.Label();
            this.btnSiguiente1 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAle = new System.Windows.Forms.Button();
            this.btnAtras1 = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPausa1 = new System.Windows.Forms.Button();
            this.btnPlay1 = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.sbVolumen = new System.Windows.Forms.VScrollBar();
            this.pbAlbum = new System.Windows.Forms.PictureBox();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(0, 27);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(780, 359);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 0;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editorDeImagenesToolStripMenuItem,
            this.directorioToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.wordToolStripMenuItem,
            this.xToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1318, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // editorDeImagenesToolStripMenuItem
            // 
            this.editorDeImagenesToolStripMenuItem.Name = "editorDeImagenesToolStripMenuItem";
            this.editorDeImagenesToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.editorDeImagenesToolStripMenuItem.Text = "Editor de imagenes";
            this.editorDeImagenesToolStripMenuItem.Click += new System.EventHandler(this.editorDeImagenesToolStripMenuItem_Click);
            // 
            // directorioToolStripMenuItem
            // 
            this.directorioToolStripMenuItem.Name = "directorioToolStripMenuItem";
            this.directorioToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.directorioToolStripMenuItem.Text = "Directorio";
            this.directorioToolStripMenuItem.Click += new System.EventHandler(this.directorioToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.xToolStripMenuItem.Text = "XML";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.salirToolStripMenuItem.Text = "Cerrar";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(992, 27);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Location = new System.Drawing.Point(992, 56);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(75, 23);
            this.btnAleatorio.TabIndex = 4;
            this.btnAleatorio.Text = "Aleatorio";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Visible = false;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // Playlist
            // 
            this.Playlist.BackColor = System.Drawing.Color.Yellow;
            this.Playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Playlist.FormattingEnabled = true;
            this.Playlist.Location = new System.Drawing.Point(794, 35);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(174, 351);
            this.Playlist.TabIndex = 5;
            this.Playlist.SelectedIndexChanged += new System.EventHandler(this.Playlist_SelectedIndexChanged_1);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(1147, 683);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(58, 25);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "0:00";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(992, 85);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 10;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // sbTiempo
            // 
            this.sbTiempo.Location = new System.Drawing.Point(69, 708);
            this.sbTiempo.Maximum = 200;
            this.sbTiempo.Name = "sbTiempo";
            this.sbTiempo.Size = new System.Drawing.Size(1075, 32);
            this.sbTiempo.TabIndex = 9;
            this.sbTiempo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbTiempo_Scroll);
            // 
            // btnCompleta
            // 
            this.btnCompleta.Location = new System.Drawing.Point(1087, 1);
            this.btnCompleta.Name = "btnCompleta";
            this.btnCompleta.Size = new System.Drawing.Size(75, 40);
            this.btnCompleta.TabIndex = 11;
            this.btnCompleta.Text = "Pantalla completa";
            this.btnCompleta.UseVisualStyleBackColor = true;
            this.btnCompleta.Visible = false;
            this.btnCompleta.Click += new System.EventHandler(this.btnCompleta_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(1231, 4);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 46);
            this.btnNormal.TabIndex = 12;
            this.btnNormal.Text = "Pantala Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // lbTotalTime
            // 
            this.lbTotalTime.AutoSize = true;
            this.lbTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalTime.Location = new System.Drawing.Point(12, 683);
            this.lbTotalTime.Name = "lbTotalTime";
            this.lbTotalTime.Size = new System.Drawing.Size(58, 25);
            this.lbTotalTime.TabIndex = 13;
            this.lbTotalTime.Text = "0:00";
            // 
            // btnSiguiente1
            // 
            this.btnSiguiente1.Location = new System.Drawing.Point(1087, 47);
            this.btnSiguiente1.Name = "btnSiguiente1";
            this.btnSiguiente1.Size = new System.Drawing.Size(75, 40);
            this.btnSiguiente1.TabIndex = 14;
            this.btnSiguiente1.Text = "Siguiente";
            this.btnSiguiente1.UseVisualStyleBackColor = true;
            this.btnSiguiente1.Visible = false;
            this.btnSiguiente1.Click += new System.EventHandler(this.btnSiguiente1_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(1087, 93);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 40);
            this.btnPlay.TabIndex = 15;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnAle
            // 
            this.btnAle.Location = new System.Drawing.Point(1087, 139);
            this.btnAle.Name = "btnAle";
            this.btnAle.Size = new System.Drawing.Size(75, 40);
            this.btnAle.TabIndex = 16;
            this.btnAle.Text = "Aleatorio";
            this.btnAle.UseVisualStyleBackColor = true;
            this.btnAle.Visible = false;
            this.btnAle.Click += new System.EventHandler(this.btnAle_Click);
            // 
            // btnAtras1
            // 
            this.btnAtras1.Location = new System.Drawing.Point(1087, 185);
            this.btnAtras1.Name = "btnAtras1";
            this.btnAtras1.Size = new System.Drawing.Size(75, 40);
            this.btnAtras1.TabIndex = 17;
            this.btnAtras1.Text = "Anterior";
            this.btnAtras1.UseVisualStyleBackColor = true;
            this.btnAtras1.Visible = false;
            this.btnAtras1.Click += new System.EventHandler(this.btnAtras1_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(992, 114);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 18;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Visible = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPausa1
            // 
            this.btnPausa1.Location = new System.Drawing.Point(1087, 231);
            this.btnPausa1.Name = "btnPausa1";
            this.btnPausa1.Size = new System.Drawing.Size(75, 40);
            this.btnPausa1.TabIndex = 19;
            this.btnPausa1.Text = "Pausa";
            this.btnPausa1.UseVisualStyleBackColor = true;
            this.btnPausa1.Visible = false;
            this.btnPausa1.Click += new System.EventHandler(this.btnPausa1_Click);
            // 
            // btnPlay1
            // 
            this.btnPlay1.Location = new System.Drawing.Point(992, 143);
            this.btnPlay1.Name = "btnPlay1";
            this.btnPlay1.Size = new System.Drawing.Size(75, 23);
            this.btnPlay1.TabIndex = 20;
            this.btnPlay1.Text = "Play";
            this.btnPlay1.UseVisualStyleBackColor = true;
            this.btnPlay1.Visible = false;
            this.btnPlay1.Click += new System.EventHandler(this.btnPlay1_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.Location = new System.Drawing.Point(992, 172);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(75, 23);
            this.btnPausa.TabIndex = 21;
            this.btnPausa.Text = "Pausa";
            this.btnPausa.UseVisualStyleBackColor = true;
            this.btnPausa.Visible = false;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // sbVolumen
            // 
            this.sbVolumen.Location = new System.Drawing.Point(1098, 628);
            this.sbVolumen.Name = "sbVolumen";
            this.sbVolumen.Size = new System.Drawing.Size(46, 80);
            this.sbVolumen.TabIndex = 22;
            this.sbVolumen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbVolumen_Scroll);
            // 
            // pbAlbum
            // 
            this.pbAlbum.Location = new System.Drawing.Point(0, 392);
            this.pbAlbum.Name = "pbAlbum";
            this.pbAlbum.Size = new System.Drawing.Size(147, 190);
            this.pbAlbum.TabIndex = 8;
            this.pbAlbum.TabStop = false;
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.wordToolStripMenuItem.Text = "Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // Reproductordevideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1318, 749);
            this.Controls.Add(this.sbVolumen);
            this.Controls.Add(this.btnPausa);
            this.Controls.Add(this.btnPlay1);
            this.Controls.Add(this.btnPausa1);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnAtras1);
            this.Controls.Add(this.btnAle);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSiguiente1);
            this.Controls.Add(this.lbTotalTime);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnCompleta);
            this.Controls.Add(this.sbTiempo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.pbAlbum);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.Playlist);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.vlcControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reproductordevideo";
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDeImagenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.ListBox Playlist;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pbAlbum;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.HScrollBar sbTiempo;
        private System.Windows.Forms.Button btnCompleta;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Label lbTotalTime;
        private System.Windows.Forms.Button btnSiguiente1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnAle;
        private System.Windows.Forms.Button btnAtras1;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPausa1;
        private System.Windows.Forms.Button btnPlay1;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.VScrollBar sbVolumen;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
    }
}