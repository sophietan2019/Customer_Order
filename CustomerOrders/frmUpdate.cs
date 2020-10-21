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
    public partial class frmUpdate : Form
    {
        // form-level 
        public Order order; // main form sets it initially, 
                                  // then gets data from this form
        private Order oldorder; // cloned customer - before update

        public frmUpdate()
        {
            InitializeComponent();
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            // clone the customer to preserve old copy 
            oldorder = order.Clone(); //for optimistic concurrency
            // bind controls on this to order object
            orderBindingSource.Clear();
            orderBindingSource.Add(order); // bind to current order
         
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = OrderDB.UpdateOrder(oldorder, order);
                if (success)
                {
                    MessageBox.Show("Update successful", "Good news");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Another user updated or deleted this record. Try again.",
                                     "Concurrency problem");
                    this.DialogResult = DialogResult.Retry; // closes the form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message,
                    ex.GetType().ToString());
                //this.DialogResult = DialogResult.Retry;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry; // anything but OK
        }
    }
    }

