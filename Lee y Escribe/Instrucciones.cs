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
    public partial class Instrucciones : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time = 0, Time3;
        public Instrucciones()
        {
            InitializeComponent();
        }
        private void Narrador(object texto)
        {
            voz.Rate = TVelocidad.Value;
            voz.SelectVoiceByHints(VoiceGender.Female);
            //voz.SetOutputToDefaultAudioDevice();
            voz.Speak(texto.ToString());
        }
        private void Tiempo_Tick(object sender, EventArgs e)
        {
            Time += 1;
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            if (Time == 1)
            {
                try
                {
                    tarea.Start(" Ahora te mostraré lo que debes hacer para las lecciones"
                        + System.Environment.NewLine
                        + "dentro de cada pantalla veras símbolos como estos"
                        + System.Environment.NewLine
                        + "Este sirve para repetir la instrucción, en caso de no haber entendido lo que dije debes precionarlo"
                        + System.Environment.NewLine
                        + "Estos para seleccionar la leccion, o el juego, dentro de este panel"
                        + System.Environment.NewLine
                        + "y este sirve para regresar a esta pantalla"
                        );
                }
                catch (Exception)
                {
                    throw;
                }
            }
            if (Time >= 11 && Time % 2 != 0)
            {
                PFlechaR.Visible = true;
            }
            else
            {
                PFlechaR.Visible = false;
            }

            if (Time >= 19 && Time % 2 != 0)
            {
                PFlechaR.Visible = false;
                PFlechaL.Visible = true;
                PFlechaL1.Visible = true;
            }
            else
            {
                PFlechaL.Visible = false;
                PFlechaL1.Visible = false;
            }

            if (Time >= 24)
            {
                PAtras.Visible = true;
                PFlechaL.Visible = false;
                PFlechaL1.Visible = false;
            }
            if (Time == 28)
            {
                Principal principal = new Principal();
                this.Hide();
                principal.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            voz.Pause();
            Time = 33;
            Principal principal = new Principal();
            Salto.Visible = false;
            principal.Visible = true;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            voz.Pause();
            Application.Exit();
        }

        private void Tiempo3_Tick(object sender, EventArgs e)
        {

            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            Time3 += 1;
            
            if (Time3 == 1)
            {
                Salto.Visible = true;
                tarea.Start("Hola,"
                + System.Environment.NewLine
                + "Bienvenido a nuestro espacio aprende a leer y a escribir con tatty,"
                + System.Environment.NewLine
                + "Desde ahora, tienes un nuevo amigo quien te mostrará la manera de leer,"
                + System.Environment.NewLine
                + "Para ayudarte debes seguir mi voz y hacer lo que te indique,"
                + System.Environment.NewLine
                + "Durante el proceso te mostraré lo que debes hacer para completar la lección,"
                + System.Environment.NewLine
                + "Entonces iniciemos, ");
            }

            if(Time3 == 25)
            {
                Tiempo.Enabled = true;
            }
        }
    }
}
