using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n_1, n_2;
            n_1 = Double.Parse(textBox1.Text);
            n_2 = Double.Parse(textBox2.Text);
            this.textBox3.Text = Convert.ToString(n_1 * n_2);
        }
    }
}
