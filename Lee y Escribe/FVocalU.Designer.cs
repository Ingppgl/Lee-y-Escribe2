namespace Lee_y_Escribe
{
    partial class FVocalU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVocalU));
            this.PVocalU = new System.Windows.Forms.Panel();
            this.BatrasU = new System.Windows.Forms.Button();
            this.Velocidad = new System.Windows.Forms.TrackBar();
            this.PUlises = new System.Windows.Forms.PictureBox();
            this.PUva = new System.Windows.Forms.PictureBox();
            this.PUña = new System.Windows.Forms.PictureBox();
            this.BRepU = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tiempo1 = new System.Windows.Forms.Timer(this.components);
            this.PVocalU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Velocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PUlises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PUva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PUña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PVocalU
            // 
            this.PVocalU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PVocalU.Controls.Add(this.BatrasU);
            this.PVocalU.Controls.Add(this.Velocidad);
            this.PVocalU.Controls.Add(this.PUlises);
            this.PVocalU.Controls.Add(this.PUva);
            this.PVocalU.Controls.Add(this.PUña);
            this.PVocalU.Controls.Add(this.BRepU);
            this.PVocalU.Controls.Add(this.pictureBox1);
            this.PVocalU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PVocalU.Location = new System.Drawing.Point(0, 0);
            this.PVocalU.Name = "PVocalU";
            this.PVocalU.Size = new System.Drawing.Size(805, 540);
            this.PVocalU.TabIndex = 9;
            // 
            // BatrasU
            // 
            this.BatrasU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BatrasU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BatrasU.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatrasU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BatrasU.Image = ((System.Drawing.Image)(resources.GetObject("BatrasU.Image")));
            this.BatrasU.Location = new System.Drawing.Point(12, 444);
            this.BatrasU.Name = "BatrasU";
            this.BatrasU.Size = new System.Drawing.Size(166, 70);
            this.BatrasU.TabIndex = 13;
            this.BatrasU.Text = "    Atras";
            this.BatrasU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BatrasU.UseVisualStyleBackColor = false;
            this.BatrasU.Click += new System.EventHandler(this.BatrasU_Click_1);
            // 
            // Velocidad
            // 
            this.Velocidad.Location = new System.Drawing.Point(12, 453);
            this.Velocidad.Minimum = -10;
            this.Velocidad.Name = "Velocidad";
            this.Velocidad.Size = new System.Drawing.Size(171, 45);
            this.Velocidad.TabIndex = 9;
            this.Velocidad.Value = -2;
            // 
            // PUlises
            // 
            this.PUlises.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PUlises.Image = global::Lee_y_Escribe.Properties.Resources.Imag21;
            this.PUlises.Location = new System.Drawing.Point(546, 33);
            this.PUlises.Name = "PUlises";
            this.PUlises.Size = new System.Drawing.Size(197, 178);
            this.PUlises.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PUlises.TabIndex = 6;
            this.PUlises.TabStop = false;
            this.PUlises.Click += new System.EventHandler(this.PUlises_Click);
            // 
            // PUva
            // 
            this.PUva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PUva.BackgroundImage")));
            this.PUva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PUva.Location = new System.Drawing.Point(305, 387);
            this.PUva.Name = "PUva";
            this.PUva.Size = new System.Drawing.Size(247, 127);
            this.PUva.TabIndex = 5;
            this.PUva.TabStop = false;
            this.PUva.Click += new System.EventHandler(this.PUva_Click);
            // 
            // PUña
            // 
            this.PUña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PUña.BackgroundImage")));
            this.PUña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PUña.Location = new System.Drawing.Point(61, 47);
            this.PUña.Name = "PUña";
            this.PUña.Size = new System.Drawing.Size(157, 164);
            this.PUña.TabIndex = 4;
            this.PUña.TabStop = false;
            this.PUña.Click += new System.EventHandler(this.PUña_Click);
            // 
            // BRepU
            // 
            this.BRepU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRepU.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRepU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BRepU.Image = ((System.Drawing.Image)(resources.GetObject("BRepU.Image")));
            this.BRepU.Location = new System.Drawing.Point(614, 444);
            this.BRepU.Name = "BRepU";
            this.BRepU.Size = new System.Drawing.Size(166, 70);
            this.BRepU.TabIndex = 3;
            this.BRepU.Text = "   Repetir";
            this.BRepU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BRepU.UseVisualStyleBackColor = true;
            this.BRepU.Click += new System.EventHandler(this.BRepU_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(224, 108);
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
            // FVocalU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 540);
            this.ControlBox = false;
            this.Controls.Add(this.PVocalU);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FVocalU";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vocal U";
            this.PVocalU.ResumeLayout(false);
            this.PVocalU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Velocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PUlises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PUva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PUña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PVocalU;
        private System.Windows.Forms.Button BatrasU;
        private System.Windows.Forms.TrackBar Velocidad;
        private System.Windows.Forms.PictureBox PUlises;
        private System.Windows.Forms.PictureBox PUva;
        private System.Windows.Forms.PictureBox PUña;
        private System.Windows.Forms.Button BRepU;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Tiempo1;
    }
}