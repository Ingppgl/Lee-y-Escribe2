namespace Lee_y_Escribe
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Jmen = new System.Windows.Forms.Button();
            this.Jcar = new System.Windows.Forms.Button();
            this.LConsM = new System.Windows.Forms.Button();
            this.LVocal = new System.Windows.Forms.Button();
            this.LVocales = new System.Windows.Forms.Button();
            this.BJuegos = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Inicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TVelocidad = new System.Windows.Forms.TrackBar();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TVelocidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.Jmen);
            this.panel1.Controls.Add(this.Jcar);
            this.panel1.Controls.Add(this.LConsM);
            this.panel1.Controls.Add(this.LVocal);
            this.panel1.Controls.Add(this.LVocales);
            this.panel1.Controls.Add(this.BJuegos);
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.Inicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 628);
            this.panel1.TabIndex = 1;
            // 
            // Jmen
            // 
            this.Jmen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Jmen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Jmen.FlatAppearance.BorderSize = 0;
            this.Jmen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.Jmen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.Jmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Jmen.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jmen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Jmen.Location = new System.Drawing.Point(18, 385);
            this.Jmen.Name = "Jmen";
            this.Jmen.Size = new System.Drawing.Size(181, 41);
            this.Jmen.TabIndex = 12;
            this.Jmen.Text = "Memoria";
            this.Jmen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Jmen.UseVisualStyleBackColor = true;
            this.Jmen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Jcar
            // 
            this.Jcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Jcar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Jcar.FlatAppearance.BorderSize = 0;
            this.Jcar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.Jcar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.Jcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Jcar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jcar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Jcar.Location = new System.Drawing.Point(18, 338);
            this.Jcar.Name = "Jcar";
            this.Jcar.Size = new System.Drawing.Size(181, 41);
            this.Jcar.TabIndex = 11;
            this.Jcar.Text = "Carro";
            this.Jcar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Jcar.UseVisualStyleBackColor = true;
            this.Jcar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LConsM
            // 
            this.LConsM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LConsM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LConsM.FlatAppearance.BorderSize = 0;
            this.LConsM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.LConsM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.LConsM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LConsM.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConsM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LConsM.Location = new System.Drawing.Point(3, 199);
            this.LConsM.Name = "LConsM";
            this.LConsM.Size = new System.Drawing.Size(210, 37);
            this.LConsM.TabIndex = 10;
            this.LConsM.Text = " Consonantes";
            this.LConsM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LConsM.UseVisualStyleBackColor = true;
            this.LConsM.Click += new System.EventHandler(this.LConsM_Click);
            // 
            // LVocal
            // 
            this.LVocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LVocal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LVocal.FlatAppearance.BorderSize = 0;
            this.LVocal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.LVocal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.LVocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LVocal.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVocal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LVocal.Location = new System.Drawing.Point(18, 152);
            this.LVocal.Name = "LVocal";
            this.LVocal.Size = new System.Drawing.Size(181, 41);
            this.LVocal.TabIndex = 9;
            this.LVocal.Text = "Vocales";
            this.LVocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LVocal.UseVisualStyleBackColor = true;
            this.LVocal.Click += new System.EventHandler(this.LVocal_Click);
            // 
            // LVocales
            // 
            this.LVocales.Enabled = false;
            this.LVocales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LVocales.FlatAppearance.BorderSize = 0;
            this.LVocales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.LVocales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.LVocales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LVocales.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVocales.Image = ((System.Drawing.Image)(resources.GetObject("LVocales.Image")));
            this.LVocales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LVocales.Location = new System.Drawing.Point(0, 69);
            this.LVocales.Name = "LVocales";
            this.LVocales.Size = new System.Drawing.Size(207, 77);
            this.LVocales.TabIndex = 8;
            this.LVocales.Text = " Lecciones";
            this.LVocales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LVocales.UseVisualStyleBackColor = true;
            this.LVocales.Click += new System.EventHandler(this.LVocales_Click);
            // 
            // BJuegos
            // 
            this.BJuegos.Enabled = false;
            this.BJuegos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BJuegos.FlatAppearance.BorderSize = 0;
            this.BJuegos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.BJuegos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.BJuegos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BJuegos.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BJuegos.Image = ((System.Drawing.Image)(resources.GetObject("BJuegos.Image")));
            this.BJuegos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BJuegos.Location = new System.Drawing.Point(6, 255);
            this.BJuegos.Name = "BJuegos";
            this.BJuegos.Size = new System.Drawing.Size(207, 77);
            this.BJuegos.TabIndex = 5;
            this.BJuegos.Text = "   Juegos";
            this.BJuegos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BJuegos.UseVisualStyleBackColor = true;
            this.BJuegos.Click += new System.EventHandler(this.BJuegos_Click);
            // 
            // Salir
            // 
            this.Salir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Salir.FlatAppearance.BorderSize = 0;
            this.Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(6, 550);
            this.Salir.Name = "Salir";
            this.Salir.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Salir.Size = new System.Drawing.Size(204, 66);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "   Salir";
            this.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Inicio
            // 
            this.Inicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Inicio.FlatAppearance.BorderSize = 0;
            this.Inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inicio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicio.Image = ((System.Drawing.Image)(resources.GetObject("Inicio.Image")));
            this.Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Inicio.Location = new System.Drawing.Point(6, 3);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(204, 66);
            this.Inicio.TabIndex = 0;
            this.Inicio.Text = "   Inicio";
            this.Inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Inicio.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TVelocidad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(213, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 628);
            this.panel2.TabIndex = 2;
            // 
            // TVelocidad
            // 
            this.TVelocidad.Location = new System.Drawing.Point(457, 68);
            this.TVelocidad.Minimum = -10;
            this.TVelocidad.Name = "TVelocidad";
            this.TVelocidad.Size = new System.Drawing.Size(171, 45);
            this.TVelocidad.TabIndex = 6;
            this.TVelocidad.Value = -2;
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Interval = 1000;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 628);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprende a Leer y Escribir con Tatty";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TVelocidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BJuegos;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar TVelocidad;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.Button LConsM;
        private System.Windows.Forms.Button LVocal;
        private System.Windows.Forms.Button LVocales;
        private System.Windows.Forms.Button Jmen;
        private System.Windows.Forms.Button Jcar;
    }
}