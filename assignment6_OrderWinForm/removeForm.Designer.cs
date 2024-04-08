namespace assignment6_OrderWinForm
{
    partial class removeForm
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
            removeLabel = new Label();
            comboBox1 = new ComboBox();
            confirmRemoveButton = new Button();
            cancelRemoveButton = new Button();
            panel1 = new Panel();
            orderServiceBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderServiceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // removeLabel
            // 
            removeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            removeLabel.AutoSize = true;
            removeLabel.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            removeLabel.Location = new Point(90, 54);
            removeLabel.Name = "removeLabel";
            removeLabel.Size = new Size(264, 32);
            removeLabel.TabIndex = 0;
            removeLabel.Text = "选择要删除订单的编号";
            // 
            // comboBox1
            // 
            comboBox1.DataSource = orderServiceBindingSource;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(143, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // confirmRemoveButton
            // 
            confirmRemoveButton.Location = new Point(101, 191);
            confirmRemoveButton.Name = "confirmRemoveButton";
            confirmRemoveButton.Size = new Size(94, 29);
            confirmRemoveButton.TabIndex = 2;
            confirmRemoveButton.Text = "确认";
            confirmRemoveButton.UseVisualStyleBackColor = true;
            confirmRemoveButton.Click += confirmRemoveButton_Click;
            // 
            // cancelRemoveButton
            // 
            cancelRemoveButton.Location = new Point(238, 191);
            cancelRemoveButton.Name = "cancelRemoveButton";
            cancelRemoveButton.Size = new Size(94, 29);
            cancelRemoveButton.TabIndex = 3;
            cancelRemoveButton.Text = "取消";
            cancelRemoveButton.UseVisualStyleBackColor = true;
            cancelRemoveButton.Click += cancelRemoveButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cancelRemoveButton);
            panel1.Controls.Add(removeLabel);
            panel1.Controls.Add(confirmRemoveButton);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 293);
            panel1.TabIndex = 4;
            // 
            // orderServiceBindingSource
            // 
            orderServiceBindingSource.DataSource = typeof(assignment5.OrderService);
            // 
            // removeForm
            // 
            AcceptButton = confirmRemoveButton;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelRemoveButton;
            ClientSize = new Size(447, 293);
            Controls.Add(panel1);
            MaximumSize = new Size(465, 340);
            MinimumSize = new Size(465, 340);
            Name = "removeForm";
            Text = "removeForm";
            Load += removeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderServiceBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label removeLabel;
        private ComboBox comboBox1;
        private Button confirmRemoveButton;
        private Button cancelRemoveButton;
        private Panel panel1;
        private BindingSource orderServiceBindingSource;
    }
}