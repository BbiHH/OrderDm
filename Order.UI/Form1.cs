using Order.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //实例化 customer 对象
            Customer cs = new Customer()
            {
                Name = tbCustomerName.Text,
                Tel = tbCustomerTel.Text,
                Address = tbCustomerAddress.Text
            };

            //实例化订单对象
            Orders ord = new Orders(cs);

            //实例化订单项    所属订单、商品、单价、数量
            OrderItem orderItem1 = new OrderItem(ord, new Product() { Name = tbProductName1.Text, Price = double.Parse(tbProductPrice1.Text) }, int.Parse(tbProductCount1.Text));
            OrderItem orderItem2 = new OrderItem(ord, new Product() { Name = tbProductName2.Text, Price = double.Parse(tbProductPrice2.Text) }, int.Parse(tbProductCount2.Text));

            //计算并显示
                //订单编号
            tbOrderNumber.Text = ord.ID;
            tbOrderTime.Text = ord.Date.ToString();
                // 小计
            tbTotal1.Text = orderItem1.SubTotal().ToString();
            tbTotal2.Text = orderItem2.SubTotal().ToString();
                //总计
            tbATotal.Text = ord.Total().ToString();
        }
    }
}