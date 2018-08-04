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
    public partial class FVocalI : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public FVocalI()
        {
            InitializeComponent();
            BRepI.Enabled = false;
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
                tarea.Start("Aquí está la tercera vocal, "
                        + System.Environment.NewLine
                        + "esta se llama, i, muy diferente a las dos anteriores,"
                        + System.Environment.NewLine
                        + " tiene forma de una pequeña raya con un punto sobre ella, "
                        + System.Environment.NewLine
                        + " para pronunciar el nombre de esta letra lo hacemos con la boca casi cerrada y decimos, i, con esta, "
                        + " también pronunciamos muchas palabras que al inicio tienen la letra, i, como por ejemplo, "
                        + System.Environment.NewLine
                        + "Iglesia ,"
                        + System.Environment.NewLine
                        + "Isla ,"
                        + System.Environment.NewLine
                        + "India"
                        + System.Environment.NewLine
                        + " ¿Sabes otras palabras que inicien con la letra, i,?  ");

            }

            if (Time1 == 28)
            {
                PIglesia.Visible = true;
            }

            if (Time1 == 30)
            {
                PIsla.Visible = true;
            }

            if (Time1 == 32)
            {
                PIman.Visible = true;
                BRepI.Enabled = true;
                Tiempo1.Stop();
            }
        }

        private void BRepI_Click(object sender, EventArgs e)
        {
            PIman.Visible = false;
            PIglesia.Visible = false;
            PIsla.Visible = false;
            Time1 = 0;
            Tiempo1.Start();
        }
        private void BatrasI_Click(object sender, EventArgs e)
        {
            voz.Pause();
            this.Hide();
        }

        private void PIman_Click(object sender, EventArgs e)
        {
            Thread Decir = new Thread(new ParameterizedThreadStart(Narrador));
            Decir.Start("India ");
        }

        private void PIglesia_Click(object sender, EventArgs e)
        {
            Thread Decir = new Thread(new ParameterizedThreadStart(Narrador));
            Decir.Start("Iglesia ");
        }

        private void PIsla_Click_1(object sender, EventArgs e)
        {
            Thread Decir = new Thread(new ParameterizedThreadStart(Narrador));
            Decir.Start("Isla ");
        }
    }
}
