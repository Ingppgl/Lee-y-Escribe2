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
    public partial class PruebaDePanelesCons : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();

        int Time1 = 0;
        public PruebaDePanelesCons()
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

        private void Tiempo1_Tick(object sender, EventArgs e)
        {

            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            Time1 += 1;
            if (Time1 == 1)
            {

                tarea.Start("Excelente, "
                    + System.Environment.NewLine
                    + "si estás en este nivel, ya aprendiste las vocales, "
                    + System.Environment.NewLine
                    + "Hemos llegado a la segunda lección, "
                    + System.Environment.NewLine
                    + "en esta, aprenderemos las letras llamadas consonantes, "
                    + System.Environment.NewLine
                    + "Estas 22 letras juntas se llaman consonantes, "
                    + System.Environment.NewLine
                    + "tambien, cada una de ellas tiene un nombre, una forma y un sonido, "
                    + System.Environment.NewLine
                    + "Y, uniendo las vocales que aprendimos, con las consonantes formamos sílabas");
            }
        }

        private void ConsM_Click(object sender, EventArgs e)
        {
            LetraM consonantem = new LetraM();
            voz.Pause();
            this.Hide();
            consonantem.Visible = true;
        }

        private void ConsP_Click(object sender, EventArgs e)
        {
            LetraP consonantep = new LetraP();
            voz.Pause();
            this.Hide();
            consonantep.Visible = true;
        }

        private void BatrasPanelCon_Click(object sender, EventArgs e)
        {
            Principal consonante = new Principal();
            voz.Pause();
            this.Close();
            consonante.Visible = true;
        }

        private void LVocalA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoJ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoL_Click(object sender, EventArgs e)
        {
            LetraL consonanteL = new LetraL();
            voz.Pause();
            this.Hide();
            consonanteL.Visible = true;
        }

        private void ConsoN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void Consoñ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoQ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoW_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoX_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoZ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta letra no esta activada");
        }

        private void ConsoL_MouseHover(object sender, EventArgs e)
        {
            ConsoL.Size = new Size(124, 207);
        }

        private void ConsoL_MouseLeave(object sender, EventArgs e)
        {
            ConsoL.Size = new Size(114, 97);
        }

        private void ConsM_MouseHover(object sender, EventArgs e)
        {
            ConsM.Size = new Size(124, 207);
        }

        private void ConsM_MouseLeave(object sender, EventArgs e)
        {
            ConsM.Size = new Size(114, 97);
        }

        private void ConsP_MouseHover(object sender, EventArgs e)
        {
            ConsP.Size = new Size(124, 207);
        }

        private void ConsP_MouseLeave(object sender, EventArgs e)
        {
            ConsP.Size = new Size(114, 97);
        }
    }
}
