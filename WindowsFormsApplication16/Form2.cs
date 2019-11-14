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
    public partial class Form2 : Form
    {
                public List<Player> jugadores = new List<Player>();

        private int tiempo = 0;
        private int puntaje = 0;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int t, int p)
        {
            InitializeComponent();
            tiempo = t/1000;
            puntaje = p;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Player pl = new Player(textBox1.Text, Convert.ToInt32(puntaje), Convert.ToInt32(tiempo));
            Sqlite.agregarPlayers(pl);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = jugadores;

        }
          

        public void recibirDatos(int t, int p)
        {
            textBox1.Text = "";
            tiempo = t / 1000;
            puntaje = p;
            button1.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = jugadores = Sqlite.obtenerPlayers();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.puntaje = 0;
            Form1.vidas = 3;
            Owner = new Form1();
            Owner.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {            
            Owner.Close();
            this.Close();
        }
    }
}
