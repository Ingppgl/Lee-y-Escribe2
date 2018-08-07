namespace Lee_y_Escribe
{
    partial class Instrucciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instrucciones));
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Jmen = new System.Windows.Forms.Button();
            this.Jcar = new System.Windows.Forms.Button();
            this.LConsM = new System.Windows.Forms.Button();
            this.LVocal = new System.Windows.Forms.Button();
            this.Tiempo3 = new System.Windows.Forms.Timer(this.components);
            this.LVocales = new System.Windows.Forms.Button();
            this.BJuegos = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Inicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Salto = new System.Windows.Forms.Button();
            this.PAtras = new System.Windows.Forms.Button();
            this.PFlechaL1 = new System.Windows.Forms.PictureBox();
            this.TVelocidad = new System.Windows.Forms.TrackBar();
            this.PFlechaR = new System.Windows.Forms.PictureBox();
            this.PFlechaL = new System.Windows.Forms.PictureBox();
            this.BRepetir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PFlechaL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TVelocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFlechaR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFlechaL)).BeginInit();
            this.SuspendLayout();
            // 
            // Tiempo
            // 
            this.Tiempo.Interval = 1000;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
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
            this.panel1.Size = new System.Drawing.Size(213, 544);
            this.panel1.TabIndex = 4;
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
            this.Jmen.Visible = false;
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
            this.Jcar.Visible = false;
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
            this.LConsM.Visible = false;
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
            this.LVocal.Visible = false;
            // 
            // Tiempo3
            // 
            this.Tiempo3.Enabled = true;
            this.Tiempo3.Interval = 1000;
            this.Tiempo3.Tick += new System.EventHandler(this.Tiempo3_Tick);
            // 
            // LVocales
            // 
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
            // 
            // BJuegos
            // 
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
            this.Salir.Location = new System.Drawing.Point(3, 467);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(204, 66);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "   Salir";
            this.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Salir.UseVisualStyleBackColor = true;
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
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Salto);
            this.panel2.Controls.Add(this.PAtras);
            this.panel2.Controls.Add(this.PFlechaL1);
            this.panel2.Controls.Add(this.TVelocidad);
            this.panel2.Controls.Add(this.PFlechaR);
            this.panel2.Controls.Add(this.PFlechaL);
            this.panel2.Controls.Add(this.BRepetir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(213, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 544);
            this.panel2.TabIndex = 3;
            // 
            // Salto
            // 
            this.Salto.BackColor = System.Drawing.Color.Transparent;
            this.Salto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salto.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salto.Location = new System.Drawing.Point(239, 474);
            this.Salto.Name = "Salto";
            this.Salto.Size = new System.Drawing.Size(161, 58);
            this.Salto.TabIndex = 11;
            this.Salto.Text = "Saltar Intro";
            this.Salto.UseVisualStyleBackColor = false;
            this.Salto.Visible = false;
            this.Salto.Click += new System.EventHandler(this.button1_Click);
            // 
            // PAtras
            // 
            this.PAtras.BackColor = System.Drawing.Color.Transparent;
            this.PAtras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PAtras.FlatAppearance.BorderSize = 0;
            this.PAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PAtras.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAtras.Image = ((System.Drawing.Image)(resources.GetObject("PAtras.Image")));
            this.PAtras.Location = new System.Drawing.Point(5, 474);
            this.PAtras.Name = "PAtras";
            this.PAtras.Size = new System.Drawing.Size(127, 57);
            this.PAtras.TabIndex = 10;
            this.PAtras.Text = "Atras";
            this.PAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PAtras.UseVisualStyleBackColor = false;
            this.PAtras.Visible = false;
            // 
            // PFlechaL1
            // 
            this.PFlechaL1.BackColor = System.Drawing.Color.Transparent;
            this.PFlechaL1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PFlechaL1.BackgroundImage")));
            this.PFlechaL1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PFlechaL1.Location = new System.Drawing.Point(3, 260);
            this.PFlechaL1.Name = "PFlechaL1";
            this.PFlechaL1.Size = new System.Drawing.Size(140, 66);
            this.PFlechaL1.TabIndex = 9;
            this.PFlechaL1.TabStop = false;
            this.PFlechaL1.Visible = false;
            // 
            // TVelocidad
            // 
            this.TVelocidad.Location = new System.Drawing.Point(477, 11);
            this.TVelocidad.Minimum = -10;
            this.TVelocidad.Name = "TVelocidad";
            this.TVelocidad.Size = new System.Drawing.Size(171, 45);
            this.TVelocidad.TabIndex = 6;
            this.TVelocidad.Value = -2;
            this.TVelocidad.Visible = false;
            // 
            // PFlechaR
            // 
            this.PFlechaR.BackColor = System.Drawing.Color.Transparent;
            this.PFlechaR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PFlechaR.BackgroundImage")));
            this.PFlechaR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PFlechaR.Location = new System.Drawing.Point(415, 474);
            this.PFlechaR.Name = "PFlechaR";
            this.PFlechaR.Size = new System.Drawing.Size(86, 57);
            this.PFlechaR.TabIndex = 8;
            this.PFlechaR.TabStop = false;
            this.PFlechaR.Visible = false;
            // 
            // PFlechaL
            // 
            this.PFlechaL.BackColor = System.Drawing.Color.Transparent;
            this.PFlechaL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PFlechaL.BackgroundImage")));
            this.PFlechaL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PFlechaL.Location = new System.Drawing.Point(5, 88);
            this.PFlechaL.Name = "PFlechaL";
            this.PFlechaL.Size = new System.Drawing.Size(140, 66);
            this.PFlechaL.TabIndex = 7;
            this.PFlechaL.TabStop = false;
            this.PFlechaL.Visible = false;
            // 
            // BRepetir
            // 
            this.BRepetir.BackColor = System.Drawing.Color.Transparent;
            this.BRepetir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BRepetir.FlatAppearance.BorderSize = 0;
            this.BRepetir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BRepetir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BRepetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRepetir.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRepetir.Image = ((System.Drawing.Image)(resources.GetObject("BRepetir.Image")));
            this.BRepetir.Location = new System.Drawing.Point(507, 474);
            this.BRepetir.Name = "BRepetir";
            this.BRepetir.Size = new System.Drawing.Size(141, 57);
            this.BRepetir.TabIndex = 6;
            this.BRepetir.Text = "Repetir";
            this.BRepetir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BRepetir.UseVisualStyleBackColor = false;
            // 
            // Instrucciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 544);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Instrucciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instrucciones";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PFlechaL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TVelocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFlechaR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFlechaL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar TVelocidad;
        private System.Windows.Forms.PictureBox PFlechaR;
        private System.Windows.Forms.PictureBox PFlechaL;
        private System.Windows.Forms.Button BRepetir;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.PictureBox PFlechaL1;
        private System.Windows.Forms.Button PAtras;
        private System.Windows.Forms.Button Salto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Jmen;
        private System.Windows.Forms.Button Jcar;
        private System.Windows.Forms.Button LConsM;
        private System.Windows.Forms.Button LVocal;
        private System.Windows.Forms.Button LVocales;
        private System.Windows.Forms.Button BJuegos;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Timer Tiempo3;
    }
}