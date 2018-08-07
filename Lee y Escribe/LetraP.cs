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
    public partial class LetraP : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public LetraP()
        {
            InitializeComponent();
            Velocidad.Visible = false;
            ConsPa.Visible = false;
            LtraPA.Visible = false;
            ConsPe.Visible = false;
            LtraPE.Visible = false;
            ConsPi.Visible = false;
            LtraPI.Visible = false;
            ConsPo.Visible = false;
            LtraPO.Visible = false;
            ConsPu.Visible = false;
            LtraPU.Visible = false;
            BRepP.Enabled = false;
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
                tarea.Start("Esta es la pe, también es una consonante, "
                        + System.Environment.NewLine
                        + "para escribirla haces una linea y al lado derecho una media luna,"
                        + System.Environment.NewLine
                        + "la letra pe al igual que las demas consonantes al juntarlas con las vocales forman sílabas, "
                        + System.Environment.NewLine
                        + "entonces aprendamos como suena la letra pe seguida de una vocal, osea primero la pe y luego la combinamos con cada una de las vocales "
                        + System.Environment.NewLine
                        + "con la a suena, pa"
                        + System.Environment.NewLine
                        + "con la e suena, pe"
                        + System.Environment.NewLine
                        + "con la i, pi"
                        + System.Environment.NewLine
                        + "con la o, po"
                        + System.Environment.NewLine
                        + "y con la u suena, pu"
                        +System.Environment.NewLine
                        + "si miras las silabas y las repites, pa, pe, pi, po, y pu,"
                        + System.Environment.NewLine
                        + "entonces podrás formar palabras igual que hicimos con la eme combinada con las vocales");
            }
            if (Time1 == 28)
            {
                ConsPa.Visible = true;
            }
            if (Time1 == 29)
            {
                LtraPA.Visible = true;
            }
            if (Time1 == 31)
            {
                ConsPe.Visible = true;
            }
            if (Time1 == 32)
            {
                LtraPE.Visible = true;
            }
            if (Time1 == 33)
            {
                ConsPi.Visible = true;
            }
            if (Time1 == 34)
            {
                LtraPI.Visible = true;
            }
            if (Time1 == 35)
            {
                ConsPo.Visible = true;
            }
            if (Time1 == 36)
            {
                LtraPO.Visible = true;
            }
            if (Time1 == 37)
            {
                ConsPu.Visible = true;
            }
            if(Time1 == 38)
            {
                LtraPU.Visible = true;
            }
            if (Time1 == 45)
            {
                SiguienteP.Enabled = true;
                BRepP.Enabled = true;
                Tiempo1.Stop();
            }
        }

        private void BatrasP_Click(object sender, EventArgs e)
        {
            PruebaDePanelesCons consonante = new PruebaDePanelesCons();
            voz.Pause();
            this.Close();
            consonante.Visible = true;
        }

        private void BRepP_Click(object sender, EventArgs e)
        {
            ConsPa.Visible = false;
            LtraPA.Visible = false;
            ConsPe.Visible = false;
            LtraPE.Visible = false;
            ConsPi.Visible = false;
            LtraPI.Visible = false;
            ConsPo.Visible = false;
            LtraPO.Visible = false;
            ConsPu.Visible = false;
            LtraPU.Visible = false;
            BRepP.Enabled = false;
            Time1 = 0;
            Tiempo1.Start();
        }

        private void SiguienteP_Click(object sender, EventArgs e)
        {
            FPapá consonantep = new FPapá();
            voz.Pause();
            consonantep.Visible = true;
        }
    }
}
