using assignment5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6_OrderWinForm
{
    public partial class addForm : Form
    {
        private Form1 f1;
        public addForm(Form1 form1)
        {
            InitializeComponent();
            f1 = form1;
        }

        private void cancelAddButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(cusNameTB.Text, cusIdTB.Text);

            List<OrderDetails> odlist = new List<OrderDetails>();

            //获取订单详情的信息
            int odNum = dataGridView1.RowCount-1;       //编辑一行数据会默认加一行，最后一行应为空
            for(int i = 0; i <= odNum; i++)
            {
                Item it = new Item(dataGridView1.Rows[i].Cells[1].Value.ToString(), 
                    dataGridView1.Rows[i].Cells[0].Value.ToString(), 
                    decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
                OrderDetails od = new OrderDetails(it, int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()));
                odlist.Add(od);
            }

            Order order = new Order(orderIdTB.Text, customer, odlist);
            f1.os.addOrder(order);
            this.Close();
        }


    }
}
