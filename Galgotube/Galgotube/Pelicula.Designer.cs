namespace Galgotube
{
    partial class Pelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pelicula));
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.reproductor = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNom = new System.Windows.Forms.Label();
            this.rep1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.peliculas = new System.Windows.Forms.FlowLayoutPanel();
            this.portada = new System.Windows.Forms.PictureBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.txtSin = new System.Windows.Forms.TextBox();
            this.infoPelicula = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            this.reproductor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rep1)).BeginInit();
            this.peliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portada)).BeginInit();
            this.infoPelicula.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.Image = global::Galgotube.Properties.Resources.if_arrow_back_216437;
            this.btnRegresar.Location = new System.Drawing.Point(12, 30);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(32, 32);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRegresar.TabIndex = 41;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // reproductor
            // 
            this.reproductor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reproductor.AutoSize = true;
            this.reproductor.BackColor = System.Drawing.Color.DarkGreen;
            this.reproductor.Controls.Add(this.lblNom);
            this.reproductor.Controls.Add(this.rep1);
            this.reproductor.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.reproductor.Location = new System.Drawing.Point(217, 68);
            this.reproductor.Name = "reproductor";
            this.reproductor.Size = new System.Drawing.Size(487, 335);
            this.reproductor.TabIndex = 40;
            this.reproductor.WrapContents = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Arial", 12F);
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Location = new System.Drawing.Point(3, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(50, 18);
            this.lblNom.TabIndex = 40;
            this.lblNom.Text = "label1";
            // 
            // rep1
            // 
            this.rep1.Enabled = true;
            this.rep1.Location = new System.Drawing.Point(3, 21);
            this.rep1.Name = "rep1";
            this.rep1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rep1.OcxState")));
            this.rep1.Size = new System.Drawing.Size(481, 311);
            this.rep1.TabIndex = 41;
            // 
            // peliculas
            // 
            this.peliculas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.peliculas.AutoScroll = true;
            this.peliculas.BackColor = System.Drawing.Color.DarkGreen;
            this.peliculas.Controls.Add(this.portada);
            this.peliculas.Controls.Add(this.lblAño);
            this.peliculas.Controls.Add(this.lblCat);
            this.peliculas.Controls.Add(this.txtSin);
            this.peliculas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.peliculas.Location = new System.Drawing.Point(12, 68);
            this.peliculas.Name = "peliculas";
            this.peliculas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.peliculas.Size = new System.Drawing.Size(192, 368);
            this.peliculas.TabIndex = 39;
            this.peliculas.WrapContents = false;
            // 
            // portada
            // 
            this.portada.Location = new System.Drawing.Point(3, 3);
            this.portada.Name = "portada";
            this.portada.Size = new System.Drawing.Size(186, 261);
            this.portada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portada.TabIndex = 1;
            this.portada.TabStop = false;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAño.ForeColor = System.Drawing.Color.White;
            this.lblAño.Location = new System.Drawing.Point(3, 267);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(50, 18);
            this.lblAño.TabIndex = 40;
            this.lblAño.Text = "label2";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCat.ForeColor = System.Drawing.Color.White;
            this.lblCat.Location = new System.Drawing.Point(3, 285);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(50, 18);
            this.lblCat.TabIndex = 41;
            this.lblCat.Text = "label3";
            // 
            // txtSin
            // 
            this.txtSin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSin.Enabled = false;
            this.txtSin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSin.Location = new System.Drawing.Point(3, 306);
            this.txtSin.Multiline = true;
            this.txtSin.Name = "txtSin";
            this.txtSin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSin.Size = new System.Drawing.Size(186, 715);
            this.txtSin.TabIndex = 42;
            // 
            // infoPelicula
            // 
            this.infoPelicula.BackColor = System.Drawing.Color.DarkGreen;
            this.infoPelicula.Enabled = false;
            this.infoPelicula.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.infoPelicula.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.infoPelicula.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.infoPelicula.Location = new System.Drawing.Point(0, 0);
            this.infoPelicula.Name = "infoPelicula";
            this.infoPelicula.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.infoPelicula.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.infoPelicula.Size = new System.Drawing.Size(713, 23);
            this.infoPelicula.TabIndex = 38;
            this.infoPelicula.Text = "menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 19);
            this.toolStripMenuItem1.Text = "  ";
            // 
            // Pelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(713, 441);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.reproductor);
            this.Controls.Add(this.peliculas);
            this.Controls.Add(this.infoPelicula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pelicula";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            this.reproductor.ResumeLayout(false);
            this.reproductor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rep1)).EndInit();
            this.peliculas.ResumeLayout(false);
            this.peliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portada)).EndInit();
            this.infoPelicula.ResumeLayout(false);
            this.infoPelicula.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnRegresar;
        public System.Windows.Forms.FlowLayoutPanel reproductor;
        public System.Windows.Forms.Label lblNom;
        public System.Windows.Forms.FlowLayoutPanel peliculas;
        public System.Windows.Forms.PictureBox portada;
        public System.Windows.Forms.Label lblAño;
        public System.Windows.Forms.Label lblCat;
        public System.Windows.Forms.TextBox txtSin;
        private System.Windows.Forms.MenuStrip infoPelicula;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public AxWMPLib.AxWindowsMediaPlayer rep1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}