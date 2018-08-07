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
    public partial class FVocalE : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public FVocalE()
        {
            InitializeComponent();
            Velocidad.Visible = false;
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
                tarea.Start("Excelente, si estás en este nivel, ya aprendiste la letra, a, y estás listo para esta lección"
                        + System.Environment.NewLine
                        + "Aquí está la segunda vocal, "
                        + System.Environment.NewLine
                        + "esta se llama, e, y es diferente a la vocal, a, pues,"
                        + System.Environment.NewLine
                        + "tiene una forma media redonda, "
                        + System.Environment.NewLine
                        + "para pronunciar el nombre de esta letra lo hacemos con la boca casi cerrada y decimos, e, con "
                        +"esta tambien pronunciamos muchas palabras que al inicio tienen la letra, e, como por ejemplo, "
                        + System.Environment.NewLine
                        + "Elefante"
                        + System.Environment.NewLine
                        + "Estrella"
                        + System.Environment.NewLine
                        + "Espada");
            }

            if (Time1 == 37)
            {
                PElefante.Visible = true;
            }

            if (Time1 == 39)
            {
                PEstrella.Visible = true;
            }

            if (Time1 == 41)
            {
                PEspada.Visible = true;
                BRepE.Enabled = true;
                Tiempo1.Stop();
            }
        }
        private void BRepE_Click(object sender, EventArgs e)
        {
            PElefante.Visible = false;
            PEspada.Visible = false;
            PEstrella.Visible = false;
            Time1 = 0;
            Tiempo1.Start();
        }
        private void BatrasE_Click(object sender, EventArgs e)
        {
            voz.Pause();
            this.Hide();
        }

        private void PElefante_Click(object sender, EventArgs e)
        {
            Thread Elef = new Thread(new ParameterizedThreadStart(Narrador));
            Elef.Start("Elefante ");
        }

        private void PEspada_Click(object sender, EventArgs e)
        {
            Thread Esp = new Thread(new ParameterizedThreadStart(Narrador));
            Esp.Start("Espada ");
        }

        private void PEstrella_Click(object sender, EventArgs e)
        {
            Thread Star= new Thread(new ParameterizedThreadStart(Narrador));
            Star.Start("Estrella ");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Thread E = new Thread(new ParameterizedThreadStart(Narrador));
            E.Start("E ");
        }

        private void PEstrella_MouseHover(object sender, EventArgs e)
        {
            PEstrella.Size = new Size(167, 169);
        }

        private void PEstrella_MouseLeave(object sender, EventArgs e)
        {
            PEstrella.Size = new Size(157, 159);
        }

        private void PEspada_MouseHover(object sender, EventArgs e)
        {
            PEspada.Size = new Size(167, 143);
        }

        private void PEspada_MouseLeave(object sender, EventArgs e)
        {
            PEspada.Size = new Size(157, 133);
        }

        private void PElefante_MouseHover(object sender, EventArgs e)
        {
            PElefante.Size = new Size(233, 150);
        }

        private void PElefante_MouseLeave(object sender, EventArgs e)
        {
            PElefante.Size = new Size(223, 140);
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            pictureBox14.Size = new Size(355, 330);
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Size = new Size(345, 320);
        }
    }
}
