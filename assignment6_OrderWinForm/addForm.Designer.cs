namespace assignment6_OrderWinForm
{
    partial class addForm
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
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            iid = new DataGridViewTextBoxColumn();
            iName = new DataGridViewTextBoxColumn();
            iPrice = new DataGridViewTextBoxColumn();
            iNum = new DataGridViewTextBoxColumn();
            cusGB = new GroupBox();
            cusName = new Label();
            cusId = new Label();
            cusNameTB = new TextBox();
            cusIdTB = new TextBox();
            orderGB = new GroupBox();
            orderId = new Label();
            orderIdTB = new TextBox();
            cancelAddButton = new Button();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cusGB.SuspendLayout();
            orderGB.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.Controls.Add(cusGB);
            splitContainer1.Panel1.Controls.Add(orderGB);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(cancelAddButton);
            splitContainer1.Panel2.Controls.Add(saveButton);
            splitContainer1.Size = new Size(822, 528);
            splitContainer1.SplitterDistance = 391;
            splitContainer1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iid, iName, iPrice, iNum });
            dataGridView1.Location = new Point(64, 185);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(558, 122);
            dataGridView1.TabIndex = 2;
            // 
            // iid
            // 
            iid.HeaderText = "商品编号";
            iid.MinimumWidth = 6;
            iid.Name = "iid";
            iid.Width = 125;
            // 
            // iName
            // 
            iName.HeaderText = "商品名称";
            iName.MinimumWidth = 6;
            iName.Name = "iName";
            iName.Width = 125;
            // 
            // iPrice
            // 
            iPrice.HeaderText = "商品单价";
            iPrice.MinimumWidth = 6;
            iPrice.Name = "iPrice";
            iPrice.Width = 125;
            // 
            // iNum
            // 
            iNum.HeaderText = "商品数量";
            iNum.MinimumWidth = 6;
            iNum.Name = "iNum";
            iNum.Width = 125;
            // 
            // cusGB
            // 
            cusGB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cusGB.Controls.Add(cusName);
            cusGB.Controls.Add(cusId);
            cusGB.Controls.Add(cusNameTB);
            cusGB.Controls.Add(cusIdTB);
            cusGB.Location = new Point(364, 21);
            cusGB.Name = "cusGB";
            cusGB.Size = new Size(278, 125);
            cusGB.TabIndex = 1;
            cusGB.TabStop = false;
            cusGB.Text = "顾客信息";
            // 
            // cusName
            // 
            cusName.AutoSize = true;
            cusName.Location = new Point(23, 85);
            cusName.Name = "cusName";
            cusName.Size = new Size(69, 20);
            cusName.TabIndex = 3;
            cusName.Text = "顾客姓名";
            // 
            // cusId
            // 
            cusId.AutoSize = true;
            cusId.Location = new Point(23, 39);
            cusId.Name = "cusId";
            cusId.Size = new Size(69, 20);
            cusId.TabIndex = 2;
            cusId.Text = "顾客账号";
            // 
            // cusNameTB
            // 
            cusNameTB.Location = new Point(110, 85);
            cusNameTB.Name = "cusNameTB";
            cusNameTB.Size = new Size(125, 27);
            cusNameTB.TabIndex = 1;
            // 
            // cusIdTB
            // 
            cusIdTB.Location = new Point(110, 39);
            cusIdTB.Name = "cusIdTB";
            cusIdTB.Size = new Size(125, 27);
            cusIdTB.TabIndex = 0;
            // 
            // orderGB
            // 
            orderGB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            orderGB.Controls.Add(orderId);
            orderGB.Controls.Add(orderIdTB);
            orderGB.Location = new Point(41, 21);
            orderGB.Name = "orderGB";
            orderGB.Size = new Size(278, 86);
            orderGB.TabIndex = 0;
            orderGB.TabStop = false;
            orderGB.Text = "订单信息";
            // 
            // orderId
            // 
            orderId.AutoSize = true;
            orderId.Location = new Point(23, 41);
            orderId.Name = "orderId";
            orderId.Size = new Size(69, 20);
            orderId.TabIndex = 1;
            orderId.Text = "订单编号";
            // 
            // orderIdTB
            // 
            orderIdTB.Location = new Point(110, 38);
            orderIdTB.Name = "orderIdTB";
            orderIdTB.Size = new Size(125, 27);
            orderIdTB.TabIndex = 0;
            // 
            // cancelAddButton
            // 
            cancelAddButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cancelAddButton.Location = new Point(421, 40);
            cancelAddButton.Margin = new Padding(15, 3, 15, 3);
            cancelAddButton.Name = "cancelAddButton";
            cancelAddButton.Size = new Size(141, 29);
            cancelAddButton.TabIndex = 2;
            cancelAddButton.Text = "取消";
            cancelAddButton.UseVisualStyleBackColor = true;
            cancelAddButton.Click += cancelAddButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            saveButton.Location = new Point(233, 40);
            saveButton.Margin = new Padding(15, 3, 15, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(141, 29);
            saveButton.TabIndex = 1;
            saveButton.Text = "保存订单";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // addForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 528);
            Controls.Add(splitContainer1);
            Name = "addForm";
            Text = "addForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cusGB.ResumeLayout(false);
            cusGB.PerformLayout();
            orderGB.ResumeLayout(false);
            orderGB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private Button saveButton;
        private Button cancelAddButton;
        private GroupBox orderGB;
        private Label orderId;
        private TextBox orderIdTB;
        private GroupBox cusGB;
        private Label cusName;
        private Label cusId;
        private TextBox cusNameTB;
        private TextBox cusIdTB;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn iid;
        private DataGridViewTextBoxColumn iName;
        private DataGridViewTextBoxColumn iPrice;
        private DataGridViewTextBoxColumn iNum;
    }
}