//main form class :
//tow grid view one to display all the orders, another one to display the order details of a selected order
//a button exit to exit application
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4Assignement
{
    public partial class frmOrders : Form
    {
        const int EDIT_Btn_INDX =6  ; // index of column in the grid that contains Edit buttons

        List<Order> LstOrders=null;// list of all orders
        List<OrderDetails> lstOrderDetails=null; // list of all Order Details
        List<OrderDetails> lstOrderDetailsOfSelectedOrder = null;
        Order oldOrder=null;// to preserve data of the current order before update
        Order OrderSelected=null;//has order selected on the list


        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            ListResult lstresult = new ListResult();
            try
            {

                lstresult = OrderDB.GetOrders();
                LstOrders = lstresult.ListOrders;
                lstOrderDetails = lstresult.listOrderDetails;
                //get all the orders in lstOrders
                dataGridViewOrders.DataSource = LstOrders;
                OrderSelected = LstOrders[0];
                lstOrderDetailsOfSelectedOrder = GetOrderDetailsFromList(OrderSelected.OrderID);
                dataGridViewOrderDetails.DataSource = lstOrderDetailsOfSelectedOrder;
                //select entire row if user click on any cell
                dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading orders data: " + ex.Message,
                    ex.GetType().ToString());
            }
        }
        //return a list of order Details from the List of all order Details
        private List<OrderDetails> GetOrderDetailsFromList(int OrderId)
        {
            List<OrderDetails> resultlst = new List<OrderDetails>() ;//list order details for this OrderId
            //retreve just orderdetails object they have orderID== OrderId
            resultlst = lstOrderDetails.Where(x =>  x.OrderID == OrderId).ToList();
            return resultlst;
        }

        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if cell click then change selected order and detail for currant order
           
            int index; //the selected row index
            
            //get index of the selected row
            index = dataGridViewOrders.CurrentRow.Index;
            //get order selected from
            OrderSelected = LstOrders[index];
            //get the list of oreder details for the order selected
            lstOrderDetailsOfSelectedOrder = GetOrderDetailsFromList(OrderSelected.OrderID);
            //display the new list of order details on the order details gridview 
            dataGridViewOrderDetails.DataSource = lstOrderDetailsOfSelectedOrder;
            //test if user click on button edit
            if (e.ColumnIndex == EDIT_Btn_INDX)
            {
                oldOrder = OrderSelected.CopyOrder(); // make a  separate copy before update
                frmUpdateOrder updateForm = new frmUpdateOrder();
                //get in the order and olderorder
                updateForm.Order = OrderSelected; // "pass" current order to the form
                updateForm.OldOrder = oldOrder;        // same for the original order data
                DialogResult result = updateForm.ShowDialog(); // display modal second form
                if (result == DialogResult.OK) // update accepted
                {
                    // refresh the grid view
                    CurrencyManager cm = (CurrencyManager)dataGridViewOrders.BindingContext[LstOrders];
                    cm.Refresh();
                }
                else // update cancelled
                {
                    LstOrders[index] = oldOrder; // revert to the old values
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
