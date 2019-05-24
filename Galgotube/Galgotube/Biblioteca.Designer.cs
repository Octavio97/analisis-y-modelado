namespace Galgotube
{
    partial class Biblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biblioteca));
            this.lblNombre = new System.Windows.Forms.Label();
            this.estrenos = new System.Windows.Forms.FlowLayoutPanel();
            this.categoria = new System.Windows.Forms.FlowLayoutPanel();
            this.Fantasia = new System.Windows.Forms.Button();
            this.Acción = new System.Windows.Forms.Button();
            this.Aventura = new System.Windows.Forms.Button();
            this.cienciaFiccion = new System.Windows.Forms.Button();
            this.Comedia = new System.Windows.Forms.Button();
            this.Documental = new System.Windows.Forms.Button();
            this.Drama = new System.Windows.Forms.Button();
            this.Infantil = new System.Windows.Forms.Button();
            this.Romance = new System.Windows.Forms.Button();
            this.Terror = new System.Windows.Forms.Button();
            this.Suspenso = new System.Windows.Forms.Button();
            this.Musica = new System.Windows.Forms.Button();
            this.peliculasCat = new System.Windows.Forms.FlowLayoutPanel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.opciones = new System.Windows.Forms.ToolStripMenuItem();
            this.cuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contacto = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.buscar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoria.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F);
            this.lblNombre.Location = new System.Drawing.Point(40, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 18);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "lblNombre";
            // 
            // estrenos
            // 
            this.estrenos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.estrenos.AutoScroll = true;
            this.estrenos.BackColor = System.Drawing.Color.DarkGreen;
            this.estrenos.Location = new System.Drawing.Point(12, 80);
            this.estrenos.Name = "estrenos";
            this.estrenos.Size = new System.Drawing.Size(595, 168);
            this.estrenos.TabIndex = 10;
            // 
            // categoria
            // 
            this.categoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoria.AutoScroll = true;
            this.categoria.BackColor = System.Drawing.Color.DarkGreen;
            this.categoria.Controls.Add(this.Fantasia);
            this.categoria.Controls.Add(this.Acción);
            this.categoria.Controls.Add(this.Aventura);
            this.categoria.Controls.Add(this.cienciaFiccion);
            this.categoria.Controls.Add(this.Comedia);
            this.categoria.Controls.Add(this.Documental);
            this.categoria.Controls.Add(this.Drama);
            this.categoria.Controls.Add(this.Infantil);
            this.categoria.Controls.Add(this.Romance);
            this.categoria.Controls.Add(this.Terror);
            this.categoria.Controls.Add(this.Suspenso);
            this.categoria.Controls.Add(this.Musica);
            this.categoria.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.categoria.Location = new System.Drawing.Point(358, 266);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(249, 113);
            this.categoria.TabIndex = 9;
            this.categoria.WrapContents = false;
            // 
            // Fantasia
            // 
            this.Fantasia.Font = new System.Drawing.Font("Arial", 9F);
            this.Fantasia.Location = new System.Drawing.Point(3, 3);
            this.Fantasia.Name = "Fantasia";
            this.Fantasia.Size = new System.Drawing.Size(225, 23);
            this.Fantasia.TabIndex = 0;
            this.Fantasia.Text = "Fantasia";
            this.Fantasia.UseVisualStyleBackColor = true;
            this.Fantasia.Click += new System.EventHandler(this.Fantasia_Click);
            // 
            // Acción
            // 
            this.Acción.Font = new System.Drawing.Font("Arial", 9F);
            this.Acción.Location = new System.Drawing.Point(3, 32);
            this.Acción.Name = "Acción";
            this.Acción.Size = new System.Drawing.Size(225, 23);
            this.Acción.TabIndex = 1;
            this.Acción.Text = "Acción";
            this.Acción.UseVisualStyleBackColor = true;
            this.Acción.Click += new System.EventHandler(this.Acción_Click);
            // 
            // Aventura
            // 
            this.Aventura.Font = new System.Drawing.Font("Arial", 9F);
            this.Aventura.Location = new System.Drawing.Point(3, 61);
            this.Aventura.Name = "Aventura";
            this.Aventura.Size = new System.Drawing.Size(225, 23);
            this.Aventura.TabIndex = 2;
            this.Aventura.Text = "Aventura";
            this.Aventura.UseVisualStyleBackColor = true;
            this.Aventura.Click += new System.EventHandler(this.Aventura_Click);
            // 
            // cienciaFiccion
            // 
            this.cienciaFiccion.Font = new System.Drawing.Font("Arial", 9F);
            this.cienciaFiccion.Location = new System.Drawing.Point(3, 90);
            this.cienciaFiccion.Name = "cienciaFiccion";
            this.cienciaFiccion.Size = new System.Drawing.Size(225, 23);
            this.cienciaFiccion.TabIndex = 3;
            this.cienciaFiccion.Text = "Ciencia ficción";
            this.cienciaFiccion.UseVisualStyleBackColor = true;
            this.cienciaFiccion.Click += new System.EventHandler(this.cienciaFiccion_Click);
            // 
            // Comedia
            // 
            this.Comedia.Font = new System.Drawing.Font("Arial", 9F);
            this.Comedia.Location = new System.Drawing.Point(3, 119);
            this.Comedia.Name = "Comedia";
            this.Comedia.Size = new System.Drawing.Size(225, 23);
            this.Comedia.TabIndex = 4;
            this.Comedia.Text = "Comedia";
            this.Comedia.UseVisualStyleBackColor = true;
            this.Comedia.Click += new System.EventHandler(this.Comedia_Click);
            // 
            // Documental
            // 
            this.Documental.Font = new System.Drawing.Font("Arial", 9F);
            this.Documental.Location = new System.Drawing.Point(3, 148);
            this.Documental.Name = "Documental";
            this.Documental.Size = new System.Drawing.Size(225, 23);
            this.Documental.TabIndex = 5;
            this.Documental.Text = "Documental";
            this.Documental.UseVisualStyleBackColor = true;
            this.Documental.Click += new System.EventHandler(this.Documental_Click);
            // 
            // Drama
            // 
            this.Drama.Font = new System.Drawing.Font("Arial", 9F);
            this.Drama.Location = new System.Drawing.Point(3, 177);
            this.Drama.Name = "Drama";
            this.Drama.Size = new System.Drawing.Size(225, 23);
            this.Drama.TabIndex = 6;
            this.Drama.Text = "Drama";
            this.Drama.UseVisualStyleBackColor = true;
            this.Drama.Click += new System.EventHandler(this.Drama_Click);
            // 
            // Infantil
            // 
            this.Infantil.Font = new System.Drawing.Font("Arial", 9F);
            this.Infantil.Location = new System.Drawing.Point(3, 206);
            this.Infantil.Name = "Infantil";
            this.Infantil.Size = new System.Drawing.Size(225, 23);
            this.Infantil.TabIndex = 7;
            this.Infantil.Text = "Infantil";
            this.Infantil.UseVisualStyleBackColor = true;
            this.Infantil.Click += new System.EventHandler(this.Infantil_Click);
            // 
            // Romance
            // 
            this.Romance.Font = new System.Drawing.Font("Arial", 9F);
            this.Romance.Location = new System.Drawing.Point(3, 235);
            this.Romance.Name = "Romance";
            this.Romance.Size = new System.Drawing.Size(225, 23);
            this.Romance.TabIndex = 8;
            this.Romance.Text = "Romance";
            this.Romance.UseVisualStyleBackColor = true;
            this.Romance.Click += new System.EventHandler(this.Romance_Click);
            // 
            // Terror
            // 
            this.Terror.Font = new System.Drawing.Font("Arial", 9F);
            this.Terror.Location = new System.Drawing.Point(3, 264);
            this.Terror.Name = "Terror";
            this.Terror.Size = new System.Drawing.Size(225, 23);
            this.Terror.TabIndex = 9;
            this.Terror.Text = "Terror";
            this.Terror.UseVisualStyleBackColor = true;
            this.Terror.Click += new System.EventHandler(this.Terror_Click);
            // 
            // Suspenso
            // 
            this.Suspenso.Font = new System.Drawing.Font("Arial", 9F);
            this.Suspenso.Location = new System.Drawing.Point(3, 293);
            this.Suspenso.Name = "Suspenso";
            this.Suspenso.Size = new System.Drawing.Size(225, 23);
            this.Suspenso.TabIndex = 10;
            this.Suspenso.Text = "Suspenso";
            this.Suspenso.UseVisualStyleBackColor = true;
            this.Suspenso.Click += new System.EventHandler(this.Suspenso_Click);
            // 
            // Musica
            // 
            this.Musica.Font = new System.Drawing.Font("Arial", 9F);
            this.Musica.Location = new System.Drawing.Point(3, 322);
            this.Musica.Name = "Musica";
            this.Musica.Size = new System.Drawing.Size(225, 23);
            this.Musica.TabIndex = 11;
            this.Musica.Text = "Musica";
            this.Musica.UseVisualStyleBackColor = true;
            this.Musica.Click += new System.EventHandler(this.Musica_Click);
            // 
            // peliculasCat
            // 
            this.peliculasCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peliculasCat.AutoScroll = true;
            this.peliculasCat.BackColor = System.Drawing.Color.DarkGreen;
            this.peliculasCat.Location = new System.Drawing.Point(12, 266);
            this.peliculasCat.Name = "peliculasCat";
            this.peliculasCat.Size = new System.Drawing.Size(320, 113);
            this.peliculasCat.TabIndex = 8;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.DarkGreen;
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opciones,
            this.txtBuscar,
            this.buscar});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(619, 27);
            this.menu.TabIndex = 11;
            this.menu.Text = "menu";
            // 
            // opciones
            // 
            this.opciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuenta,
            this.agregarToolStripMenuItem,
            this.salir,
            this.toolStripSeparator1,
            this.contacto});
            this.opciones.ForeColor = System.Drawing.Color.White;
            this.opciones.Image = global::Galgotube.Properties.Resources.if_arrow_sans_down_103299;
            this.opciones.Name = "opciones";
            this.opciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opciones.Size = new System.Drawing.Size(85, 20);
            this.opciones.Text = "Opciones";
            // 
            // cuenta
            // 
            this.cuenta.Image = global::Galgotube.Properties.Resources.if_Customers_Filled_657911;
            this.cuenta.Name = "cuenta";
            this.cuenta.Size = new System.Drawing.Size(123, 22);
            this.cuenta.Text = "Cuenta";
            this.cuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cuenta.Click += new System.EventHandler(this.cuenta_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Image = global::Galgotube.Properties.Resources.if_ic_file_upload_48px_352345;
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.agregarToolStripMenuItem.Text = "Subir";
            this.agregarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.agregarToolStripMenuItem.Visible = false;
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // salir
            // 
            this.salir.Image = global::Galgotube.Properties.Resources.if_22_171495;
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(123, 22);
            this.salir.Text = "Salir";
            this.salir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // contacto
            // 
            this.contacto.Image = global::Galgotube.Properties.Resources.if_online_support_2639877;
            this.contacto.Name = "contacto";
            this.contacto.Size = new System.Drawing.Size(123, 22);
            this.contacto.Text = "Contacto";
            this.contacto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.contacto.Click += new System.EventHandler(this.contacto_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 23);
            this.txtBuscar.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buscar
            // 
            this.buscar.ForeColor = System.Drawing.Color.White;
            this.buscar.Image = global::Galgotube.Properties.Resources.if_67_111124;
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(70, 20);
            this.buscar.Text = "Buscar";
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Galgotube.Properties.Resources.if_Customers_Filled_657911;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Estrenos";
            // 
            // Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.estrenos);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.peliculasCat);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Biblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Biblioteca_Load);
            this.categoria.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.FlowLayoutPanel estrenos;
        private System.Windows.Forms.FlowLayoutPanel categoria;
        private System.Windows.Forms.Button Fantasia;
        private System.Windows.Forms.Button Acción;
        private System.Windows.Forms.Button Aventura;
        private System.Windows.Forms.Button cienciaFiccion;
        private System.Windows.Forms.Button Comedia;
        private System.Windows.Forms.Button Documental;
        private System.Windows.Forms.Button Drama;
        private System.Windows.Forms.Button Infantil;
        private System.Windows.Forms.Button Romance;
        private System.Windows.Forms.Button Terror;
        private System.Windows.Forms.Button Suspenso;
        private System.Windows.Forms.Button Musica;
        private System.Windows.Forms.FlowLayoutPanel peliculasCat;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem opciones;
        public System.Windows.Forms.ToolStripMenuItem cuenta;
        public System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem contacto;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripMenuItem buscar;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label label1;
    }
}