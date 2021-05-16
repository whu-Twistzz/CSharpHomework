using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework06_1;
using System.Windows.Forms;

namespace homework08_1
{
    public partial class Form1 : Form
    {
        OrderService os = new OrderService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            orderSource.DataSource = os.queryAllOrders();
        }

        public void refresh()
        {
            orderSource.DataSource = os.queryAllOrders();
            orderSource.ResetBindings(false);
        }


        private void add_btn_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            var newForm = new Form2(o);
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                os.addOrder(o);
                refresh();
            }
        }

        private void change_btn_Click(object sender, EventArgs e)
        {

            Order o = orderSource.Current as Order;
            var newForm = new Form2(o);
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                os.editOrder(o);
                refresh();
            }



        }

        private void query_btn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                orderSource.DataSource = os.SearchByOrderId(Convert.ToInt32(queryBox1.Text));
            }
            else if (radioButton2.Checked)
            {
                orderSource.DataSource = os.SearchByGoods(queryBox1.Text);
            }
            else if (radioButton3.Checked)
            {
                orderSource.DataSource = os.SearchByCustomer(queryBox1.Text);
            }
            else if (radioButton4.Checked)
            {
                orderSource.DataSource = os.SearchByMoney(Convert.ToInt32(minBox.Text), Convert.ToInt32(maxBox.Text));
            }
            else
            {

            }
        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            orderSource.DataSource = os.import();
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            os.export();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Order o = orderSource.Current as Order;
            os.removeOrder(o);
            refresh();

        }

        
    }
}
