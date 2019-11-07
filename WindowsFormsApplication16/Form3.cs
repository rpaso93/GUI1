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
    public partial class Form3 : Form
    {
        public Label label1 = new System.Windows.Forms.Label();
        public Label label2 = new System.Windows.Forms.Label();
        public Label label3 = new System.Windows.Forms.Label();
        public Label label4 = new System.Windows.Forms.Label();
        public TrackBar trackBar1 = new System.Windows.Forms.TrackBar();
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Puntaje:";

            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vidas: ";
            // 

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.Transparent;
            this.label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new Size(150, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tiempo: ";

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.Transparent;
            this.label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new Point(10, 160);
            this.label4.Name = "label4";
            this.label4.Size = new Size(176, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Velocidad Base";

            // trackBar1
            // 
            this.trackBar1.BackColor = Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(131)))), ((int)(((byte)(155)))));
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new Point(10, 210);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new Size(167, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = TickStyle.Both;

            //
            //
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(trackBar1);
        }
    }
}
