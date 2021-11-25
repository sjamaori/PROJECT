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
    public partial class BookingUpdateForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmBooking;

        public BookingUpdateForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void BookingUpdateForm_Load(object sender, EventArgs e)
        {
            LoadBooking();
            cmBooking = (CurrencyManager)this.BindingContext[DC.dsHorseRacing, "Booking"];
        }

        private void LoadBooking()
        {
            string bookingText = "";
            foreach (DataRow drBooking in DC.dtBooking.Rows)
            {
                bookingText = drBooking["BookingID"].ToString();
                cboBooking.Items.Add(bookingText);
            }
        }

        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            int bookingID = Convert.ToInt32(txtBookingID.Text);
            cmBooking.Position = DC.bookingView.Find(bookingID);
            DataRow updateBookingRow = DC.dtBooking.Rows[cmBooking.Position];
            {
                updateBookingRow["Quantity"] = txtQuantity.Text;
                updateBookingRow["Status"] = cboStatus.Text;
                cmBooking.EndCurrentEdit();
                DC.UpdateBooking();
                MessageBox.Show("Booking updated Successfully", "Success");
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

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }
}
