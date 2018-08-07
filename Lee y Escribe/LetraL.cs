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
    public partial class LetraL : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public LetraL()
        {
            InitializeComponent();
            Velocidad.Visible = false;
            ConsLa.Visible = false;
            LtraLA.Visible = false;
            ConsLe.Visible = false;
            LtraLE.Visible = false;
            ConsLi.Visible = false;
            LtraLI.Visible = false;
            ConsLo.Visible = false;
            LtraLO.Visible = false;
            ConsLu.Visible = false;
            LtraLU.Visible = false;
            BRepL.Enabled = false;
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
                tarea.Start("Esta es la ELe, también es una consonante, "
                        + System.Environment.NewLine
                        + "para escribirla haces una línea,"
                        + System.Environment.NewLine
                        + "la letra ELE al igual que las demas consonantes al juntarlas con las vocales forman sílabas, "
                        + System.Environment.NewLine
                        + "entonces aprendamos como suena la letra ELe seguida de una vocal, osea primero la ELE y luego la combinamos con cada una de las vocales "
                        + System.Environment.NewLine
                        + "con la a suena, La"
                        + System.Environment.NewLine
                        + "con la e suena, Le"
                        + System.Environment.NewLine
                        + "con la i, Li"
                        + System.Environment.NewLine
                        + "con la o, Lo"
                        + System.Environment.NewLine
                        + "y con la u suena, Lu"
                        + System.Environment.NewLine
                        + "si miras las silabas y las repites, La, Le, Li, Lo, y Lu,"
                        + System.Environment.NewLine
                        + "entonces podrás formar palabras igual que hicimos con la eme combinada con las vocales");
            }
            if (Time1 == 27)
            {
                ConsLa.Visible = true;
            }
            if (Time1 == 28)
            {
                LtraLA.Visible = true;
            }
            if (Time1 == 29)
            {
                ConsLe.Visible = true;
            }
            if (Time1 == 30)
            {
                LtraLE.Visible = true;
            }
            if (Time1 == 31)
            {
                ConsLi.Visible = true;
            }
            if (Time1 == 32)
            {
                LtraLI.Visible = true;
            }
            if (Time1 == 33)
            {
                ConsLo.Visible = true;
            }
            if (Time1 == 34)
            {
                LtraLO.Visible = true;
            }
            if (Time1 == 35)
            {
                ConsLu.Visible = true;
            }
            if (Time1 == 36)
            {
                LtraLU.Visible = true;
            }
            if (Time1 == 53)
            {
                SiguienteL.Enabled = true;
                BRepL.Enabled = true;
                Tiempo1.Stop();
            }
        }

        private void BatrasL_Click(object sender, EventArgs e)
        {
            PruebaDePanelesCons consonante = new PruebaDePanelesCons();
            voz.Pause();
            this.Close();
            consonante.Visible = true;
        }

        private void BRepL_Click(object sender, EventArgs e)
        {
            ConsLa.Visible = false;
            LtraLA.Visible = false;
            ConsLe.Visible = false;
            LtraLE.Visible = false;
            ConsLi.Visible = false;
            LtraLI.Visible = false;
            ConsLo.Visible = false;
            LtraLO.Visible = false;
            ConsLu.Visible = false;
            LtraLU.Visible = false;
            BRepL.Enabled = false;
            Time1 = 0;
            Tiempo1.Start();
        }

        private void SiguienteL_Click(object sender, EventArgs e)
        {
            FLupa consonanteL = new FLupa();
            voz.Pause();
            consonanteL.Visible = true;
        }

        private void PVocaleE_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
