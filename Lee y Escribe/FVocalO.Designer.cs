﻿namespace Lee_y_Escribe
{
    partial class FVocalO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVocalO));
            this.PVocalO = new System.Windows.Forms.Panel();
            this.BTRAS = new System.Windows.Forms.Button();
            this.BRepO = new System.Windows.Forms.Button();
            this.Velocidad = new System.Windows.Forms.TrackBar();
            this.POso = new System.Windows.Forms.PictureBox();
            this.POjo = new System.Windows.Forms.PictureBox();
            this.POlla = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tiempo1 = new System.Windows.Forms.Timer(this.components);
            this.PVocalO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Velocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POjo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POlla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PVocalO
            // 
            this.PVocalO.BackColor = System.Drawing.Color.SteelBlue;
            this.PVocalO.Controls.Add(this.BTRAS);
            this.PVocalO.Controls.Add(this.BRepO);
            this.PVocalO.Controls.Add(this.Velocidad);
            this.PVocalO.Controls.Add(this.POso);
            this.PVocalO.Controls.Add(this.POjo);
            this.PVocalO.Controls.Add(this.POlla);
            this.PVocalO.Controls.Add(this.pictureBox1);
            this.PVocalO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PVocalO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PVocalO.Location = new System.Drawing.Point(0, 0);
            this.PVocalO.Name = "PVocalO";
            this.PVocalO.Size = new System.Drawing.Size(805, 540);
            this.PVocalO.TabIndex = 15;
            // 
            // BTRAS
            // 
            this.BTRAS.BackColor = System.Drawing.Color.SteelBlue;
            this.BTRAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTRAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTRAS.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BTRAS.Image = ((System.Drawing.Image)(resources.GetObject("BTRAS.Image")));
            this.BTRAS.Location = new System.Drawing.Point(12, 458);
            this.BTRAS.Name = "BTRAS";
            this.BTRAS.Size = new System.Drawing.Size(171, 70);
            this.BTRAS.TabIndex = 14;
            this.BTRAS.Text = "    Atras";
            this.BTRAS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTRAS.UseVisualStyleBackColor = false;
            this.BTRAS.AutoSizeChanged += new System.EventHandler(this.BTRAS_Click);
            this.BTRAS.Click += new System.EventHandler(this.BTRAS_Click);
            // 
            // BRepO
            // 
            this.BRepO.BackColor = System.Drawing.Color.SteelBlue;
            this.BRepO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRepO.Enabled = false;
            this.BRepO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRepO.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRepO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BRepO.Image = ((System.Drawing.Image)(resources.GetObject("BRepO.Image")));
            this.BRepO.Location = new System.Drawing.Point(627, 458);
            this.BRepO.Name = "BRepO";
            this.BRepO.Size = new System.Drawing.Size(166, 70);
            this.BRepO.TabIndex = 12;
            this.BRepO.Text = "   Repetir";
            this.BRepO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BRepO.UseVisualStyleBackColor = false;
            this.BRepO.AutoSizeChanged += new System.EventHandler(this.BRepO_Click);
            this.BRepO.Click += new System.EventHandler(this.BRepO_Click);
            // 
            // Velocidad
            // 
            this.Velocidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Velocidad.Location = new System.Drawing.Point(12, 467);
            this.Velocidad.Minimum = -10;
            this.Velocidad.Name = "Velocidad";
            this.Velocidad.Size = new System.Drawing.Size(171, 45);
            this.Velocidad.TabIndex = 11;
            this.Velocidad.Value = -2;
            this.Velocidad.Visible = false;
            // 
            // POso
            // 
            this.POso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("POso.BackgroundImage")));
            this.POso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.POso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POso.Location = new System.Drawing.Point(346, 379);
            this.POso.Name = "POso";
            this.POso.Size = new System.Drawing.Size(121, 149);
            this.POso.TabIndex = 3;
            this.POso.TabStop = false;
            this.POso.Visible = false;
            this.POso.Click += new System.EventHandler(this.POso_Click);
            this.POso.MouseLeave += new System.EventHandler(this.POso_MouseLeave);
            this.POso.MouseHover += new System.EventHandler(this.POso_MouseHover);
            // 
            // POjo
            // 
            this.POjo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("POjo.BackgroundImage")));
            this.POjo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.POjo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POjo.Location = new System.Drawing.Point(556, 39);
            this.POjo.Name = "POjo";
            this.POjo.Size = new System.Drawing.Size(170, 134);
            this.POjo.TabIndex = 2;
            this.POjo.TabStop = false;
            this.POjo.Visible = false;
            this.POjo.Click += new System.EventHandler(this.POjo_Click);
            this.POjo.MouseLeave += new System.EventHandler(this.POjo_MouseLeave);
            this.POjo.MouseHover += new System.EventHandler(this.POjo_MouseHover);
            // 
            // POlla
            // 
            this.POlla.BackgroundImage = global::Lee_y_Escribe.Properties.Resources.Imag32;
            this.POlla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.POlla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POlla.Location = new System.Drawing.Point(86, 30);
            this.POlla.Name = "POlla";
            this.POlla.Size = new System.Drawing.Size(165, 237);
            this.POlla.TabIndex = 1;
            this.POlla.TabStop = false;
            this.POlla.Visible = false;
            this.POlla.Click += new System.EventHandler(this.POlla_Click);
            this.POlla.MouseLeave += new System.EventHandler(this.POlla_MouseLeave);
            this.POlla.MouseHover += new System.EventHandler(this.POlla_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(245, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 320);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Tiempo1
            // 
            this.Tiempo1.Enabled = true;
            this.Tiempo1.Interval = 1000;
            this.Tiempo1.Tick += new System.EventHandler(this.Tiempo1_Tick);
            // 
            // FVocalO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 540);
            this.ControlBox = false;
            this.Controls.Add(this.PVocalO);
            this.Name = "FVocalO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vocal O";
            this.PVocalO.ResumeLayout(false);
            this.PVocalO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Velocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POjo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POlla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PVocalO;
        private System.Windows.Forms.Button BTRAS;
        private System.Windows.Forms.Button BRepO;
        private System.Windows.Forms.TrackBar Velocidad;
        private System.Windows.Forms.PictureBox POso;
        private System.Windows.Forms.PictureBox POjo;
        private System.Windows.Forms.PictureBox POlla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Tiempo1;
    }
}