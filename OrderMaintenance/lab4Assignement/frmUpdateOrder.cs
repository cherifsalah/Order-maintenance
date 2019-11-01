//definition of class frmUpdateOrders : the form contain three textbox to display the currant
//values of properties(orderdate,requireddate,shippeddate) we want to update for the selected order
//and three datepicker used to get the new values set by user
//an accept button for firing update, cancel to retry
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
    public partial class frmUpdateOrder : Form
    {

        public Order Order; // current order
        public Order OldOrder; // original Order data
        public frmUpdateOrder()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
            bool success;//public static bool UpdateOrder(Order OldOrder,Order NewOrder)
            DateTime NewOrderDate; //new OrderDate
            DateTime NewRequiredDate;//new RequiredDate
            DateTime NewShippedDate;//New ShippedDate

            //get all the new date from user
            NewOrderDate = dtPickerOrderDate.Value.Date;
            NewRequiredDate = dtPickerRequiredTime.Value.Date;
            NewShippedDate = dtPickerShippedDate.Value.Date;
            //test if they are valid dates
            if (NewOrderDate <= NewRequiredDate && NewShippedDate <= NewRequiredDate && 
                NewOrderDate <= NewShippedDate && NewOrderDate<=DateTime.Today.Date )
            {
                //assign this values to my order
                Order.OrderDate = NewOrderDate;
                Order.RequiredDate = NewRequiredDate;
                Order.ShippedDate = NewShippedDate;
                //apply upddate in the db
                success = OrderDB.UpdateOrder(OldOrder, Order);
                if (success)
                {
                    this.DialogResult = DialogResult.OK;
                    
                }
                else
                {
                    this.DialogResult = DialogResult.Retry;
                }
            }
            else
            {
                //display a warning message to the user with a rule on how to update the order dates
                MessageBox.Show( "Check the values of the given Dates, use this rule:\n " +
                    "OrderDate<=ShippedDate<=Requireddate and OrderDate<=Today's Date", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // set dialog result to Retry
            this.DialogResult = DialogResult.Retry;
        }

        private void frmUpdateOrder_Load(object sender, EventArgs e)
        {

            //Display the values of currant order dates(OrderDate,RequiredDate,ShippedDate) 
            //we want to update with new values in this form
            //the old values will be display under currant value group
            //user can enter  new value will in the new value group 
            //because all the property date value can be null we test every time we want to display 
            
            if (Order.OrderDate.HasValue) { txtOrderDate.Text =  Order.OrderDate.Value.ToString("MMMM/dd/yyyy"); }
            if (Order.RequiredDate.HasValue) { txtRequiredDate.Text = Order.RequiredDate.Value.ToString("MMMM/dd/yyyy"); }
            if (Order.ShippedDate.HasValue) { txtshippingDate.Text = Order.ShippedDate.Value.ToString("MMMM/dd/yyyy"); }
            
        }
    }
}
