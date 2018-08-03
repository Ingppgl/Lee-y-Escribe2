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

        }

        private void BatrasP_Click(object sender, EventArgs e)
        {

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
            Time1 = 1;
            Tiempo1.Start();
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            tarea.Start("Esta es la pe, no es un vocal, "
                        + System.Environment.NewLine
                        + "esta se llama consonante,"
                        + System.Environment.NewLine
                        + "y para escribirla parece como dos vocales unidas, y se llama pe, "
                        + System.Environment.NewLine
                        + "la letra pe al igual que las demas consonantes al juntarlas con las vocales forman silabas, "
                        + System.Environment.NewLine
                        + "entonces aprendamos como suena la letra pe unida con las vocales, "
                        + System.Environment.NewLine
                         + "primero la pe y luego la vocal a suena pa"
                        + System.Environment.NewLine
                        + "primero la pe y luego la vocal e suena pe"
                        + System.Environment.NewLine
                        + "primero la pe y luego la vocal i suena pI"
                        + System.Environment.NewLine
                        + "primero la pe y luego la vocal o suena po"
                         + System.Environment.NewLine
                        + "primero la pe y luego la vocal u suena pu");
        }

        private void SiguienteP_Click(object sender, EventArgs e)
        {
            FPapá consonantep = new FPapá();
            voz.Pause();
            this.Hide();
            consonantep.Visible = true;
        }
    }
}
