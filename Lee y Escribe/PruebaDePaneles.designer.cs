namespace Lee_y_Escribe
{
    partial class PruebaDePaneles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PruebaDePaneles));
            this.PanelVocales = new System.Windows.Forms.Panel();
            this.BRepPanelVocal = new System.Windows.Forms.Button();
            this.BatrasPanelVocal = new System.Windows.Forms.Button();
            this.Velocidad = new System.Windows.Forms.TrackBar();
            this.LVocalU = new System.Windows.Forms.PictureBox();
            this.LVocalO = new System.Windows.Forms.PictureBox();
            this.LVocalI = new System.Windows.Forms.PictureBox();
            this.LVocalE = new System.Windows.Forms.PictureBox();
            this.LVocalA = new System.Windows.Forms.PictureBox();
            this.Tiempo1 = new System.Windows.Forms.Timer(this.components);
            this.Tiempo2 = new System.Windows.Forms.Timer(this.components);
            this.PanelVocales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Velocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LVocalU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LVocalO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LVocalI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LVocalE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LVocalA)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelVocales
            // 
            this.PanelVocales.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelVocales.Controls.Add(this.BRepPanelVocal);
            this.PanelVocales.Controls.Add(this.BatrasPanelVocal);
            this.PanelVocales.Controls.Add(this.Velocidad);
            this.PanelVocales.Controls.Add(this.LVocalU);
            this.PanelVocales.Controls.Add(this.LVocalO);
            this.PanelVocales.Controls.Add(this.LVocalI);
            this.PanelVocales.Controls.Add(this.LVocalE);
            this.PanelVocales.Controls.Add(this.LVocalA);
            this.PanelVocales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelVocales.Location = new System.Drawing.Point(0, 0);
            this.PanelVocales.Name = "PanelVocales";
            this.PanelVocales.Size = new System.Drawing.Size(805, 540);
            this.PanelVocales.TabIndex = 6;
            // 
            // BRepPanelVocal
            // 
            this.BRepPanelVocal.Enabled = false;
            this.BRepPanelVocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRepPanelVocal.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRepPanelVocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BRepPanelVocal.Image = ((System.Drawing.Image)(resources.GetObject("BRepPanelVocal.Image")));
            this.BRepPanelVocal.Location = new System.Drawing.Point(609, 461);
            this.BRepPanelVocal.Name = "BRepPanelVocal";
            this.BRepPanelVocal.Size = new System.Drawing.Size(166, 70);
            this.BRepPanelVocal.TabIndex = 44;
            this.BRepPanelVocal.Text = "   Repetir";
            this.BRepPanelVocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BRepPanelVocal.UseVisualStyleBackColor = true;
            this.BRepPanelVocal.Click += new System.EventHandler(this.BRepPanelVocal_Click);
            // 
            // BatrasPanelVocal
            // 
            this.BatrasPanelVocal.BackColor = System.Drawing.Color.SteelBlue;
            this.BatrasPanelVocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BatrasPanelVocal.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatrasPanelVocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BatrasPanelVocal.Image = ((System.Drawing.Image)(resources.GetObject("BatrasPanelVocal.Image")));
            this.BatrasPanelVocal.Location = new System.Drawing.Point(22, 461);
            this.BatrasPanelVocal.Name = "BatrasPanelVocal";
            this.BatrasPanelVocal.Size = new System.Drawing.Size(166, 70);
            this.BatrasPanelVocal.TabIndex = 15;
            this.BatrasPanelVocal.Text = "    Atras";
            this.BatrasPanelVocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BatrasPanelVocal.UseVisualStyleBackColor = false;
            this.BatrasPanelVocal.AutoSizeChanged += new System.EventHandler(this.BatrasPanelVocal_Click);
            this.BatrasPanelVocal.Click += new System.EventHandler(this.BatrasPanelVocal_Click);
            // 
            // Velocidad
            // 
            this.Velocidad.Location = new System.Drawing.Point(17, 495);
            this.Velocidad.Minimum = -10;
            this.Velocidad.Name = "Velocidad";
            this.Velocidad.Size = new System.Drawing.Size(171, 45);
            this.Velocidad.TabIndex = 8;
            this.Velocidad.Value = -2;
            // 
            // LVocalU
            // 
            this.LVocalU.Image = ((System.Drawing.Image)(resources.GetObject("LVocalU.Image")));
            this.LVocalU.Location = new System.Drawing.Point(451, 246);
            this.LVocalU.Name = "LVocalU";
            this.LVocalU.Size = new System.Drawing.Size(171, 166);
            this.LVocalU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LVocalU.TabIndex = 7;
            this.LVocalU.TabStop = false;
            this.LVocalU.BackColorChanged += new System.EventHandler(this.LVocalU_Click);
            this.LVocalU.Click += new System.EventHandler(this.LVocalU_Click);
            // 
            // LVocalO
            // 
            this.LVocalO.Image = ((System.Drawing.Image)(resources.GetObject("LVocalO.Image")));
            this.LVocalO.Location = new System.Drawing.Point(189, 246);
            this.LVocalO.Name = "LVocalO";
            this.LVocalO.Size = new System.Drawing.Size(171, 166);
            this.LVocalO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LVocalO.TabIndex = 6;
            this.LVocalO.TabStop = false;
            this.LVocalO.BackColorChanged += new System.EventHandler(this.LVocalO_Click);
            this.LVocalO.Click += new System.EventHandler(this.LVocalO_Click);
            // 
            // LVocalI
            // 
            this.LVocalI.Image = ((System.Drawing.Image)(resources.GetObject("LVocalI.Image")));
            this.LVocalI.Location = new System.Drawing.Point(560, 46);
            this.LVocalI.Name = "LVocalI";
            this.LVocalI.Size = new System.Drawing.Size(171, 166);
            this.LVocalI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LVocalI.TabIndex = 5;
            this.LVocalI.TabStop = false;
            this.LVocalI.BackColorChanged += new System.EventHandler(this.LVocalI_Click);
            this.LVocalI.Click += new System.EventHandler(this.LVocalI_Click);
            // 
            // LVocalE
            // 
            this.LVocalE.Image = ((System.Drawing.Image)(resources.GetObject("LVocalE.Image")));
            this.LVocalE.Location = new System.Drawing.Point(323, 46);
            this.LVocalE.Name = "LVocalE";
            this.LVocalE.Size = new System.Drawing.Size(171, 166);
            this.LVocalE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LVocalE.TabIndex = 4;
            this.LVocalE.TabStop = false;
            this.LVocalE.BackColorChanged += new System.EventHandler(this.LVocalE_Click);
            this.LVocalE.Click += new System.EventHandler(this.LVocalE_Click);
            // 
            // LVocalA
            // 
            this.LVocalA.Image = ((System.Drawing.Image)(resources.GetObject("LVocalA.Image")));
            this.LVocalA.Location = new System.Drawing.Point(86, 46);
            this.LVocalA.Name = "LVocalA";
            this.LVocalA.Size = new System.Drawing.Size(171, 166);
            this.LVocalA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LVocalA.TabIndex = 0;
            this.LVocalA.TabStop = false;
            this.LVocalA.BackColorChanged += new System.EventHandler(this.LVocalA_Click);
            this.LVocalA.Click += new System.EventHandler(this.LVocalA_Click_1);
            // 
            // Tiempo1
            // 
            this.Tiempo1.Enabled = true;
            this.Tiempo1.Interval = 1000;
            this.Tiempo1.Tick += new System.EventHandler(this.Tiempo1_Tick_1);
            // 
            // Tiempo2
            // 
            this.Tiempo2.Interval = 1000;
            // 
            // PruebaDePaneles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 540);
            this.Controls.Add(this.PanelVocales);
            this.Name = "PruebaDePaneles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PruebaDePaneles";
            this.PanelVocales.ResumeLayout(false);
            this.PanelVocales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Velocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LVocalU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LVocalO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LVocalI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LVocalE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LVocalA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelVocales;
        private System.Windows.Forms.Button BRepPanelVocal;
        private System.Windows.Forms.Button BatrasPanelVocal;
        private System.Windows.Forms.TrackBar Velocidad;
        private System.Windows.Forms.PictureBox LVocalU;
        private System.Windows.Forms.PictureBox LVocalO;
        private System.Windows.Forms.PictureBox LVocalI;
        private System.Windows.Forms.PictureBox LVocalE;
        private System.Windows.Forms.PictureBox LVocalA;
        private System.Windows.Forms.Timer Tiempo1;
        private System.Windows.Forms.Timer Tiempo2;
    }
}