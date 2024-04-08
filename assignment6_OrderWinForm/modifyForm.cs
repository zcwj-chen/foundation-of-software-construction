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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace assignment6_OrderWinForm
{
    public partial class modifyForm : Form
    {
        private Form1 f1;
        public modifyForm(Form1 f)
        {
            f1 = f;
            InitializeComponent();
            dataGridView1.DataSource = f1.os.Orders;
        }



        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var order = (Order)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            switch (colName)
            {
                case "cusName":
                    e.Value = order.Customer.Name;
                    break;
                case "cusId":
                    e.Value = order.Customer.Id;
                    break;
                default:
                    //throw new Exception("get wrong column name!");
                    break;
            }
        }

        //dataGridView1为主表，2为从表，2显示的内容根据1改变
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Order selectedOrder = (Order)selectedRow.DataBoundItem;
                f1.detailBS.DataSource = selectedOrder.Details; // 绑定到所选Order的Details属性  
                dataGridView2.DataSource = f1.detailBS; // 更新从表DataGridView的数据源  
            }
            else
            {
                dataGridView2.DataSource = null; // 如果没有选中的行，则清空明细DataGridView的数据源  
            }
        }
        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var orderdetails = (OrderDetails)dataGridView2.Rows[e.RowIndex].DataBoundItem;

            string colName = dataGridView2.Columns[e.ColumnIndex].Name;
            switch (colName)
            {
                case "itemId":
                    e.Value = orderdetails.Item.Id;
                    break;
                case "itemName":
                    e.Value = orderdetails.Item.Name;
                    break;
                case "itemPrice":
                    e.Value = orderdetails.Item.Price;
                    break;
                default:
                    //throw new Exception("get wrong column name!");
                    break;
            }
        }

        private void cancelModifyButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyForm_Load(object sender, EventArgs e)
        {
            this.f1.Form1_Load(this.f1, e);
        }
    }
}
