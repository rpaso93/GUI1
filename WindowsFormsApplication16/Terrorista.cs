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
    public class Terrorista : Enemigo
    {
        /*protected List<Image> img = new List<Image>();
        int velocidad;
        public bool vivo = true;*/
        protected int i = 0;
        bool subiendo = true;
        int positionInicialY;


        public Terrorista(int v):base(v)
        {
            Image = Properties.Resources.terrorista;
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
            return Velocidad;
        }

        public void setPosicionInicial(int pos)
        {
           positionInicialY = pos;
        }

        public void moverDelicuente()
        {
            int y = Location.Y;
            int max = positionInicialY - Size.Height + 8;
            int min = positionInicialY;
            
            if (y == max)
            {
                subiendo = false;
            }
            else if (y == min)
            {
                subiendo = true;
            }
            if (subiendo == true)
            {
                int futuraPosicion = Location.Y - Velocidad;
                if (max - Velocidad < futuraPosicion)
                {
                    Location = new Point(Location.X, Location.Y - Velocidad);
                }
                else
                {
                    Location = new Point(Location.X, max);
                }               
            }
            else
            {
                int futuraPosicion = Location.Y + Velocidad;
                if (min - Velocidad > futuraPosicion)
                {
                    Location = new Point(Location.X, Location.Y + Velocidad);
                }
                else
                {
                    Location = new Point(Location.X, min);
                }                   
            }           
        }
    }
}

