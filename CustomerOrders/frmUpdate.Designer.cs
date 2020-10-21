namespace CustomerOrders
{
    partial class frmUpdate
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label orderTotalLabel;
            System.Windows.Forms.Label requiredDateLabel;
            System.Windows.Forms.Label shippedDateLabel;
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDateTextBox = new System.Windows.Forms.TextBox();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.orderTotalTextBox = new System.Windows.Forms.TextBox();
            this.requiredDateTextBox = new System.Windows.Forms.TextBox();
            this.shippedDateTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            customerIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            orderTotalLabel = new System.Windows.Forms.Label();
            requiredDateLabel = new System.Windows.Forms.Label();
            shippedDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(76, 76);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(89, 17);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "Customer ID:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(186, 73);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(148, 22);
            this.customerIDTextBox.TabIndex = 2;
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(76, 104);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(83, 17);
            orderDateLabel.TabIndex = 3;
            orderDateLabel.Text = "Order Date:";
            // 
            // orderDateTextBox
            // 
            this.orderDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderDate", true));
            this.orderDateTextBox.Location = new System.Drawing.Point(186, 101);
            this.orderDateTextBox.Name = "orderDateTextBox";
            this.orderDateTextBox.Size = new System.Drawing.Size(148, 22);
            this.orderDateTextBox.TabIndex = 4;
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(76, 132);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(66, 17);
            orderIDLabel.TabIndex = 5;
            orderIDLabel.Text = "Order ID:";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(186, 129);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(148, 22);
            this.orderIDTextBox.TabIndex = 6;
            // 
            // orderTotalLabel
            // 
            orderTotalLabel.AutoSize = true;
            orderTotalLabel.Location = new System.Drawing.Point(76, 160);
            orderTotalLabel.Name = "orderTotalLabel";
            orderTotalLabel.Size = new System.Drawing.Size(85, 17);
            orderTotalLabel.TabIndex = 7;
            orderTotalLabel.Text = "Order Total:";
            // 
            // orderTotalTextBox
            // 
            this.orderTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderTotal", true));
            this.orderTotalTextBox.Location = new System.Drawing.Point(186, 157);
            this.orderTotalTextBox.Name = "orderTotalTextBox";
            this.orderTotalTextBox.Size = new System.Drawing.Size(148, 22);
            this.orderTotalTextBox.TabIndex = 8;
            // 
            // requiredDateLabel
            // 
            requiredDateLabel.AutoSize = true;
            requiredDateLabel.Location = new System.Drawing.Point(76, 188);
            requiredDateLabel.Name = "requiredDateLabel";
            requiredDateLabel.Size = new System.Drawing.Size(104, 17);
            requiredDateLabel.TabIndex = 9;
            requiredDateLabel.Text = "Required Date:";
            // 
            // requiredDateTextBox
            // 
            this.requiredDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "RequiredDate", true));
            this.requiredDateTextBox.Location = new System.Drawing.Point(186, 185);
            this.requiredDateTextBox.Name = "requiredDateTextBox";
            this.requiredDateTextBox.Size = new System.Drawing.Size(148, 22);
            this.requiredDateTextBox.TabIndex = 10;
            // 
            // shippedDateLabel
            // 
            shippedDateLabel.AutoSize = true;
            shippedDateLabel.Location = new System.Drawing.Point(76, 216);
            shippedDateLabel.Name = "shippedDateLabel";
            shippedDateLabel.Size = new System.Drawing.Size(98, 17);
            shippedDateLabel.TabIndex = 11;
            shippedDateLabel.Text = "Shipped Date:";
            // 
            // shippedDateTextBox
            // 
            this.shippedDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ShippedDate", true));
            this.shippedDateTextBox.Location = new System.Drawing.Point(186, 213);
            this.shippedDateTextBox.Name = "shippedDateTextBox";
            this.shippedDateTextBox.Size = new System.Drawing.Size(148, 22);
            this.shippedDateTextBox.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(105, 282);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 37);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(259, 282);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Model.Order);
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateTextBox);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(orderTotalLabel);
            this.Controls.Add(this.orderTotalTextBox);
            this.Controls.Add(requiredDateLabel);
            this.Controls.Add(this.requiredDateTextBox);
            this.Controls.Add(shippedDateLabel);
            this.Controls.Add(this.shippedDateTextBox);
            this.Name = "frmUpdate";
            this.Text = "frmUpdate";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox orderDateTextBox;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.TextBox orderTotalTextBox;
        private System.Windows.Forms.TextBox requiredDateTextBox;
        private System.Windows.Forms.TextBox shippedDateTextBox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
    }
}