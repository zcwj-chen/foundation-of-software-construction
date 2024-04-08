namespace assignment6_OrderWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            addButton = new Button();
            removeButton = new Button();
            modifyButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            searchGB = new GroupBox();
            comboBox1 = new ComboBox();
            searchButton = new Button();
            splitContainer1 = new SplitContainer();
            dataGridView2 = new DataGridView();
            orderDetailsBindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            orderId = new DataGridViewTextBoxColumn();
            cusId = new DataGridViewTextBoxColumn();
            cusName = new DataGridViewTextBoxColumn();
            orderPrice = new DataGridViewTextBoxColumn();
            orderServiceBindingSource = new BindingSource(components);
            orderDetailsBindingSource = new BindingSource(components);
            itemId = new DataGridViewTextBoxColumn();
            itemName = new DataGridViewTextBoxColumn();
            itemPrice = new DataGridViewTextBoxColumn();
            itemNum = new DataGridViewTextBoxColumn();
            itemSum = new DataGridViewTextBoxColumn();
            itemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            flowLayoutPanel1.SuspendLayout();
            searchGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(20, 20);
            addButton.Margin = new Padding(10);
            addButton.MinimumSize = new Size(95, 30);
            addButton.Name = "addButton";
            addButton.Size = new Size(95, 30);
            addButton.TabIndex = 0;
            addButton.Text = "创建订单";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(20, 70);
            removeButton.Margin = new Padding(10);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(94, 29);
            removeButton.TabIndex = 1;
            removeButton.Text = "删除订单";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(20, 119);
            modifyButton.Margin = new Padding(10);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(94, 29);
            modifyButton.TabIndex = 2;
            modifyButton.Text = "修改订单";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(addButton);
            flowLayoutPanel1.Controls.Add(removeButton);
            flowLayoutPanel1.Controls.Add(modifyButton);
            flowLayoutPanel1.Controls.Add(searchGB);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(149, 444);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // searchGB
            // 
            searchGB.Controls.Add(comboBox1);
            searchGB.Controls.Add(searchButton);
            searchGB.Location = new Point(13, 161);
            searchGB.Name = "searchGB";
            searchGB.Size = new Size(115, 142);
            searchGB.TabIndex = 4;
            searchGB.TabStop = false;
            searchGB.Text = "查询订单";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(93, 28);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "编号查询";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(8, 103);
            searchButton.Margin = new Padding(10);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 3;
            searchButton.Text = "查询";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.AutoScrollMinSize = new Size(135, 0);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(975, 444);
            splitContainer1.SplitterDistance = 149;
            splitContainer1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { itemId, itemName, itemPrice, itemNum, itemSum, itemDataGridViewTextBoxColumn, numDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dataGridView2.DataSource = orderDetailsBindingSource1;
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(0, 284);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(822, 160);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellFormatting += dataGridView2_CellFormatting;
            // 
            // orderDetailsBindingSource1
            // 
            orderDetailsBindingSource1.DataSource = typeof(assignment5.OrderDetails);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderId, cusId, cusName, orderPrice });
            dataGridView1.DataSource = orderServiceBindingSource;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(822, 444);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // orderId
            // 
            orderId.DataPropertyName = "OrderId";
            orderId.HeaderText = "订单编号";
            orderId.MinimumWidth = 6;
            orderId.Name = "orderId";
            orderId.Width = 125;
            // 
            // cusId
            // 
            cusId.DataPropertyName = "Customer.Id";
            cusId.HeaderText = "顾客编号";
            cusId.MinimumWidth = 6;
            cusId.Name = "cusId";
            cusId.Width = 125;
            // 
            // cusName
            // 
            cusName.DataPropertyName = "Customer.Name";
            cusName.HeaderText = "顾客姓名";
            cusName.MinimumWidth = 6;
            cusName.Name = "cusName";
            cusName.Width = 125;
            // 
            // orderPrice
            // 
            orderPrice.DataPropertyName = "TotalPrice";
            orderPrice.HeaderText = "订单总价";
            orderPrice.MinimumWidth = 6;
            orderPrice.Name = "orderPrice";
            orderPrice.Width = 125;
            // 
            // orderServiceBindingSource
            // 
            orderServiceBindingSource.DataSource = typeof(assignment5.OrderService);
            // 
            // orderDetailsBindingSource
            // 
            orderDetailsBindingSource.DataSource = typeof(assignment5.OrderDetails);
            // 
            // itemId
            // 
            itemId.HeaderText = "商品编号";
            itemId.MinimumWidth = 6;
            itemId.Name = "itemId";
            itemId.Width = 125;
            // 
            // itemName
            // 
            itemName.HeaderText = "商品名称";
            itemName.MinimumWidth = 6;
            itemName.Name = "itemName";
            itemName.Width = 125;
            // 
            // itemPrice
            // 
            itemPrice.HeaderText = "商品单价";
            itemPrice.MinimumWidth = 6;
            itemPrice.Name = "itemPrice";
            itemPrice.Width = 125;
            // 
            // itemNum
            // 
            itemNum.DataPropertyName = "Num";
            itemNum.HeaderText = "商品数量";
            itemNum.MinimumWidth = 6;
            itemNum.Name = "itemNum";
            itemNum.Width = 125;
            // 
            // itemSum
            // 
            itemSum.DataPropertyName = "Price";
            itemSum.HeaderText = "商品总价";
            itemSum.MinimumWidth = 6;
            itemSum.Name = "itemSum";
            itemSum.Width = 125;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            itemDataGridViewTextBoxColumn.HeaderText = "Item";
            itemDataGridViewTextBoxColumn.MinimumWidth = 6;
            itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            itemDataGridViewTextBoxColumn.Visible = false;
            itemDataGridViewTextBoxColumn.Width = 125;
            // 
            // numDataGridViewTextBoxColumn
            // 
            numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            numDataGridViewTextBoxColumn.HeaderText = "Num";
            numDataGridViewTextBoxColumn.MinimumWidth = 6;
            numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            numDataGridViewTextBoxColumn.Visible = false;
            numDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Visible = false;
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 444);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "订单管理";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            searchGB.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Button removeButton;
        private Button modifyButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private BindingSource orderServiceBindingSource;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn orderId;
        private DataGridViewTextBoxColumn cusId;
        private DataGridViewTextBoxColumn cusName;
        private DataGridViewTextBoxColumn orderPrice;
        private BindingSource orderDetailsBindingSource1;
        private BindingSource orderDetailsBindingSource;
        private GroupBox searchGB;
        private ComboBox comboBox1;
        private Button searchButton;
        private DataGridViewTextBoxColumn itemId;
        private DataGridViewTextBoxColumn itemName;
        private DataGridViewTextBoxColumn itemPrice;
        private DataGridViewTextBoxColumn itemNum;
        private DataGridViewTextBoxColumn itemSum;
        private DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}