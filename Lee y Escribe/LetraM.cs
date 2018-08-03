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
            Velocidad.Visible = false;
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
                tarea.Start("Esta es la m, no es un vocal, "
                        + System.Environment.NewLine
                        + "esta se llama, consonante,"
                        + System.Environment.NewLine
                        + "y para escribirla parece como dos vocales unidas, y se llama eme, "
                        + System.Environment.NewLine
                        + "la letra eme al igual que las demas consonantes al juntarlas con las vocales forman silabas, "
                        + System.Environment.NewLine
                        + "entonces aprendamos como suena la letra eme unida con las vocales, "
                        + System.Environment.NewLine
                        + "primero la eme y luego la vocal a suena Ma"
                        + System.Environment.NewLine
                        + "primero la eme y luego la vocal e suena Me"
                        + System.Environment.NewLine
                        + "primero la eme y luego la vocal i suena MI"
                        + System.Environment.NewLine
                        + "primero la eme y luego la vocal o suena Mo"
                         + System.Environment.NewLine
                        + "primero la eme y luego la vocal u suena Mu");
            }
            if (Time1 == 29)
            {
                ConsMa.Visible = true;
            }

            if (Time1 == 30)
            {
                LtraA.Visible = true;
            }

            if (Time1 == 32)
            {
                ConsMe.Visible = true;
            }
            if (Time1 == 33)
            {
                LtraE.Visible = true;
            }
            if (Time1 == 35)
            {
                ConsMi.Visible = true;
            }
            if (Time1 == 36)
            {
                LtraI.Visible = true;
            }
            if (Time1 == 38)
            {
                ConsMo.Visible = true;
            }
            if (Time1 == 39)
            {
                LtraO.Visible = true;
            }
            if (Time1 == 41)
            {
                ConsMu.Visible = true;
            }
            if (Time1 == 42)
            {
                LtraU.Visible = true;
                BRepM.Enabled = true;
                Tiempo1.Stop();
            }
        }
        private void BatrasM_Click(object sender, EventArgs e)
        {
            PruebaDePanelesCons consonante = new PruebaDePanelesCons();
            voz.Pause();
            this.Hide();
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
            Time1 = 1;
            Tiempo1.Start();
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            tarea.Start("Esta es la m, no es un vocal, "
                        + System.Environment.NewLine
                        + "esta se llama, consonante,"
                        + System.Environment.NewLine
                        + "y para escribirla parece como dos vocales unidas, y se llama eme, "
                        + System.Environment.NewLine
                        + "la letra eme al igual que las demas consonantes al juntarlas con las vocales forman silabas, "
                        + System.Environment.NewLine
                        + "entonces aprendamos como suena la letra eme unida con las vocales, "
                        + System.Environment.NewLine
                       + "primero la eme y luego la vocal a suena Ma"
                        + System.Environment.NewLine
                        + "primero la eme y luego la vocal e suena Me"
                        + System.Environment.NewLine
                        + "primero la eme y luego la vocal i suena MI"
                        + System.Environment.NewLine
                        + "primero la eme y luego la vocal o suena Mo"
                         + System.Environment.NewLine
                        + "primero la eme y luego la vocal u suena Mu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FMamá leccionM = new FMamá();
            voz.Pause();
            this.Hide();
            leccionM.Visible = true;
        }
    



    }
}
