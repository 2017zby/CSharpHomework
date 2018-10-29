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
    public partial class DetailForm : Form
    {
        Form f1;
        Order or;

        public DetailForm(Order or, Form1 f1)
        {
            InitializeComponent();
            orderDetailsBindingSource.DataSource = or.orderDetails;
            this.f1 = f1;
            this.or = or;
            this.StartPosition = FormStartPosition.CenterScreen;
            orderBindingSource.DataSource = or;
        }
        public DetailForm(Order or, SearchForm ff)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            orderDetailsBindingSource.DataSource = or.orderDetails;
            this.f1 = ff;
            this.or = or;
            orderBindingSource.DataSource = or;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            orderDetailsBindingSource.RemoveAt(e.RowIndex);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderDetailsBindingSource.Add(new OrderDetails("待输入", 0, 0));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetailForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            f1.Show();
        }
    }
}
