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
    public class SpawnPoint
    {
        Point pos;
        Size tam;
        bool ocupado = false;

        public Point Pos
        {
            get
            {
                return pos;
            }

            set
            {
                pos = value;
            }
        }

        public bool Ocupado
        {
            get
            {
                return ocupado;
            }

            set
            {
                ocupado = value;
            }
        }

        public Size Tam
        {
            get
            {
                return tam;
            }

            set
            {
                tam = value;
            }
        }

        public SpawnPoint(Point p, Size t)
        {
            this.Pos = p;
            this.Tam = t;
        }
    }
}
