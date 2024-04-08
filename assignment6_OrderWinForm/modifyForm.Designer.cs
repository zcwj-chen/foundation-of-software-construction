namespace assignment6_OrderWinForm
{
    partial class modifyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            orderId = new DataGridViewTextBoxColumn();
            cusId = new DataGridViewTextBoxColumn();
            cusName = new DataGridViewTextBoxColumn();
            orderPrice = new DataGridViewTextBoxColumn();
            orderServiceBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            orderDetailsBindingSource = new BindingSource(components);
            saveModifyButton = new Button();
            cancelModifyButton = new Button();
            itemId = new DataGridViewTextBoxColumn();
            itemName = new DataGridViewTextBoxColumn();
            itemPrice = new DataGridViewTextBoxColumn();
            itemNum = new DataGridViewTextBoxColumn();
            itemSum = new DataGridViewTextBoxColumn();
            itemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource).BeginInit();
            SuspendLayout();
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
            dataGridView1.Size = new Size(800, 215);
            dataGridView1.TabIndex = 7;
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
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { itemId, itemName, itemPrice, itemNum, itemSum, itemDataGridViewTextBoxColumn, numDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dataGridView2.DataSource = orderDetailsBindingSource;
            dataGridView2.Dock = DockStyle.Top;
            dataGridView2.Location = new Point(0, 215);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(800, 162);
            dataGridView2.TabIndex = 8;
            // 
            // orderDetailsBindingSource
            // 
            orderDetailsBindingSource.DataSource = typeof(assignment5.OrderDetails);
            // 
            // saveModifyButton
            // 
            saveModifyButton.Location = new Point(222, 396);
            saveModifyButton.Name = "saveModifyButton";
            saveModifyButton.Size = new Size(94, 29);
            saveModifyButton.TabIndex = 9;
            saveModifyButton.Text = "保存修改";
            saveModifyButton.UseVisualStyleBackColor = true;
            // 
            // cancelModifyButton
            // 
            cancelModifyButton.Location = new Point(403, 396);
            cancelModifyButton.Name = "cancelModifyButton";
            cancelModifyButton.Size = new Size(94, 29);
            cancelModifyButton.TabIndex = 10;
            cancelModifyButton.Text = "取消";
            cancelModifyButton.UseVisualStyleBackColor = true;
            cancelModifyButton.Click += cancelModifyButton_Click;
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
            // modifyForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelModifyButton);
            Controls.Add(saveModifyButton);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "modifyForm";
            Text = "modifyForm";
            Load += modifyForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn orderId;
        private DataGridViewTextBoxColumn cusId;
        private DataGridViewTextBoxColumn cusName;
        private DataGridViewTextBoxColumn orderPrice;
        private DataGridView dataGridView2;
        private Button saveModifyButton;
        private Button cancelModifyButton;
        private BindingSource orderServiceBindingSource;
        private BindingSource orderDetailsBindingSource;
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