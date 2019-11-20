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
    public class Delincuente : Enemigo
    {
        //protected List<Image> img = new List<Image>();
        protected int i = 0;

        public Delincuente(int v) : base(v)
        {
            Image ladron0 = Properties.Resources.ladronajustado2;
            Image ladron1 = Properties.Resources.ladronajustado1;
            Image ladron2 = Properties.Resources.ladronajustado3;
            Image ladron3 = Properties.Resources.ladronajustado4;


            if (v < 0)
            {

                ladron0.RotateFlip(RotateFlipType.RotateNoneFlipX);
                ladron1.RotateFlip(RotateFlipType.RotateNoneFlipX);
                ladron2.RotateFlip(RotateFlipType.RotateNoneFlipX);
                ladron3.RotateFlip(RotateFlipType.RotateNoneFlipX);
                //WindowsFormsApplication16.Properties.Resources.ladron0.Clone()
                //sendToBack
            }

            img.Add(ladron0);
            img.Add(ladron1);
            img.Add(ladron2);
            img.Add(ladron3);

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
        public void actualizarSprite()
        {
            i++;
            if (i == 4)
                i = 0;
            Location = new Point(Location.X + Velocidad, Location.Y);
            Image = img.ElementAt(i);
        }
        public void moverDelicuente()
        {
            Location = new Point(Location.X + Velocidad, Location.Y);
        }
    }
}
