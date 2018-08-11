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
    public partial class PruebaDePaneles : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();

        int Time1 = 0;
        public PruebaDePaneles()
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
        private void Tiempo1_Tick_1(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            Time1 += 1;
            if (Time1 == 1)
            {
                tarea.Start("Excelente, "
                    + System.Environment.NewLine
                    + "Hemos llegado a la primera lección, "
                    + System.Environment.NewLine
                    + "en esta, aprenderemos las letras llamadas vocales, "
                    + System.Environment.NewLine
                    + "Estas 5 letras juntas se llaman vocales, "
                    + System.Environment.NewLine
                    + "pero, cada una de ellas tiene un nombre, una forma y un sonido, "
                    + System.Environment.NewLine
                    + "Ahora vamos con la primera vocal, ");
            }
            if(Time1 == 23)
            {
                LVocalA.Size = new Size(178,  173);
                Tiempo1.Stop();
                BRepPanelVocal.Enabled = true;
            }
        }

        private void LVocalA_Click(object sender, EventArgs e)
        {
            FVocalA vocala = new FVocalA();
            voz.Pause();
            this.Hide();
            vocala.Visible = true;
        }

        private void LVocalE_Click(object sender, EventArgs e)
        {
            FVocalE vocale = new FVocalE();
            voz.Pause();
            vocale.Visible = true;
        }

        private void LVocalI_Click(object sender, EventArgs e)
        {
            FVocalI vocali = new FVocalI();
            voz.Pause();
            vocali.Visible = true;
        }
        private void LVocalO_Click(object sender, EventArgs e)
        {
            FVocalO vocalo = new FVocalO();
            voz.Pause();
            vocalo.Visible = true;
        }
        private void LVocalU_Click(object sender, EventArgs e)
        {
            FVocalU vocalu = new FVocalU();
            voz.Pause();
            vocalu.Visible = true;
        }
        private void BatrasPanelVocal_Click(object sender, EventArgs e)
        {
            voz.Pause();
            this.Close();
        }
        private void LVocalA_Click_1(object sender, EventArgs e)
        {
            FVocalA vocala = new FVocalA();
            voz.Pause();
            vocala.Visible = true;
        }
        private void BRepPanelVocal_Click(object sender, EventArgs e)
        {
            LVocalA.Size = new Size(171, 166);
            BRepPanelVocal.Enabled = false;
            Time1 = -1;
            Tiempo1.Start();
        }

        private void LVocalA_MouseHover(object sender, EventArgs e)
        {
            LVocalA.Size = new Size(181, 176);
        }

        private void LVocalA_MouseLeave(object sender, EventArgs e)
        {
            LVocalA.Size = new Size(171, 166);
        }

        private void LVocalE_MouseHover(object sender, EventArgs e)
        {
            LVocalE.Size = new Size(181, 176);
        }

        private void LVocalE_MouseLeave(object sender, EventArgs e)
        {
            LVocalE.Size = new Size(171, 166);
        }

        private void LVocalI_MouseHover(object sender, EventArgs e)
        {
            LVocalI.Size = new Size(181, 176);
        }

        private void LVocalI_MouseLeave(object sender, EventArgs e)
        {
            LVocalI.Size = new Size(171, 166);
        }

        private void LVocalO_MouseHover(object sender, EventArgs e)
        {
            LVocalO.Size = new Size(181, 176);
        }

        private void LVocalO_MouseLeave(object sender, EventArgs e)
        {
            LVocalO.Size = new Size(171, 166);
        }

        private void LVocalU_MouseHover(object sender, EventArgs e)
        {
            LVocalU.Size = new Size(181, 176);
        }

        private void LVocalU_MouseLeave(object sender, EventArgs e)
        {
            LVocalU.Size = new Size(171, 166);
        }
    }
}
