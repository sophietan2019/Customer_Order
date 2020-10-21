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
    public partial class frmOrderDetail : Form
    {  //form - level
        public List<OrderDetail> orderdetail_list;
        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            orderDetailDataGridView.DataSource = orderdetail_list;
        }
    }
}
