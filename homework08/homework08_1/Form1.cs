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
        int selectRowIndex = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Order o = new Order(1,"dashabi");
            o.addOrderDetails("sss", 2, 50);
            o.addOrderDetails("dashag", 3, 40);
            Order o2 = new Order(2, "dashabi");
            os.orders.Add(o); 
            os.orders.Add(o2);
            orderSource.DataSource = os.orders;
    
        }

        public void refresh()
        {
            orderSource.ResetBindings(false);
        }
        private void orderView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)      
            {
                Order o=(Order)orderSource.Current;
                orderDetailSource.DataSource = o.orderDetails;
                this.selectRowIndex = e.RowIndex;
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            var newForm = new Form2(o);
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                os.orders.Add(o);
                refresh();
            }
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            if (this.selectRowIndex > -1)
            {
                List<Order> list = (List<Order>)orderSource.DataSource;
                Order o = list[this.selectRowIndex];
                var newForm = new Form2(o);
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    os.orders[this.selectRowIndex] = o;
                    refresh();
                }
            }
            else
            {
                MessageBox.Show("请选择订单后再进行操作");
            }

        }

        private void query_btn_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                orderSource.DataSource = os.SearchById(Convert.ToInt32(queryBox1.Text));
            }
            else if(radioButton2.Checked)
            {
                orderSource.DataSource = os.SearchByGoods(queryBox1.Text);
            }
            else if(radioButton3.Checked)
            {
                orderSource.DataSource = os.SearchByCustomer(queryBox1.Text);
            }
            else if(radioButton4.Checked)
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
            orderSource.DataSource = os.orders;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
             if(this.selectRowIndex>-1)
            {
                DialogResult dr = MessageBox.Show("确定删除当前订单？", "提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    DataGridViewRow r = orderView.CurrentRow;
                    orderView.Rows.Remove(r);
                }
            }
            else
            {
                MessageBox.Show("请选择订单后再进行操作");
            }
        }
    }
}
