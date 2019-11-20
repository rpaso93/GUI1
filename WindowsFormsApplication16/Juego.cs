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
    class Juego : PictureBox
    {

        private PictureBox explosion = new PictureBox();
        private List<Delincuente> delincuentes;
        private List<Terrorista> terroristas;
        public List<SpawnPoint> spawns;

        private int positionForDelete;
        Timer timer = new Timer();
        public PictureBox caja1 = new PictureBox();
        public PictureBox caja2 = new PictureBox();
        public PictureBox caja3 = new PictureBox();
        public PictureBox caja4 = new PictureBox();
        public PictureBox edificio1 = new PictureBox();
        public PictureBox edificio2 = new PictureBox();

        Random rnd = new Random();

        public void juego()
        {
            delincuentes = new List<Delincuente>();
            terroristas = new List<Terrorista>();

            //*******************
            this.caja1.Image = Properties.Resources.caja;
            this.caja1.Location = new Point(298, 537);
            this.caja1.Size = new Size(111, 116);
            this.caja1.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // caja3
            // 
            this.caja3.Image = Properties.Resources.caja;
            this.caja3.Location = new Point(442, 340);
            this.caja3.Size = new Size(52, 50);
            this.caja3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.caja3.TabStop = false;
            // 
            // edificio1
            // 
            this.edificio1.BackColor = Color.Transparent;
            this.edificio1.BackgroundImageLayout = ImageLayout.None;
            this.edificio1.Image = Properties.Resources.edificio2;
            this.edificio1.Location = new Point(530, 178);
            this.edificio1.Name = "edificio1";
            this.edificio1.Size = new Size(175, 194);
            this.edificio1.SizeMode = PictureBoxSizeMode.AutoSize;
            this.edificio1.TabStop = false;
            // edificio2
            // 
            this.edificio2.BackColor = Color.Transparent;
            this.edificio2.Image = Properties.Resources.edificio3;
            this.edificio2.Location = new Point(41, 231);
            this.edificio2.Name = "edificio2";
            this.edificio2.Size = new Size(230, 226);
            this.edificio2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.edificio2.TabStop = false;
            // 
            // caja2
            // 
            this.caja2.Image = Properties.Resources.caja;
            this.caja2.Location = new Point(91, 429);
            this.caja2.Size = new Size(74, 70);
            this.caja2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.caja2.TabStop = false;
            // 
            // caja4
            // 
            this.caja4.Image = Properties.Resources.caja;
            this.caja4.Location = new Point(630, 340);
            this.caja4.Size = new Size(51, 50);
            this.caja4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.caja4.TabStop = false;
            // 
            this.Controls.Add(caja1);
            this.Controls.Add(caja2);
            this.Controls.Add(caja3);
            this.Controls.Add(caja4);
            this.Controls.Add(edificio1);
            this.Controls.Add(edificio2);

            #region Spawns
            spawns = new List<SpawnPoint>();
            SpawnPoint s = new SpawnPoint(caja1.Location, caja1.Size);
            spawns.Add(s);
            s = new SpawnPoint(new Point(110, 420), new Size((int)(Properties.Resources.ladronajustado1.Width * 0.6), (int)(WindowsFormsApplication16.Properties.Resources.ladronajustado1.Height * 0.6)));
            spawns.Add(s);
            s = new SpawnPoint(caja2.Location, caja2.Size);
            spawns.Add(s);
            s = new SpawnPoint(new Point(636, 343), new Size((int)(Properties.Resources.ladronajustado1.Width * 0.3), (int)(WindowsFormsApplication16.Properties.Resources.ladronajustado1.Height * 0.3)));
            spawns.Add(s);
            s = new SpawnPoint(caja3.Location, caja3.Size);
            spawns.Add(s);
            s = new SpawnPoint(new Point(800, 535), new Size((int)(Properties.Resources.ladronajustado1.Width * 1), (int)(WindowsFormsApplication16.Properties.Resources.ladronajustado1.Height * 1)));
            spawns.Add(s);
            s = new SpawnPoint(caja4.Location, caja4.Size);
            spawns.Add(s);
            #endregion

            this.Size = new Size(840, 648);
            this.BackgroundImage = Properties.Resources.fondojuego2;
        }

        public void agregarDelincuentes(Point pos, int velocidad, Size tam, int i)
        {

            Delincuente d = new Delincuente(velocidad);

            this.Controls.Add(d);
            d.Location = pos;
            d.Size = tam;
            d.SizeMode = PictureBoxSizeMode.StretchImage;
            d.TabIndex = 0;
            d.TabStop = false;
            d.Click += new System.EventHandler(d.delincuente_Click);
            d.BackColor = Color.Transparent;
            d.Index = i;
            d.BringToFront();
            d.Click += new EventHandler(this.clicker);
            delincuentes.Add(d);

        }

        public void sacarDelincuentes()
        {
            for (int i = delincuentes.Count - 1; i >= 0; i--)
            {
                if (delincuentes[i].vivo == false || delincuentes[i].Location.X < -delincuentes[i].Width || delincuentes[i].Location.X > this.Width)
                {
                    if (delincuentes[i].vivo == true)
                    {
                        Form1.vidas -= 1;
                        SacarSpawn(delincuentes[i]);
                    }
                    // delincuentes[i].muerto();
                    agregarExplosion(delincuentes[i]);
                    this.Controls.Remove(delincuentes[i]);
                    delincuentes.RemoveAt(i);
                }
            }
        }

        public List<Delincuente> getDelincuentes()
        {
            return delincuentes;
        }



        public void agregarTerrorista(Point pos, int velocidad, double factorTam, Size size, int i)
        {

            Terrorista d = new Terrorista(velocidad);

            this.Controls.Add(d);
            d.Location = pos;
            d.Size = size;
            d.SizeMode = PictureBoxSizeMode.StretchImage;
            d.TabIndex = 0;
            d.TabStop = false;
            d.Click += new System.EventHandler(d.delincuente_Click);
            d.BackColor = Color.Transparent;
            d.BringToFront();
            d.setPosicionInicial(pos.Y);
            d.Index = i;
            d.Click += new EventHandler(this.clicker);
            terroristas.Add(d);

        }

        public void clicker(object d, EventArgs e)
        {
            SacarSpawn(d);
        }

        public void SacarSpawn(object d)
        {
            spawns[((Enemigo)d).Index].Ocupado = false;
        }

        public void agregarExplosion(Delincuente d)
        {

            explosion.Image = Properties.Resources.bum2;
            explosion.Location = new Point(d.Location.X, d.Location.Y);
            explosion.Size = new Size(d.Width, d.Height);
            explosion.SizeMode = PictureBoxSizeMode.StretchImage;
            explosion.BackColor = Color.Transparent;
            explosion.BringToFront();
            this.Controls.Add(explosion);

            this.timer.Interval = 500;

            this.timer.Start();
            this.timer.Tick += new System.EventHandler(timer_explosion);

        }

        public void agregarExplosion(Terrorista d)
        {

            explosion.Image = Properties.Resources.bum2;
            explosion.Location = new Point(d.Location.X, d.Location.Y);
            explosion.Size = new Size(d.Width, d.Height);
            explosion.SizeMode = PictureBoxSizeMode.StretchImage;
            explosion.BackColor = Color.Transparent;
            explosion.BringToFront();
            this.Controls.Add(explosion);

            this.timer.Interval = 500;

            this.timer.Start();
            this.timer.Tick += new System.EventHandler(timer_explosion);

        }

        public void sacarTerrorista()
        {
            for (int i = terroristas.Count - 1; i >= 0; i--)
            {
                if (terroristas[i].vivo == false || terroristas[i].Location.X < -terroristas[i].Width || terroristas[i].Location.X > this.Width)
                {
                    if (terroristas[i].vivo == true)
                    {
                        Form1.vidas -= 1;
                    }

                    // terroristas[i].muerto();
                    agregarExplosion(terroristas[i]);

                    this.Controls.Remove(this.terroristas[this.positionForDelete]);
                    this.terroristas.RemoveAt(this.positionForDelete);

                    //  this.Controls.Remove(terroristas[i]);
                    //this.terroristas.RemoveAt(i);

                }
            }
        }

        public List<Terrorista> getTerroristas()
        {
            return terroristas;
        }

        public bool SpawnsLlenos()
        {
            foreach (SpawnPoint sp in spawns)
            {
                if (sp.Ocupado == false)
                    return false;
            }
            return true;

        }

        private void timer_explosion(object sender, EventArgs e)
        {

            this.timer.Stop();
            this.explosion.Image = null;
            this.Controls.Remove(this.explosion);

        }

    }
}
