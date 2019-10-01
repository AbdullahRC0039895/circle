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

            double area = 2 * Math.PI * Radius;
            label1.Text = "Area =" + area;

            double circumference = Math.PI * (Radius * Radius);
            label2.Text = "Circumference =" + circumference;
            
        }
    }
}
