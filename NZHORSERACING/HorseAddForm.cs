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
    public partial class HorseAddForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;

        public HorseAddForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOwner.SelectedItem != null)
            {
                string owner;
                owner = cboOwner.SelectedItem.ToString();
                string[] parts = owner.Split(',');
                txtOwnerID.Text = parts[0];
                txtLastName.Text = parts[1];
                txtFirstName.Text = parts[2];
            }
        }

        private void LoadOwner()
        {
            string ownerText = "";
            foreach (DataRow drOwner in DC.dtOwner.Rows)
            {
                ownerText = drOwner["OwnerID"] + ", ";
                ownerText += drOwner["LastName"] + ", ";
                ownerText += drOwner["FirstName"];
                cboOwner.Items.Add(ownerText);
            }
        }

        private void HorseAddForm_Load_1(object sender, EventArgs e)
        {
            LoadOwner();
        }

        private void btnAddHorse_Click_1(object sender, EventArgs e)
        {
            if(txtHorseName.Text == "" || cboGender.Text == "" || dtpDateOfBirth.Text == "")
            {
                MessageBox.Show("If one or more fields is blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow newHorseRow = DC.dtHorse.NewRow();
                newHorseRow["HorseName"] = txtHorseName.Text;
                newHorseRow["Gender"] = cboGender.Text;
                newHorseRow["DateOfBirth"] = dtpDateOfBirth.Text;
                newHorseRow["OwnerID"] = txtOwnerID.Text;
                DC.dsHorseRacing.Tables["Horse"].Rows.Add(newHorseRow);
                DC.UpdateHorse();
                MessageBox.Show("Horse added successfully", "Acknowledgement", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }
}
