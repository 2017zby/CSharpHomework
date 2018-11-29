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
    public partial class SearchForm : Form
    {
        List<Order> orders;
        List<Order> Currentorders;
        Form1 f1;

        public SearchForm(List<Order> orders, Form1 f1)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.orders = orders;
            this.f1 = f1;
            bindingSource1.DataSource = orders;
            Currentorders = orders;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
        private void FindForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var target1 = orders.Where(a => a.customerName.Contains(textBox1.Text));
            bindingSource1.DataSource = target1;
            Currentorders = new List<Order>();
            foreach (var or in target1)
            {
                Currentorders.Add(or);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex ==4)
            {
                DetailForm df = new DetailForm(Currentorders[e.RowIndex], this);
                this.Hide();
                df.ShowDialog();
            }
        }

        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
    
        }
    }
}
