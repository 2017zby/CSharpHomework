using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.Serialization;
using Orders;

namespace homework7
{
    public partial class Form1 : Form
    {
        List<Order> orderlist = new List<Order>();
        
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            orderlist.Add(new Order("20161011777", " 张步云","15827510616"));
            orderlist.Add(new Order("20171011888" , "王二五", "15827510617"));
            orderlist.Add(new Order("20181011999", "罗修远", "15827510618"));
            orderlist[0].CreateNewEntry("可乐", 1500, 3.5);
            orderlist[0].CreateNewEntry("鸡翅", 552, 4.5);
            orderlist[0].CreateNewEntry("鸡腿", 300, 6);
            orderlist[1].CreateNewEntry("凳子", 25, 32.5);
            orderlist[1].CreateNewEntry("公鸡", 20, 53);
            orderlist[2].CreateNewEntry("鸡腿", 330, 6.6);
            orderlist[2].CreateNewEntry("冰棍", 560, 3.5);
            orderlist[2].CreateNewEntry("香蕉", 10000, 1.5);
            orderBindingSource.DataSource = orderlist;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                 if(e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                DetailForm detailform = new DetailForm(orderlist[e.RowIndex], this);
                this.Hide();
                detailform.ShowDialog();
            }
            else if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForm ff = new SearchForm(orderlist, this);
            
            this.Hide();
            ff.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //AddOrder ff = new AddOrder(orderlist, this);
            //this.Hide();
            //ff.ShowDialog();
            orderBindingSource.Add(new Order("00000000000", "待定","00000000000"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;

                //orderService.Export(fileName);
                Export(fileName);
            }
           
        }
        //public void Export(string fileName)
        //{
        //    XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
        //    using (FileStream fs = new FileStream(fileName, FileMode.Create))
        //    {
        //        xs.Serialize(fs, orderlist);
        //    }
        //}
        //public string Export()
        //{
        //    DateTime time = System.DateTime.Now;
        //    string fileName = "orders_" + time.Year + "_" + time.Month
        //        + "_" + time.Day + "_" + time.Hour + "_" + time.Minute
        //        + "_" + time.Second + ".xml";
        //    Export(fileName);
        //    return fileName;
        //}

        public void Export(String fileName)
        {
   

            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            FileStream fs = new FileStream(fileName, FileMode.Create);
            xmlser.Serialize(fs, orderlist);
            XmlDocument xDoc = new XmlDocument();
            fs.Close();
            xDoc.Load(fileName);
            string file = $"{fileName}.html";
            FileStream fs1 = new FileStream(file, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fs1, Encoding.Default);
            StringWriter sw = new StringWriter();
            XslCompiledTransform xslTrans = new XslCompiledTransform();
            xslTrans.Load("..//..//..//transform.xslt");
            xslTrans.Transform(xDoc.CreateNavigator(), new XsltArgumentList(), sw);
            streamWriter.Write(sw);
            streamWriter.Flush();
            streamWriter.Close();
            fs1.Close();
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
    }
}
