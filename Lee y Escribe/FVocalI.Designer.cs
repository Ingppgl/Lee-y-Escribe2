namespace Lee_y_Escribe
{
    partial class FVocalI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVocalI));
            this.PVocalI = new System.Windows.Forms.Panel();
            this.BatrasI = new System.Windows.Forms.Button();
            this.Velocidad = new System.Windows.Forms.TrackBar();
            this.PIglesia = new System.Windows.Forms.PictureBox();
            this.PIsla = new System.Windows.Forms.PictureBox();
            this.PIman = new System.Windows.Forms.PictureBox();
            this.BRepI = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tiempo1 = new System.Windows.Forms.Timer(this.components);
            this.PVocalI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Velocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIglesia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIsla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PVocalI
            // 
            this.PVocalI.BackColor = System.Drawing.Color.SteelBlue;
            this.PVocalI.Controls.Add(this.BatrasI);
            this.PVocalI.Controls.Add(this.Velocidad);
            this.PVocalI.Controls.Add(this.PIglesia);
            this.PVocalI.Controls.Add(this.PIsla);
            this.PVocalI.Controls.Add(this.PIman);
            this.PVocalI.Controls.Add(this.BRepI);
            this.PVocalI.Controls.Add(this.pictureBox1);
            this.PVocalI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PVocalI.Location = new System.Drawing.Point(0, 0);
            this.PVocalI.Name = "PVocalI";
            this.PVocalI.Size = new System.Drawing.Size(805, 540);
            this.PVocalI.TabIndex = 14;
            // 
            // BatrasI
            // 
            this.BatrasI.BackColor = System.Drawing.Color.SteelBlue;
            this.BatrasI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BatrasI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BatrasI.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatrasI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BatrasI.Image = ((System.Drawing.Image)(resources.GetObject("BatrasI.Image")));
            this.BatrasI.Location = new System.Drawing.Point(12, 458);
            this.BatrasI.Name = "BatrasI";
            this.BatrasI.Size = new System.Drawing.Size(166, 70);
            this.BatrasI.TabIndex = 12;
            this.BatrasI.Text = "    Atras";
            this.BatrasI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BatrasI.UseVisualStyleBackColor = false;
            this.BatrasI.Click += new System.EventHandler(this.BatrasI_Click);
            // 
            // Velocidad
            // 
            this.Velocidad.Location = new System.Drawing.Point(12, 474);
            this.Velocidad.Minimum = -10;
            this.Velocidad.Name = "Velocidad";
            this.Velocidad.Size = new System.Drawing.Size(171, 45);
            this.Velocidad.TabIndex = 10;
            this.Velocidad.Value = -2;
            this.Velocidad.Visible = false;
            // 
            // PIglesia
            // 
            this.PIglesia.BackColor = System.Drawing.Color.SteelBlue;
            this.PIglesia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PIglesia.BackgroundImage")));
            this.PIglesia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PIglesia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIglesia.Location = new System.Drawing.Point(70, 43);
            this.PIglesia.Name = "PIglesia";
            this.PIglesia.Size = new System.Drawing.Size(153, 186);
            this.PIglesia.TabIndex = 14;
            this.PIglesia.TabStop = false;
            this.PIglesia.Visible = false;
            this.PIglesia.Click += new System.EventHandler(this.PIglesia_Click);
            this.PIglesia.MouseLeave += new System.EventHandler(this.PIglesia_MouseLeave);
            this.PIglesia.MouseHover += new System.EventHandler(this.PIglesia_MouseHover);
            // 
            // PIsla
            // 
            this.PIsla.BackColor = System.Drawing.Color.SteelBlue;
            this.PIsla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PIsla.BackgroundImage")));
            this.PIsla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PIsla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIsla.Location = new System.Drawing.Point(501, 12);
            this.PIsla.Name = "PIsla";
            this.PIsla.Size = new System.Drawing.Size(235, 145);
            this.PIsla.TabIndex = 13;
            this.PIsla.TabStop = false;
            this.PIsla.Visible = false;
            this.PIsla.Click += new System.EventHandler(this.PIsla_Click_1);
            this.PIsla.MouseLeave += new System.EventHandler(this.PIsla_MouseLeave);
            this.PIsla.MouseHover += new System.EventHandler(this.PIsla_MouseHover);
            // 
            // PIman
            // 
            this.PIman.BackColor = System.Drawing.Color.SteelBlue;
            this.PIman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PIman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIman.Image = global::Lee_y_Escribe.Properties.Resources.Imag4;
            this.PIman.Location = new System.Drawing.Point(449, 268);
            this.PIman.Name = "PIman";
            this.PIman.Size = new System.Drawing.Size(156, 198);
            this.PIman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIman.TabIndex = 2;
            this.PIman.TabStop = false;
            this.PIman.Visible = false;
            this.PIman.Click += new System.EventHandler(this.PIman_Click);
            this.PIman.MouseLeave += new System.EventHandler(this.PIman_MouseLeave);
            this.PIman.MouseHover += new System.EventHandler(this.PIman_MouseHover);
            // 
            // BRepI
            // 
            this.BRepI.BackColor = System.Drawing.Color.SteelBlue;
            this.BRepI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRepI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRepI.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRepI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BRepI.Image = ((System.Drawing.Image)(resources.GetObject("BRepI.Image")));
            this.BRepI.Location = new System.Drawing.Point(627, 458);
            this.BRepI.Name = "BRepI";
            this.BRepI.Size = new System.Drawing.Size(166, 70);
            this.BRepI.TabIndex = 11;
            this.BRepI.Text = "   Repetir";
            this.BRepI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BRepI.UseVisualStyleBackColor = false;
            this.BRepI.Click += new System.EventHandler(this.BRepI_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(214, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // Tiempo1
            // 
            this.Tiempo1.Enabled = true;
            this.Tiempo1.Interval = 1000;
            this.Tiempo1.Tick += new System.EventHandler(this.Tiempo1_Tick);
            // 
            // FVocalI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 540);
            this.ControlBox = false;
            this.Controls.Add(this.PVocalI);
            this.Name = "FVocalI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vocal I";
            this.Load += new System.EventHandler(this.FVocalI_Load);
            this.PVocalI.ResumeLayout(false);
            this.PVocalI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Velocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIglesia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIsla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PVocalI;
        private System.Windows.Forms.Button BatrasI;
        private System.Windows.Forms.TrackBar Velocidad;
        private System.Windows.Forms.PictureBox PIglesia;
        private System.Windows.Forms.PictureBox PIsla;
        private System.Windows.Forms.PictureBox PIman;
        private System.Windows.Forms.Button BRepI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Tiempo1;
    }
}