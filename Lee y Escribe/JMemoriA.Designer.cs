namespace Lee_y_Escribe
{
    partial class JMemoriA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JMemoriA));
            this.PanelJuego = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RFacil = new System.Windows.Forms.RadioButton();
            this.RMedio = new System.Windows.Forms.RadioButton();
            this.RDificil = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelJuego
            // 
            this.PanelJuego.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PanelJuego.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelJuego.Location = new System.Drawing.Point(0, 0);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(718, 592);
            this.PanelJuego.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblRecord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(718, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 316);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reiniciar Juego";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Atras";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.BackColor = System.Drawing.Color.Transparent;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(90, 69);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(21, 24);
            this.lblRecord.TabIndex = 1;
            this.lblRecord.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // RFacil
            // 
            this.RFacil.AutoSize = true;
            this.RFacil.Checked = true;
            this.RFacil.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFacil.Location = new System.Drawing.Point(68, 39);
            this.RFacil.Name = "RFacil";
            this.RFacil.Size = new System.Drawing.Size(59, 22);
            this.RFacil.TabIndex = 8;
            this.RFacil.TabStop = true;
            this.RFacil.Text = "Fácil";
            this.RFacil.UseVisualStyleBackColor = true;
            this.RFacil.CheckedChanged += new System.EventHandler(this.RFacil_CheckedChanged);
            // 
            // RMedio
            // 
            this.RMedio.AutoSize = true;
            this.RMedio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RMedio.Location = new System.Drawing.Point(68, 67);
            this.RMedio.Name = "RMedio";
            this.RMedio.Size = new System.Drawing.Size(70, 22);
            this.RMedio.TabIndex = 9;
            this.RMedio.Text = "Medio";
            this.RMedio.UseVisualStyleBackColor = true;
            this.RMedio.CheckedChanged += new System.EventHandler(this.RMedio_CheckedChanged);
            // 
            // RDificil
            // 
            this.RDificil.AutoSize = true;
            this.RDificil.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDificil.Location = new System.Drawing.Point(68, 93);
            this.RDificil.Name = "RDificil";
            this.RDificil.Size = new System.Drawing.Size(66, 22);
            this.RDificil.TabIndex = 10;
            this.RDificil.Text = "Difícil";
            this.RDificil.UseVisualStyleBackColor = true;
            this.RDificil.CheckedChanged += new System.EventHandler(this.RDificil_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RDificil);
            this.panel1.Controls.Add(this.RFacil);
            this.panel1.Controls.Add(this.RMedio);
            this.panel1.Location = new System.Drawing.Point(718, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 136);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dificultad";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Lee_y_Escribe.Properties.Resources.aprende;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(718, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 144);
            this.panel3.TabIndex = 12;
            // 
            // JMemoriA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 592);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelJuego);
            this.Name = "JMemoriA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memoria";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelJuego;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RFacil;
        private System.Windows.Forms.RadioButton RMedio;
        private System.Windows.Forms.RadioButton RDificil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}