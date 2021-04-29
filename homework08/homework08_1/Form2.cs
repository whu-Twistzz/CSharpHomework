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
    public partial class Form2 : Form
    {
        private Order order_copy;
        public Form2(Order o)
        {
            order_copy = o;
            o.addOrderDetails(null,0,0);
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.newOrderSource.DataSource =this.order_copy;
            this.newOrderDetailSource.DataSource = this.order_copy.orderDetails;
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
