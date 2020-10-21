namespace CustomerOrders
{
    partial class frmOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.EditButtons = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AllowUserToDeleteRows = false;
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.EditButtons});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(35, 23);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.ReadOnly = true;
            this.orderDataGridView.RowHeadersWidth = 51;
            this.orderDataGridView.RowTemplate.Height = 24;
            this.orderDataGridView.Size = new System.Drawing.Size(916, 347);
            this.orderDataGridView.TabIndex = 0;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellContentClick);
            this.orderDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellContentDoubleClick);
            // 
            // EditButtons
            // 
            this.EditButtons.HeaderText = "Update ShippedDate";
            this.EditButtons.MinimumWidth = 6;
            this.EditButtons.Name = "EditButtons";
            this.EditButtons.ReadOnly = true;
            this.EditButtons.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditButtons.Text = "Edit";
            this.EditButtons.UseColumnTextForButtonValue = true;
            this.EditButtons.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderDate";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RequiredDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "RequiredDate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ShippedDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "ShippedDate";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OrderTotal";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "OrderTotal";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Model.Order);
            // 
            // orderDBBindingSource
            // 
            this.orderDBBindingSource.DataSource = typeof(DAL.OrderDB);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(843, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.orderDataGridView);
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource orderDBBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn EditButtons;
        private System.Windows.Forms.Button btnExit;
    }
}