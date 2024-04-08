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
    public partial class removeForm : Form
    {
        private Form1 form1;
        public removeForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void removeForm_Load(object sender, EventArgs e)
        {
            //加载下拉列表的数据项-订单编号
            List<string> orderIdList = new List<string>();
            orderIdList = this.form1.ordersid;
            comboBox1.DataSource = orderIdList;
        }

        private void cancelRemoveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmRemoveButton_Click(object sender, EventArgs e)
        {
            //删除订单
            this.form1.os.removeOrder(comboBox1.SelectedValue.ToString());
            this.form1.Refresh();
            this.Close();
                        
        }
    }
}
