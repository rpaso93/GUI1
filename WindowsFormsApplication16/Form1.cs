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

    public partial class Form1 : Form
    {
        Random rmd = new Random();
        private int tiempo = 0;
        public static int vidas = 3;
        public static int puntaje = 0;
        Juego game;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Juego();
            game.juego();
            this.Controls.Add(game);
            iniciar_Timers();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (vidas == 0)
            {
                game.label2.Text = "Vidas: " + vidas;
                gameover();
            }
            else
            {
                game.label1.Text = "Puntaje: " + puntaje;
                game.label2.Text = "Vidas: " + vidas;
                game.label3.Text = "Tiempo: " + tiempo / 1000 + " Seg";
                Text = (game.getDelincuentes().Count.ToString());
                tiempo += 150;
                foreach (Delincuente d in game.getDelincuentes())
                {
                    if (tiempo % 200 == 0)
                    {
                        d.actualizarSprite();
                        superposicionDeImgs(d);
                    }else
                    {
                        d.moverDelicuente();
                        superposicionDeImgs(d);

                        //game.rabbit.Location = game.caja2.Location;
                        
                    }
                    
                }


                foreach (Terrorista d in game.getTerroristas())
                {
                    /* if (tiempo % 200 == 0)
                     {
                         d.moverDelicuente();
                         // d.actualizarSprite();
                         //superposicionDeImgs(d);
                     }
                     else
                     {
                         d.moverDelicuente();
                        // superposicionDeImgs(d);

                         //game.rabbit.Location = game.caja2.Location;

                     }*/
                    d.moverDelicuente();

                }
                //  game.rabbit.moverDelicuente();
                //game.rabbit.BringToFront();

                game.caja1.BringToFront();
                game.caja2.BringToFront();
                game.caja4.BringToFront();
               

                game.sacarDelincuentes();
                game.sacarTerrorista();
            }
            
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            int num = rmd.Next(1, 100);
            if(num <33)
            {
                
                game.agregarDelincuentes(636, 343, -2 - tiempo / 4000- game.trackBar1.Value, 0.3);

                game.agregarTerrorista(game.caja2.Location.X, game.caja2.Location.Y-10, game.trackBar1.Value+5, 0.3, game.caja2.Size);
            }
            else if(num > 33 && num < 66)
            {
                game.agregarDelincuentes(110, 420, 2 + tiempo / 4000+ game.trackBar1.Value, 0.6);

                game.agregarTerrorista(game.caja4.Location.X, game.caja4.Location.Y, game.trackBar1.Value+5, 0.6, game.caja4.Size);
            }
            else
            {
                game.agregarDelincuentes(800 , 535, -2 - tiempo / 4000- game.trackBar1.Value, 1);

                game.agregarTerrorista(game.caja1.Location.X, game.caja1.Location.Y, game.trackBar1.Value+5, 1, game.caja1.Size);

            }


        }

        private void iniciar_Timers()
        {
            timer1.Start();
            timer2.Start();            
        }

        private void gameover()
        {
            timer1.Stop();
            timer2.Stop();
            DialogResult dr = MessageBox.Show("Te quedaste sin vidas!!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            if(dr == DialogResult.OK)
            {
                if (OwnedForms.Length == 0)
                {
                    Form2 f = new Form2(tiempo, puntaje);
                    AddOwnedForm(f);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    Form2 f2 = (Form2)OwnedForms.Last();
                    f2.recibirDatos(tiempo, puntaje);
                    f2.Show();
                    this.Hide();
                }
                
            }
        }
        
        private void superposicionDeImgs(Delincuente d)
        {
            if (d.Location.X < game.edificio2.Location.X + game.edificio2.Width && d.getVelocidad() < 0)
            {
                d.SendToBack();

            }
            else
            {
                if (d.Location.X < game.caja3.Location.X + game.caja3.Width && d.Location.X + d.Width > game.caja3.Location.X && d.getVelocidad() < 0)
                {
                    d.SendToBack();

                }
                else
                {
                    d.BringToFront();
                }
            }
        }

    }
}
