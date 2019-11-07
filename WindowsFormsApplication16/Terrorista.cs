using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public class Terrorista : PictureBox
    {
        protected List<Image> img = new List<Image>();
        int velocidad;
        public bool vivo = true;
        protected int i = 0;
        bool bajando = false;
        bool subir = true;
        int positionInicialY;


        public Terrorista(int velocidad)
        {

            this.velocidad = velocidad;
           // this.positionInicialY = positionInicialY;

            Image = Properties.Resources.terrorista;
          //  Image  = Properties.Resources.ladronajustado1;
            //Image ladron2 = WindowsFormsApplication16.Properties.Resources.ladronajustado3;
           // Image ladron3 = WindowsFormsApplication16.Properties.Resources.ladronajustado4;


            if (velocidad < 0)
            {

               // ladron0.RotateFlip(RotateFlipType.RotateNoneFlipX);
                /*ladron1.RotateFlip(RotateFlipType.RotateNoneFlipX);
                ladron2.RotateFlip(RotateFlipType.RotateNoneFlipX);
                ladron3.RotateFlip(RotateFlipType.RotateNoneFlipX);*/
                //WindowsFormsApplication16.Properties.Resources.ladron0.Clone()
                //sendToBack
            }

          //  img.Add(ladron0);
           /* img.Add(ladron1);
            img.Add(ladron2);
            img.Add(ladron3);*/

        }
        public void muerto()
        {
            Image = null;
        }
        public void delincuente_Click(object sender, EventArgs e)
        {
            Form1.puntaje += 1;
            Image = null;
            vivo = false;
        }
        public int getVelocidad()
        {
            return velocidad;
        }

        public void setPosicionInicial(int pos)
        {
           positionInicialY = pos;
        }
        /*  public void actualizarSprite()
          {
              i++;
              if (i == 4)
                  i = 0;
              Location = new Point(Location.X + velocidad, Location.Y);
              Image = img.ElementAt(i);

              //this.BackColor= System.Drawing.Color.Transparent;
          }*/
        public void moverDelicuente()
        {
            int y = Location.Y;//- velocidad;
            ///int dif = positionInicialY - y;
            ///
            //int prom = Size.Height * 0.90
            int max = positionInicialY - Size.Height ;
            int min = positionInicialY;
            
            if (y == max)
            {
                bajando = true;
                subir = false;
            }else if (y == min)
            {
                bajando = false;
                subir = true;
            }
            if (subir)
            {
                int futuraPosicion = Location.Y - velocidad;
                //Location = new Point(Location.X, Location.Y - velocidad);
                if (max - velocidad < futuraPosicion)
                {
                    Location = new Point(Location.X, Location.Y - velocidad);
                }
                else
                {
                    Location = new Point(Location.X, max);
                }
               
               
            }
            else if (bajando)
            {
                int futuraPosicion = Location.Y + velocidad;
                if (min - velocidad > futuraPosicion)
                {
                    Location = new Point(Location.X, Location.Y + velocidad);
                }
                else
                {
                    Location = new Point(Location.X, min);

                }
                   
            }
           
        }
    }
}

