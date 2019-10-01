using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn__Click(object sender, EventArgs e)
        {
            double Radius;

            try
            {
                Radius = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show(textBox1.Text + " ,Put numbers in you git");
                Radius = 0;
            }

            double Circumference = 2 * Math.PI * Radius;
            label1.Text = "Circumference =" + Circumference;

            double area = Math.PI * (Radius * Radius);
            label2.Text = "Area =" + area;
            
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
            textBox1.Location = new Point(textBox1.Location.X - 10, textBox1.Location.Y);
            btn_.Location = new Point(btn_.Location.X - 10, btn_.Location.Y);
            label3.Location = new Point(label3.Location.X - 10, label3.Location.Y);

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
            textBox1.Location = new Point(textBox1.Location.X + 10, textBox1.Location.Y);
            btn_.Location = new Point(btn_.Location.X + 10, btn_.Location.Y);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
            textBox1.Location = new Point(textBox1.Location.X, textBox1.Location.Y - 10);
            btn_.Location = new Point(btn_.Location.X, btn_.Location.Y - 10);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            textBox1.Location = new Point(textBox1.Location.X, textBox1.Location.Y + 10);
            btn_.Location = new Point(btn_.Location.X, btn_.Location.Y + 10);
        }
    }
}
