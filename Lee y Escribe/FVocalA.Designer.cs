﻿namespace Lee_y_Escribe
{
    partial class FVocalA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVocalA));
            this.PVocalA = new System.Windows.Forms.Panel();
            this.BAtrasA = new System.Windows.Forms.Button();
            this.Velocidad = new System.Windows.Forms.TrackBar();
            this.PAnillo = new System.Windows.Forms.PictureBox();
            this.PAvion = new System.Windows.Forms.PictureBox();
            this.PAbeja = new System.Windows.Forms.PictureBox();
            this.BRepA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tiempo1 = new System.Windows.Forms.Timer(this.components);
            this.PVocalA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Velocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAnillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAvion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAbeja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PVocalA
            // 
            this.PVocalA.BackColor = System.Drawing.Color.SteelBlue;
            this.PVocalA.Controls.Add(this.BAtrasA);
            this.PVocalA.Controls.Add(this.Velocidad);
            this.PVocalA.Controls.Add(this.PAnillo);
            this.PVocalA.Controls.Add(this.PAvion);
            this.PVocalA.Controls.Add(this.PAbeja);
            this.PVocalA.Controls.Add(this.BRepA);
            this.PVocalA.Controls.Add(this.pictureBox1);
            this.PVocalA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PVocalA.Location = new System.Drawing.Point(0, 0);
            this.PVocalA.Name = "PVocalA";
            this.PVocalA.Size = new System.Drawing.Size(805, 540);
            this.PVocalA.TabIndex = 8;
            // 
            // BAtrasA
            // 
            this.BAtrasA.BackColor = System.Drawing.Color.SteelBlue;
            this.BAtrasA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAtrasA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAtrasA.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAtrasA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BAtrasA.Image = ((System.Drawing.Image)(resources.GetObject("BAtrasA.Image")));
            this.BAtrasA.Location = new System.Drawing.Point(17, 458);
            this.BAtrasA.Name = "BAtrasA";
            this.BAtrasA.Size = new System.Drawing.Size(166, 70);
            this.BAtrasA.TabIndex = 13;
            this.BAtrasA.Text = "    Atras";
            this.BAtrasA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BAtrasA.UseVisualStyleBackColor = false;
            this.BAtrasA.AutoSizeChanged += new System.EventHandler(this.BAtrasA_Click_1);
            this.BAtrasA.Click += new System.EventHandler(this.BAtrasA_Click_1);
            // 
            // Velocidad
            // 
            this.Velocidad.Location = new System.Drawing.Point(12, 495);
            this.Velocidad.Minimum = -10;
            this.Velocidad.Name = "Velocidad";
            this.Velocidad.Size = new System.Drawing.Size(171, 45);
            this.Velocidad.TabIndex = 9;
            this.Velocidad.Value = -2;
            // 
            // PAnillo
            // 
            this.PAnillo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PAnillo.BackgroundImage")));
            this.PAnillo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PAnillo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PAnillo.Location = new System.Drawing.Point(183, 322);
            this.PAnillo.Name = "PAnillo";
            this.PAnillo.Size = new System.Drawing.Size(90, 130);
            this.PAnillo.TabIndex = 6;
            this.PAnillo.TabStop = false;
            this.PAnillo.Click += new System.EventHandler(this.PAnillo_Click);
            this.PAnillo.MouseLeave += new System.EventHandler(this.PAnillo_MouseLeave);
            this.PAnillo.MouseHover += new System.EventHandler(this.PAnillo_MouseHover);
            // 
            // PAvion
            // 
            this.PAvion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PAvion.BackgroundImage")));
            this.PAvion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PAvion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PAvion.Location = new System.Drawing.Point(541, 52);
            this.PAvion.Name = "PAvion";
            this.PAvion.Size = new System.Drawing.Size(204, 121);
            this.PAvion.TabIndex = 5;
            this.PAvion.TabStop = false;
            this.PAvion.Click += new System.EventHandler(this.PAvion_Click);
            this.PAvion.MouseLeave += new System.EventHandler(this.PAvion_MouseLeave);
            this.PAvion.MouseHover += new System.EventHandler(this.PAvion_MouseHover);
            // 
            // PAbeja
            // 
            this.PAbeja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PAbeja.BackgroundImage")));
            this.PAbeja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PAbeja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PAbeja.Location = new System.Drawing.Point(82, 26);
            this.PAbeja.Name = "PAbeja";
            this.PAbeja.Size = new System.Drawing.Size(157, 197);
            this.PAbeja.TabIndex = 4;
            this.PAbeja.TabStop = false;
            this.PAbeja.Click += new System.EventHandler(this.PAbeja_Click);
            this.PAbeja.MouseLeave += new System.EventHandler(this.PAbeja_MouseLeave);
            this.PAbeja.MouseHover += new System.EventHandler(this.PAbeja_MouseHover);
            // 
            // BRepA
            // 
            this.BRepA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRepA.Enabled = false;
            this.BRepA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRepA.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRepA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BRepA.Image = ((System.Drawing.Image)(resources.GetObject("BRepA.Image")));
            this.BRepA.Location = new System.Drawing.Point(627, 458);
            this.BRepA.Name = "BRepA";
            this.BRepA.Size = new System.Drawing.Size(166, 70);
            this.BRepA.TabIndex = 3;
            this.BRepA.Text = "   Repetir";
            this.BRepA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BRepA.UseVisualStyleBackColor = true;
            this.BRepA.AutoSizeChanged += new System.EventHandler(this.BRepA_Click);
            this.BRepA.Click += new System.EventHandler(this.BRepA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(224, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 320);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // Tiempo1
            // 
            this.Tiempo1.Enabled = true;
            this.Tiempo1.Interval = 1000;
            this.Tiempo1.Tick += new System.EventHandler(this.Tiempo1_Tick);
            // 
            // FVocalA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 540);
            this.ControlBox = false;
            this.Controls.Add(this.PVocalA);
            this.Name = "FVocalA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vocal A";
            this.PVocalA.ResumeLayout(false);
            this.PVocalA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Velocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAnillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAvion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAbeja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PVocalA;
        private System.Windows.Forms.Button BAtrasA;
        private System.Windows.Forms.TrackBar Velocidad;
        private System.Windows.Forms.PictureBox PAnillo;
        private System.Windows.Forms.PictureBox PAvion;
        private System.Windows.Forms.PictureBox PAbeja;
        private System.Windows.Forms.Button BRepA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Tiempo1;
    }
}