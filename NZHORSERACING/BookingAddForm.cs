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
    public partial class BookingAddForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;

        public BookingAddForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void LoadMeeting()
        {
            string meetingText = "";
            foreach (DataRow drMeeting in DC.dtMeeting.Rows)
            {
                meetingText = drMeeting["MeetingID"] + ", ";
                meetingText += drMeeting["MeetingName"];
                cboMeeting.Items.Add(meetingText);
            }
        }

        private void LoadCustomer()
        {
            string customerText = "";
            foreach (DataRow drCustomer in DC.dtCustomer.Rows)
            {
                if (drCustomer["CreditStatus"].ToString() == "Valid")
                {
                    customerText = drCustomer["CustomerID"] + ", ";
                    customerText += drCustomer["LastName"] + ", ";
                    customerText += drCustomer["FirstName"];
                    cboCustomer.Items.Add(customerText);
                }
            }
        }

        private void lblBookingID_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookingAddForm_Load(object sender, EventArgs e)
        {
            LoadMeeting();
            LoadCustomer();
            

        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text  == "" || cboStatus.Text == "" || dtpBookingDate.Text == "")
            {
                MessageBox.Show("If one or more fields is blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow newBookingRow = DC.dtBooking.NewRow();
                newBookingRow["Quantity"] = txtQuantity.Text;
                newBookingRow["Status"] = cboStatus.Text;
                newBookingRow["BookingDate"] = dtpBookingDate.Text;
                newBookingRow["CustomerID"] = txtCustomerID.Text;
                newBookingRow["MeetingID"] = txtMeetingID.Text;
                DC.dsHorseRacing.Tables["Booking"].Rows.Add(newBookingRow);
                DC.UpdateBooking();
                MessageBox.Show("Booking added successfully", "Acknowledgement", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
               
            }
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedItem != null)
            {
                string customer;
                customer = cboCustomer.SelectedItem.ToString();
                string[] parts = customer.Split(',');
                txtCustomerID.Text = parts[0];
                txtLastName.Text = parts[1];
                txtFirstName.Text = parts[2];
                
            }
        }

        private void cboMeeting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMeeting.SelectedItem != null)
            {
                string meeting;
                meeting = cboMeeting.SelectedItem.ToString();
                string[] parts = meeting.Split(',');
                txtMeetingID.Text = parts[0];
                txtMeetingName.Text = parts[1];
                
            }
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void lblCustomerID_Click(object sender, EventArgs e)
        {

        }
    }
}
