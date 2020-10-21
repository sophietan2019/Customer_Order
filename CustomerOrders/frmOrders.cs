using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DAL;

namespace CustomerOrders
{
    public partial class frmOrders : Form
    {
        List<Order> orders;   // all orders
        List<OrderDetail> selectedorder; //selected order details
        const int EDIT_BUTTON_INDX = 6;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            //load orders data
            try
            {
                orders = OrderDB.GetAllOrders();
                orderDataGridView.DataSource = orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading orders data: " +
                    ex.Message, ex.GetType().ToString());
            }
        }

        private void orderDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int orderid = orders[rowindex].OrderID;
            selectedorder = OrderDetailDB.GetSelectedOrderDetail(orderid);
            frmOrderDetail orderDetailForm = new frmOrderDetail();
            orderDetailForm.orderdetail_list = selectedorder;
            DialogResult result = orderDetailForm.ShowDialog();
        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EDIT_BUTTON_INDX)// user clicked in the buttons collumn
            {
                frmUpdate updateForm = new frmUpdate();
                updateForm.order = orders[e.RowIndex];// pass current customer to the update form
                DialogResult result = updateForm.ShowDialog(); // display modal
                if (result == DialogResult.OK) // update accepted
                {
                    // refresh the grid contents
                    CurrencyManager cm = (CurrencyManager)orderDataGridView.BindingContext[orders];
                    cm.Refresh();
                }
                else  // update cancelled or failed
                {
                    orders = OrderDB.GetAllOrders();
                    orderDataGridView.DataSource = orders;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}