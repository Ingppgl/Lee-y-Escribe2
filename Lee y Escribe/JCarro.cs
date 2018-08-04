using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lee_y_Escribe
{
    public partial class JCarro : Form
    {

        List<PictureBox> ListaObtaculosAmarillo = new List<PictureBox>();
        Random RnTipoObstaculo = new Random();
        int Velocidad = 2; int TotalPuntos = 0;
        //int Animacion1 = 0;
        bool estado = false;

        public JCarro()
        {
            InitializeComponent();
        }

        public void CrearObstaculo(List<PictureBox> ListaElementos, Form panelJuegoUno, int DistaciaUno, int DistanciaDos)
        {
            int NumeroCarro = 1;
            int TipoObstaculo = RnTipoObstaculo.Next(1, 7);
            int UbucacionObstaculo = RnTipoObstaculo.Next(1, 7);
            int DistanciaUbicacionObstaculo = (UbucacionObstaculo == 1) ? DistaciaUno : DistanciaDos;

            PictureBox pb = new PictureBox();
            pb.Location = new Point(DistanciaUbicacionObstaculo, 0);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Ima" + NumeroCarro + TipoObstaculo);
            pb.BackColor = Color.Transparent;
            pb.Tag = NumeroCarro + "_" + TipoObstaculo;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            ListaElementos.Add(pb);
            panelJuegoUno.Controls.Add(pb);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox ImagenCarro in ListaObtaculosAmarillo)
            {
                int MovimentoY;
                MovimentoY = ImagenCarro.Location.Y;
                MovimentoY = MovimentoY + Velocidad;
                ImagenCarro.Location = new Point(ImagenCarro.Location.X, MovimentoY);
            }

            //Crear Otro Elemento

            if (ListaObtaculosAmarillo.Count > 0)
            {
                if (ListaObtaculosAmarillo[(ListaObtaculosAmarillo.Count) - 1].Location.Y > 275)
                {
                    CrearObstaculo(ListaObtaculosAmarillo, this, 10, 80);
                }
            }
            // Validar si las vocales chocan con el carro o se pasan directo del carro 

            if (ListaObtaculosAmarillo.Count > 0)
            {
                for (int i = 0; i < ListaObtaculosAmarillo.Count; i++)
                {
                    if (ListaObtaculosAmarillo[i].Location.Y > 650)
                    {
                        if (ListaObtaculosAmarillo[i].Tag.ToString() != "1_6")
                        {   //Si las vocales se van, que me muestre la puntuacion y reinicie el juego                       
                            estado = estado == true ? false : true;
                            Inicio.Text = Inicio.Text.Equals("Iniciar") ? "Pausa" : "Iniciar";                         
                            timer2.Enabled = estado;
                            MessageBox.Show("  Dejaste ir Una Vocal" + System.Environment.NewLine 
                                + "Tu Puntuaión = " + TotalPuntos);
                            ReiniciarJuego();
                        }
                        this.Controls.Remove(ListaObtaculosAmarillo[i]);
                        ListaObtaculosAmarillo.Remove(ListaObtaculosAmarillo[i]);
                    }

                    //sI HAY CHOQUE
                    if (ListaObtaculosAmarillo[i].Bounds.IntersectsWith(carro1.Bounds))
                    {
                        if (ListaObtaculosAmarillo[i].Tag.ToString() != "1_6")
                        {
                            this.Controls.Remove(ListaObtaculosAmarillo[i]);
                            TotalPuntos = Convert.ToInt32(lblPuntos.Text) + 5;
                            if (TotalPuntos % 3 == 0)
                            {
                                Velocidad++;
                            }
                            if (TotalPuntos % 100 ==  0)
                            {
                                Velocidad = 10;
                            }
                            if (TotalPuntos == 200)
                            {
                                Velocidad = 10;
                            }

                            lblPuntos.Text = TotalPuntos.ToString();

                            ListaObtaculosAmarillo.Remove(ListaObtaculosAmarillo[i]);
                        }
                        else
                        {

                            
                            estado = estado == true ? false : true;
                            Inicio.Text = Inicio.Text.Equals("Iniciar") ? "Pausa" : "Iniciar";
                            
                            timer2.Enabled = estado;
                            MessageBox.Show("   Chocaste el Obstáculo" + System.Environment.NewLine
                                + "Tu Puntuaión = " + TotalPuntos);
                            ReiniciarJuego();
                            this.Controls.Remove(ListaObtaculosAmarillo[i]);
                            ListaObtaculosAmarillo.Remove(ListaObtaculosAmarillo[i]);
                            
                        }
                    }
                }
            }
        }
        public void ReiniciarJuego()
        {
            lblPuntos.Text = " 0 ";
            Velocidad = 3;
        }

        private void JCarro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Movimiento del carro izquierda derecha, o no movimiento con el juego en pausa
            if (timer2.Enabled == true)
            {
                int CambioCarro = (carro1.Location.X == 80) ? 10 : 80;
                carro1.Location = new Point(CambioCarro, carro1.Location.Y);
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            estado = estado == true ? false : true;
            Inicio.Text = Inicio.Text.Equals("Iniciar") ? "Pausa" : "Iniciar";
            timer2.Enabled = estado;
            if (estado)
            {
                if (ListaObtaculosAmarillo.Count == 0) { CrearObstaculo(ListaObtaculosAmarillo, this, 10, 80); }
               
            }           
        }

       
    }
    }
  