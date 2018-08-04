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
    public partial class FVocalO : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public FVocalO()
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
                tarea.Start("Aquí está la cuarta vocal, "
                + System.Environment.NewLine
                + "esta se llama, o, y puedesver,"
                + System.Environment.NewLine
                + "que tiene una forma redonda, "
                + System.Environment.NewLine
                + "para pronunciar el nombre de esta letra lo hacemos con la boca abierta y decimos, o, "
                + System.Environment.NewLine
                + "al hablar pronunciamos muchas palabras que empiezan con la letra, o, como por ejemplo"
                + System.Environment.NewLine
                + "Ojo"
                + System.Environment.NewLine
                + "Ogro"
                + System.Environment.NewLine
                + "Oso"
                + System.Environment.NewLine
                + "Ahora intentar decir otras palabras que inicien con la letra, o, hazlo, será divertido.");
            }

            if (Time1 == 25)
            {
                POjo.Visible = true;
            }

            if (Time1 == 27)
            {
                POlla.Visible = true;
            }

            if (Time1 == 28)
            {
                POso.Visible = true;             
            }
            if (Time1 == 32)
            {
                BRepO.Enabled = true;
                Tiempo1.Stop();
            }
        }

        private void BRepO_Click(object sender, EventArgs e)
        {
            POso.Visible = false;
            POjo.Visible = false;
            POlla.Visible = false;
            Time1 = 0;
            Tiempo1.Start();
        }
        private void BTRAS_Click(object sender, EventArgs e)
        {
            voz.Pause();
            this.Hide();
        }
        private void POlla_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            tarea.Start("Ogro");
        }

        private void POjo_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            tarea.Start("Ojo");
        }

        private void POso_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            tarea.Start("Oso");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            tarea.Start("O");
        }
    }
}
