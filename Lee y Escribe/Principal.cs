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
    public partial class Principal : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time = 0;
        public Principal()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            TVelocidad.Visible = false;
            LVocal.Visible = false;
            LConsM.Visible = false;
            Jmen.Visible = false;
            Jcar.Visible = false;
        }

        private void Narrador(object texto)
        {
            voz.Rate = TVelocidad.Value;
            voz.SelectVoiceByHints(VoiceGender.Female);
            voz.SetOutputToDefaultAudioDevice();
            voz.Speak(texto.ToString());
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            Time += 1;

            if (Time == 1)
            {
                try
                {
                    tarea.Start("Elige una actividad");
                    LVocales.Enabled = true;
                    BJuegos.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la Voz");
                    throw;
                }
            }
        }

        private void BJuegos_Click(object sender, EventArgs e)
        {
            Jcar.Visible = true;
            Jmen.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            JCarro jcarro = new JCarro();
            voz.Pause();
            LVocal.Visible = false;
            LConsM.Visible = false;
            Jcar.Visible = false;
            Jmen.Visible = false;
            jcarro.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            JMemoriA memoria = new JMemoriA();
            voz.Pause();
            LVocal.Visible = false;
            LConsM.Visible = false;
            Jcar.Visible = false;
            Jmen.Visible = false;
            memoria.Visible = true;
        }

        private void LVocales_Click(object sender, EventArgs e)
        {
            LVocal.Visible = true;
            LConsM.Visible = true;
        }

        private void LVocal_Click(object sender, EventArgs e)
        {
            PruebaDePaneles pruebapaneles = new PruebaDePaneles();
            voz.Pause();
            LVocal.Visible = false;
            LConsM.Visible = false;
            Jcar.Visible = false;
            Jmen.Visible = false;
            pruebapaneles.Visible = true;
        }

        private void LConsM_Click(object sender, EventArgs e)
        {
            PruebaDePanelesCons pruebapanelesC = new PruebaDePanelesCons();
            voz.Pause();
            LVocal.Visible = false;
            LConsM.Visible = false;
            Jcar.Visible = false;
            Jmen.Visible = false;
            pruebapanelesC.Visible = true;
        }

        private void JCar_Click(object sender, EventArgs e)
        {
            JCarro jcarro = new JCarro();
            jcarro.Visible = true;
        }
    }
}
