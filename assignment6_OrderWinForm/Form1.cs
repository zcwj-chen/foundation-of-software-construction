using assignment5;
using System.Security.Cryptography.X509Certificates;

namespace assignment6_OrderWinForm
{
    public partial class Form1 : Form
    {
        BindingSource orderBS = new BindingSource();
        public BindingSource detailBS = new BindingSource();
        public OrderService os = new OrderService();
        public List<string> ordersid = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }



        private void addButton_Click(object sender, EventArgs e)
        {
            new addForm(this).Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            new removeForm(this).Show();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            new modifyForm(this).Show();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            //orderBS.DataSource = 
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            OrderService os = new OrderService();
            Customer c1 = new Customer("AA", "c001");
            Customer c2 = new Customer("BB", "c002");
            Item i1 = new Item("egg", "i001", 1.50m);
            Item i2 = new Item("milk", "i002", 2.50m);
            Item i3 = new Item("bread", "i003", 2.00m);
            OrderDetails d1 = new OrderDetails(i1, 10);
            OrderDetails d2 = new OrderDetails(i2, 20);
            List<OrderDetails> l1 = new List<OrderDetails>();
            List<OrderDetails> l2 = new List<OrderDetails>();
            l2.Add(d1);
            l1.Add(d1);
            l1.Add(d2);
            Order o1 = new Order("o001", c1, l1);
            Order o2 = new Order("o002", c2, l2);
            os.addOrder(o1);
            os.addOrder(o2);

            dataGridView1.DataSource = os.Orders;
            dataGridView1.Refresh();

            ordersid = getOrderId();

            comboBox1.DataSource = ordersid;
        }

        public List<string> getOrderId()
        {
            List<string> idValues = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    idValues.Add(row.Cells["orderId"].Value.ToString());
                }
            }
            return idValues;
        }

        public void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
        public void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Order selectedOrder = (Order)selectedRow.DataBoundItem;
                detailBS.DataSource = selectedOrder.Details; // 绑定到所选Order的Details属性  
                dataGridView2.DataSource = detailBS; // 更新从表DataGridView的数据源  
            }
            else
            {
                dataGridView2.DataSource = null; // 如果没有选中的行，则清空明细DataGridView的数据源  
            }
        }
        public void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            string sid = comboBox1.SelectedValue.ToString();
            dataGridView1.DataSource = os.searchOrders(o => o.OrderId.Equals(sid));
        }
    }
}