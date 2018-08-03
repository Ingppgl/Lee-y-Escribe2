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
    public partial class FMamá : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public FMamá()
        {
            InitializeComponent();
            MA.Visible = false;
            ME.Visible = false;
            MI.Visible = false;
            MO.Visible = false;
            MU.Visible = false;
            Mami.Visible = false;
            Mamá.Visible = false;
            Ama.Visible = false;
            Mima.Visible = false;
            BRepMama.Enabled = false;
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
                tarea.Start("Ya hemos aprendido como suena una vocal con una consonante, "
                        + System.Environment.NewLine
                        + "que juntas se forma una silaba,"
                        + System.Environment.NewLine
                        + "ahora aprenderemos a formar palabras, "
                        + System.Environment.NewLine
                        + "y las silabas, "
                        + System.Environment.NewLine
                        + "ma, "
                        + System.Environment.NewLine
                        + "me"
                        + System.Environment.NewLine
                        + "mi"
                        + System.Environment.NewLine
                        + "mo"
                        + System.Environment.NewLine
                        + "mu"
                         + System.Environment.NewLine
                        + "forman las siguientes palabras"
                        + System.Environment.NewLine
                        + "mami, "
                        + System.Environment.NewLine
                        + "mamá"
                        + System.Environment.NewLine
                        + "ama"
                        + System.Environment.NewLine
                        + "mima");
            }
            if (Time1 == 15)
            {
                MA.Visible = true;
            }

            if (Time1 == 16)
            {
                ME.Visible = true;
            }

            if (Time1 == 17)
            {
                MI.Visible = true;
            }
            if (Time1 == 18)
            {
                MO.Visible = true;
            }
            if (Time1 == 19)
            {
                MU.Visible = true;
            }
            if (Time1 == 25)
            {
                Mami.Visible = true;
            }
            if (Time1 == 27)
            {
                Mamá.Visible = true;
            }
            if (Time1 == 28)
            {
                Ama.Visible = true;
            }
            if (Time1 == 29)
            {
                Mima.Visible = true;
                BRepMama.Enabled = true;
                Tiempo1.Stop();
            }
        }
        private void BAtrasLeccionM_Click(object sender, EventArgs e)
        {
            Principal vocales = new Principal();
            voz.Pause();
            this.Hide();
            vocales.Visible = true;
        }

        private void BRepMama_Click(object sender, EventArgs e)
        {
            Velocidad.Visible = false;
            MA.Visible = false;
            ME.Visible = false;
            MI.Visible = false;
            MO.Visible = false;
            MU.Visible = false;
            Mami.Visible = false;
            Mamá.Visible = false;
            Ama.Visible = false;
            Mima.Visible = false;
            Time1 = 1;
            Tiempo1.Start();
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            tarea.Start("Ya hemos aprendido como suena una vocal con una consonante, "
                        + System.Environment.NewLine
                        + "que juntas se forma una silaba,"
                        + System.Environment.NewLine
                        + "ahora aprenderemos a formar palabras, "
                        + System.Environment.NewLine
                        + "y las silabas, "
                        + System.Environment.NewLine
                        + "ma, "
                        + System.Environment.NewLine
                        + "me"
                        + System.Environment.NewLine
                        + "mi"
                        + System.Environment.NewLine
                        + "mo"
                        + System.Environment.NewLine
                        + "mu"
                         + System.Environment.NewLine
                        + "forman las siguientes palabras"
                        + System.Environment.NewLine
                        + "mami, "
                        + System.Environment.NewLine
                        + "mamá"
                        + System.Environment.NewLine
                        + "ama"
                        + System.Environment.NewLine
                        + "mima");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
