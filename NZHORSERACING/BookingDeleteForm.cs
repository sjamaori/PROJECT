using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NZHORSERACING
{
    public partial class BookingDeleteForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmBooking;
        private CurrencyManager cmCustomer;
        public BookingDeleteForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            
        }

        private void BookingDeleteForm_Load(object sender, EventArgs e)
        {
            LoadBooking();
            cmBooking = (CurrencyManager)this.BindingContext[DC.dsHorseRacing, "Booking"];
            cmCustomer = (CurrencyManager)this.BindingContext[DC.dsHorseRacing, "Customer"];
        }

        private void LoadBooking()
        {
            string bookingText = "";
            cboBooking.Items.Clear();
            foreach (DataRow drBooking in DC.dtBooking.Rows)
            {
                bookingText = drBooking["BookingID"].ToString();
                cboBooking.Items.Add(bookingText);
            }
        }
        private void cboBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBooking.SelectedItem != null)
            {
                string booking;
                booking = cboBooking.SelectedItem.ToString();
                string[] parts = booking.Split(',');
                txtBookingID.Text = parts[0];
                int BookingID = Convert.ToInt32(txtBookingID.Text);
                cmBooking.Position = DC.bookingView.Find(BookingID);
                DataRow drBooking = DC.dtBooking.Rows[cmBooking.Position];
                string BookingDate = drBooking["BookingDate"].ToString();
                dtpBookingDate.Text = BookingDate;
                string Status = drBooking["Status"].ToString();
                txtStatus.Text = Status;
                string Quantity = drBooking["Quantity"].ToString();
                txtQuantity.Text = Quantity;
                int CustomerID = Convert.ToInt32(drBooking["CustomerID"]);
                cmCustomer.Position = DC.customerView.Find(CustomerID);
                DataRow drCustomer = DC.dtCustomer.Rows[cmCustomer.Position];
                txtCustomerID.Text = drCustomer["CustomerID"].ToString();
                txtCustomerLastName.Text = drCustomer["LastName"].ToString();
                txtCustomerFirstName.Text = drCustomer["FirstName"].ToString();

            }
        }

        private void dtpBookingDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            int bookingID = Convert.ToInt32(txtBookingID.Text);
            cmBooking.Position = DC.bookingView.Find(bookingID);
            DataRow drBooking = DC.dtBooking.Rows[cmBooking.Position];
                if (MessageBox.Show("Are you sure you want to delete this Booking?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    drBooking.Delete();
                    DC.UpdateBooking();
                    MessageBox.Show("Booking deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }
}
