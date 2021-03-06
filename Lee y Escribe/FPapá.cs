﻿using System;
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
    public partial class FPapá : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public FPapá()
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
        private void BAtrasLeccionP_Click(object sender, EventArgs e)
        {
            voz.Pause();
            this.Close();
        }

        private void Tiempo1_Tick(object sender, EventArgs e)
        {
            Time1 += 1;
            if (Time1 == 1)
            {
                Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
                tarea.Start("Ya hemos aprendido como suena una vocal con una consonante, "
                        + System.Environment.NewLine
                        + "que juntas se forma una sílabas,"
                        + System.Environment.NewLine
                        + "ahora aprenderemos a formar palabras, "
                        + System.Environment.NewLine
                        + "y las sílabas, "
                        + System.Environment.NewLine
                        + "Pa, "
                        + System.Environment.NewLine
                        + "Pe"
                        + System.Environment.NewLine
                        + "Pi"
                        + System.Environment.NewLine
                        + "Po"
                        + System.Environment.NewLine
                        + "Pu"
                         + System.Environment.NewLine
                        + "forman las siguientes palabras"
                        + System.Environment.NewLine
                        + "Papá, "
                        + System.Environment.NewLine
                        + "puma"
                        + System.Environment.NewLine
                        + "pipa"
                        + System.Environment.NewLine
                        + "mapa"
                        + System.Environment.NewLine
                        + "y con la convinación de las sílabas y las palabras podemos formar oracion"
                         + System.Environment.NewLine
                        + "como por ejemlo"
                         + System.Environment.NewLine
                        + "papá ama a mamá");
            }
            if (Time1 == 15)
            {
                Pa.Visible = true;
            }

            if (Time1 == 16)
            {
                Pe.Visible = true;
            }

            if (Time1 == 17)
            {
                Pi.Visible = true;
            }
            if (Time1 == 18)
            {
                Po.Visible = true;
            }
            if (Time1 == 19)
            {
                Pu.Visible = true;
            }
            if (Time1 == 25)
            {
                Papá.Visible = true;
            }
            if (Time1 == 27)
            {
                Puma.Visible = true;
            }
            if (Time1 == 28)
            {
                Pipa.Visible = true;
            }
            if (Time1 == 29)
            {
                Mapa.Visible = true;
            }
            if (Time1 == 39)
            {
                PapáO.Visible = true;
            }
            if (Time1 == 42)
            {
                BRepPapá.Enabled = true;
                Tiempo1.Stop();
            }
        }

        private void BRepPapá_Click(object sender, EventArgs e)
        {
            Pa.Visible = false;
            Pe.Visible = false;
            Pi.Visible = false;
            Po.Visible = false;
            Pu.Visible = false;
            Papá.Visible = false;
            Puma.Visible = false;
            Pipa.Visible = false;
            Mapa.Visible = false;
            PapáO.Visible = false;
            Time1 = 0;
            Tiempo1.Start();
        }
    }
}
