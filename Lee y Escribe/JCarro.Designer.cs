namespace Lee_y_Escribe
{
    partial class JCarro
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
            this.carro1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblPuntos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Inicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carro1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // carro1
            // 
            this.carro1.BackColor = System.Drawing.Color.Transparent;
            this.carro1.BackgroundImage = global::Lee_y_Escribe.Properties.Resources.Carr1;
            this.carro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carro1.Location = new System.Drawing.Point(7, 522);
            this.carro1.Name = "carro1";
            this.carro1.Size = new System.Drawing.Size(48, 103);
            this.carro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.carro1.TabIndex = 0;
            this.carro1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(84, 74);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(21, 24);
            this.lblPuntos.TabIndex = 1;
            this.lblPuntos.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Lee_y_Escribe.Properties.Resources.aprende;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(137, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 151);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Lee_y_Escribe.Properties.Resources.Paleta;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.Inicio);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblPuntos);
            this.panel2.Location = new System.Drawing.Point(137, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 335);
            this.panel2.TabIndex = 3;
            // 
            // Inicio
            // 
            this.Inicio.AutoSize = true;
            this.Inicio.BackColor = System.Drawing.Color.Transparent;
            this.Inicio.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicio.Location = new System.Drawing.Point(67, 168);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(75, 26);
            this.Inicio.TabIndex = 3;
            this.Inicio.Text = "Iniciar";
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Atras";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // JCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lee_y_Escribe.Properties.Resources.Calle1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(339, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.carro1);
            this.DoubleBuffered = true;
            this.Name = "JCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JCarro";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JCarro_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.carro1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox carro1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Inicio;
    }
}