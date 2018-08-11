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
    public partial class FLupa : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public FLupa()
        {
            InitializeComponent();

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
                        + "La, "
                        + System.Environment.NewLine
                        + "Le"
                        + System.Environment.NewLine
                        + "Li"
                        + System.Environment.NewLine
                        + "Lo"
                        + System.Environment.NewLine
                        + "Lu"
                         + System.Environment.NewLine
                        + "forman las siguientes palabras"
                        + System.Environment.NewLine
                        + "lupa, "
                        + System.Environment.NewLine
                        + "mula"
                        + System.Environment.NewLine
                        + "pala"
                        + System.Environment.NewLine
                        + "pila"
                        + System.Environment.NewLine
                        + "y con la convinación de las sílabas y las palabras podemos formar oración"
                         + System.Environment.NewLine
                        + "como por ejemlo"
                         + System.Environment.NewLine
                        + "lola leia la ele");
            }
            if (Time1 == 15)
            {
                LA.Visible = true;
            }

            if (Time1 == 16)
            {
                LE.Visible = true;
            }

            if (Time1 == 17)
            {
                LI.Visible = true;
            }
            if (Time1 == 18)
            {
                LO.Visible = true;
            }
            if (Time1 == 19)
            {
                LU.Visible = true;
            }
            if (Time1 == 25)
            {
                Lupa.Visible = true;
            }
            if (Time1 == 27)
            {
                Mula.Visible = true;
            }
            if (Time1 == 28)
            {
                Pala.Visible = true;
            }
            if (Time1 == 30)
            {
                Pila.Visible = true;

            }
            if (Time1 == 39)
            {
                LiO.Visible = true;
                BRepL.Enabled = true;
                Tiempo1.Stop();
            }

        }
        private void BAtrasLeccionL_Click(object sender, EventArgs e)
        {
            LetraM consonante = new LetraM();
            voz.Pause();
            this.Close();
            consonante.Visible = true;
        }

        private void BRepL_Click(object sender, EventArgs e)
        {
            Velocidad.Visible = false;
            LA.Visible = false;
            LE.Visible = false;
            LI.Visible = false;
            LO.Visible = false;
            LU.Visible = false;
            Lupa.Visible = false;
            Mula.Visible = false;
            Pala.Visible = false;
            Pila.Visible = false;
            LiO.Visible = false;

            BRepL.Enabled = false;
            Time1 = 0;
            Tiempo1.Start();
        }
    }
}
