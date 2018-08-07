using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;

namespace Lee_y_Escribe
{
    public partial class FVocalA : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public FVocalA()
        {
            InitializeComponent();
            Velocidad.Visible = false;
            PAnillo.Visible = false;
            PAbeja.Visible = false;
            PAvion.Visible = false;
            BRepA.Enabled = false;
        }
        private void Narrador(object texto)
        {

            voz.SelectVoiceByHints(VoiceGender.Female);
            voz.Rate = Velocidad.Value;
            voz.SetOutputToDefaultAudioDevice();
            voz.Speak(texto.ToString());

        }
        private void Tiempo1_Tick(object sender, EventArgs e)
        {
            Time1 += 1;
            if (Time1 == 1)
            {
                Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
                tarea.Start("Maravilloso, "
                        + System.Environment.NewLine
                        + "Aquí está la primera vocal, "
                        + System.Environment.NewLine
                        + "esta se llama, a, si tedas cuenta,"
                        + System.Environment.NewLine
                        + " tiene una forma redonda y una pequeña raya a un lado, "
                        + System.Environment.NewLine
                        + "para pronunciar el nombre de esta letra lo hacemos con la boca abierta grande y decimos, a, "
                        + System.Environment.NewLine
                        + "al hablar pronunciamos muchas palabras que empiezan con la letra, a, como por ejemplo"
                        + System.Environment.NewLine
                        + "Abeja"
                        + System.Environment.NewLine
                        + "Avión"
                        + System.Environment.NewLine
                        + "Anillo."
                        + System.Environment.NewLine
                        + "Hay muchas palabras que inician con la letra, a, puedes practicar junto a un adulto y veras que no es dificil");
            }

            if (Time1 == 29)
            {
                PAbeja.Visible = true;
            }
            if (Time1 == 31)
            {
                PAvion.Visible = true;
            }
            if (Time1 == 33)
            {
                PAnillo.Visible = true;
                BRepA.Enabled = true;
                Tiempo1.Stop();
            }
        }

        private void BRepA_Click(object sender, EventArgs e)
        {
            PAnillo.Visible = false;
            PAbeja.Visible = false;
            PAvion.Visible = false;
            Time1 = -1;
            Tiempo1.Start();
        }
        private void BAtrasA_Click_1(object sender, EventArgs e)
        {
            voz.Pause();
            this.Close();
        }

        private void PAbeja_Click(object sender, EventArgs e)
        {
            Thread Abe = new Thread(new ParameterizedThreadStart(Narrador));
            Abe.Start("Abeja ");
        }

        private void PAvion_Click(object sender, EventArgs e)
        {
            Thread Plane = new Thread(new ParameterizedThreadStart(Narrador));
            Plane.Start("Avión ");
        }

        private void PAnillo_Click(object sender, EventArgs e)
        {
            Thread Anil = new Thread(new ParameterizedThreadStart(Narrador));
            Anil.Start("Anillo ");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Thread A = new Thread(new ParameterizedThreadStart(Narrador));
            A.Start("A ");
        }

        private void PAbeja_MouseHover(object sender, EventArgs e)
        {
            PAbeja.Size = new Size(167, 207);
        }

        private void PAbeja_MouseLeave(object sender, EventArgs e)
        {
            PAbeja.Size = new Size(157, 197);
        }

        private void PAvion_MouseHover(object sender, EventArgs e)
        {
            PAvion.Size = new Size(214, 131);
        }

        private void PAvion_MouseLeave(object sender, EventArgs e)
        {
            PAvion.Size = new Size(204, 121);
        }

        private void PAnillo_MouseHover(object sender, EventArgs e)
        {
            PAnillo.Size = new Size(100, 140);
        }

        private void PAnillo_MouseLeave(object sender, EventArgs e)
        {
            PAnillo.Size = new Size(90, 130);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(355, 330);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(345, 320);
        }
    }
}
