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
        private List<Delincuente> delincuentes;

        public PictureBox caja1 = new System.Windows.Forms.PictureBox();
        public PictureBox caja2 = new System.Windows.Forms.PictureBox();
        public PictureBox caja3 = new System.Windows.Forms.PictureBox();
        public PictureBox caja4 = new System.Windows.Forms.PictureBox();
        public PictureBox edificio1 = new System.Windows.Forms.PictureBox();
        public PictureBox edificio2 = new System.Windows.Forms.PictureBox();
        public Label label1 = new System.Windows.Forms.Label();
        public Label label2 = new System.Windows.Forms.Label();
        public Label label3 = new System.Windows.Forms.Label();
        public Label label4 = new System.Windows.Forms.Label();
        public TrackBar trackBar1 = new System.Windows.Forms.TrackBar();

        public void juego()
        {
            delincuentes = new List<Delincuente>();
            
            this.caja1.BackColor = System.Drawing.Color.Transparent;
            this.caja1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.caja1.Image = global::WindowsFormsApplication16.Properties.Resources.caja;
            this.caja1.Location = new System.Drawing.Point(298, 537);
            this.caja1.Name = "caja1";
            this.caja1.Size = new System.Drawing.Size(111, 116);
            this.caja1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caja1.TabIndex = 0;
            this.caja1.TabStop = false;
            // 
            // caja3
            // 
            this.caja3.BackColor = System.Drawing.Color.Transparent;
            this.caja3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.caja3.Image = global::WindowsFormsApplication16.Properties.Resources.caja;
            this.caja3.Location = new System.Drawing.Point(442, 340);
            this.caja3.Name = "caja3";
            this.caja3.Size = new System.Drawing.Size(52, 50);
            this.caja3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caja3.TabIndex = 1;
            this.caja3.TabStop = false;
            // 
            // edificio1
            // 
            this.edificio1.BackColor = System.Drawing.Color.Transparent;
            this.edificio1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.edificio1.Image = global::WindowsFormsApplication16.Properties.Resources.edificio2;
            this.edificio1.Location = new System.Drawing.Point(530, 178);
            this.edificio1.Name = "edificio1";
            this.edificio1.Size = new System.Drawing.Size(175, 194);
            this.edificio1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.edificio1.TabIndex = 2;
            this.edificio1.TabStop = false;
            // edificio2
            // 
            this.edificio2.BackColor = System.Drawing.Color.Transparent;
            this.edificio2.Image = global::WindowsFormsApplication16.Properties.Resources.edificio3;
            this.edificio2.Location = new System.Drawing.Point(41, 231);
            this.edificio2.Name = "edificio2";
            this.edificio2.Size = new System.Drawing.Size(230, 226);
            this.edificio2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.edificio2.TabIndex = 3;
            this.edificio2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(633, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Puntaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tiempo: ";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(131)))), ((int)(((byte)(155)))));
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(12, 92);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(167, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Velocidad Base";
            // 
            // caja2
            // 
            this.caja2.BackColor = System.Drawing.Color.Transparent;
            this.caja2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.caja2.Image = global::WindowsFormsApplication16.Properties.Resources.caja;
            this.caja2.Location = new System.Drawing.Point(91, 429);
            this.caja2.Name = "caja2";
            this.caja2.Size = new System.Drawing.Size(74, 70);
            this.caja2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caja2.TabIndex = 8;
            this.caja2.TabStop = false;
            // 
            // caja4
            // 
            this.caja4.BackColor = System.Drawing.Color.Transparent;
            this.caja4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.caja4.Image = global::WindowsFormsApplication16.Properties.Resources.caja;
            this.caja4.Location = new System.Drawing.Point(630, 340);
            this.caja4.Name = "caja4";
            this.caja4.Size = new System.Drawing.Size(51, 50);
            this.caja4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caja4.TabIndex = 9;
            this.caja4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vidas: ";
            // 
            this.Controls.Add(caja1);
            this.Controls.Add(caja2);
            this.Controls.Add(caja3);
            this.Controls.Add(caja4);
            this.Controls.Add(edificio1);
            this.Controls.Add(edificio2);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(trackBar1);

            this.BackgroundImage = global::WindowsFormsApplication16.Properties.Resources.fondojuego2;
            this.Size= new System.Drawing.Size(840, 648);
        }

        public void agregarDelincuentes(int x, int y, int velocidad, double factorTam)
        {

            Delincuente d = new Delincuente(velocidad);

            this.Controls.Add(d);
            d.Location = new System.Drawing.Point(x, y);
            d.Size = new System.Drawing.Size((int)(WindowsFormsApplication16.Properties.Resources.ladronajustado1.Width * factorTam), (int)(WindowsFormsApplication16.Properties.Resources.ladronajustado1.Height * factorTam));
            d.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            d.TabIndex = 0;
            d.TabStop = false;
            d.Click += new System.EventHandler(d.delincuente_Click);
            d.BackColor = System.Drawing.Color.Transparent;
            d.BringToFront();
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
                    }
                    this.Controls.Remove(delincuentes[i]);
                    delincuentes.RemoveAt(i);
                }
            }
        }

        public List<Delincuente> getDelincuentes()
        {
            return delincuentes;
        }
    }
}
