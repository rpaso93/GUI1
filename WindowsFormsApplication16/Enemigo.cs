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
    public class Enemigo : PictureBox
    {
        int velocidad;
        public bool vivo = true;
        int index;
        protected List<Image> img = new List<Image>();

        public int Velocidad
        {
            get
            {
                return velocidad;
            }

            set
            {
                velocidad = value;
            }
        }

        public int Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }

        public Enemigo(int v)
        {
            this.DoubleBuffered = true;
            this.Velocidad = v;
        }
    }
}
