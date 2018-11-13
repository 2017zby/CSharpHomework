using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Orders;
namespace homework7
{
    public partial class AddOrder : Form
    {
        Order order;
        Form f1;
        public AddOrder(Form f1)
        {
            InitializeComponent();
            order.customerName = textBox1.Text;
            order.orderNumber =textBox2.Text;
            order.numOfDetails =Convert.ToInt32( textBox3.Text);
            order.orderTotalPrice =Convert.ToInt32( textBox4.Text);
            this.f1 = f1;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
