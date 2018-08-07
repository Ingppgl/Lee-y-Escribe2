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
    public partial class FVocalU : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public FVocalU()
        {
            InitializeComponent();
            Velocidad.Visible = false;
            PUlises.Visible = false;
            PUña.Visible = false;
            PUva.Visible = false;
            BRepU.Enabled = false;
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
                tarea.Start("Aquí está la última vocal, "
                        + System.Environment.NewLine
                        + "esta se llama, u, si tedas cuenta,"
                        + System.Environment.NewLine
                        + " tiene una forma de curba, "
                        + System.Environment.NewLine
                        + "para pronunciar el nombre de esta letra lo hacemos con la boca abierta grande y decimos, u, "
                        + System.Environment.NewLine
                        + "al hablar pronunciamos muchas palabras que empiezan con la letra, u, como por ejemplo"
                        + System.Environment.NewLine
                        + "Uña"
                        + System.Environment.NewLine
                        + "Uva"
                        + System.Environment.NewLine
                        + "Unicornio");
            }

            if (Time1 == 25)
            {
                PUña.Visible = true;
            }

            if (Time1 == 27)
            {
                PUva.Visible = true;
            }

            if (Time1 == 28)
            {
                PUlises.Visible = true;
                BRepU.Enabled = true;
                Tiempo1.Stop();
            }
        }
             private void BatrasU_Click_1(object sender, EventArgs e)
        {
            voz.Pause();
            this.Close();
        }

        private void BRepU_Click_1(object sender, EventArgs e)
        {
            PUlises.Visible = false;
            PUña.Visible = false;
            PUva.Visible = false;
            Time1 = 0;
            Tiempo1.Start();
        }

        private void PUlises_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            tarea.Start("Unicornio");
        }

        private void PUña_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            tarea.Start("Uña");
        }

        private void PUva_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            tarea.Start("Uva");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Thread U = new Thread(new ParameterizedThreadStart(Narrador));
            U.Start("U ");
        }

        private void PUlises_MouseHover(object sender, EventArgs e)
        {
            PUlises.Size = new Size(207, 188);
        }

        private void PUlises_MouseLeave(object sender, EventArgs e)
        {
            PUlises.Size = new Size(197, 178);
        }

        private void PUña_MouseHover(object sender, EventArgs e)
        {
            PUña.Size = new Size(167, 174);
        }

        private void PUña_MouseLeave(object sender, EventArgs e)
        {
            PUña.Size = new Size(157, 164);
        }

        private void PUva_MouseHover(object sender, EventArgs e)
        {
            PUva.Size = new Size(257, 137);
        }

        private void PUva_MouseLeave(object sender, EventArgs e)
        {
            PUva.Size = new Size(247, 127);
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
