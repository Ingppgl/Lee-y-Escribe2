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
    public partial class LetraM : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public LetraM()
        {
            InitializeComponent();
            BRepM.Enabled = false;
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
                tarea.Start("Esta es la letra m, no es una vocal, esta forma parte del grupo llamadas consonantes "
                        + System.Environment.NewLine
                        + "y para escribirla parece como dos vocales, u, juntas con las patitas hacia abajo y se llama, eme, "
                        + System.Environment.NewLine
                        + "la letra eme al igual que las demas consonantes al combinarla con las vocales forman silabas, "
                        + System.Environment.NewLine
                        + "entonces aprendamos como suena la letra eme seguida de una vocal, osea primero la eme y luego la combinamos con cada una de las vocales "
                        + System.Environment.NewLine
                        + "la eme combinada con la, a, suena Ma"
                        + System.Environment.NewLine
                        + "Con la e, suena Me"
                        + System.Environment.NewLine
                        + "Con la i, suena MI"
                        + System.Environment.NewLine
                        + "Con la o, suena Mo"
                         + System.Environment.NewLine
                        + "Y con la u, suena Mu, recuerda elsonido de cada combinación de la consonante eme con las vocales, ma, me, mi, mo, mu, esto te ayudará en la siguiente lección ");
            }
            if (Time1 == 37)
            {
                ConsMa.Visible = true;
            }

            if (Time1 == 38)
            {
                LtraA.Visible = true;
            }

            if (Time1 == 39)
            {
                ConsMe.Visible = true;
            }
            if (Time1 == 40)
            {
                LtraE.Visible = true;
            }
            if (Time1 == 41)
            {
                ConsMi.Visible = true;
            }
            if (Time1 == 42)
            {
                LtraI.Visible = true;
            }
            if (Time1 == 43)
            {
                ConsMo.Visible = true;
            }
            if (Time1 == 44)
            {
                LtraO.Visible = true;
            }
            if (Time1 == 46)
            {
                ConsMu.Visible = true;
            }
            if (Time1 == 47)
            {
                LtraU.Visible = true;
            }
            if (Time1 == 53)
            {
                BRepM.Enabled = true;
                SiguienteM.Enabled = true;
                Tiempo1.Stop();
            }
        }
        private void BatrasM_Click(object sender, EventArgs e)
        {
            PruebaDePanelesCons consonante = new PruebaDePanelesCons();
            voz.Pause();
            this.Close();
            consonante.Visible = true;
        }

        private void BRepM_Click_1(object sender, EventArgs e)
        {
            ConsMa.Visible = false;
            LtraA.Visible = false;
            ConsMe.Visible = false;
            LtraE.Visible = false;
            ConsMi.Visible = false;
            LtraI.Visible = false;
            ConsMo.Visible = false;
            LtraO.Visible = false;
            ConsMu.Visible = false;
            LtraU.Visible = false;
            Time1 = 0;
            Tiempo1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FMamá leccionM = new FMamá();
            voz.Pause();
            leccionM.Visible = true;
        }
    }
}
