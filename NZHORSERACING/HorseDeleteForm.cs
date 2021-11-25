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
    public partial class HorseDeleteForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmOwner;
        private CurrencyManager cmHorse;

        public HorseDeleteForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            
        }

        private void LoadHorse()
        {
            string horseText = "";
            cboHorse.Items.Clear();
            foreach (DataRow drHorse in DC.dtHorse.Rows)
            {
                DataRow[] drRaceEntries = drHorse.GetChildRows(DC.dtHorse.ChildRelations["HORSE_RACEENTRY"]);
                if (drRaceEntries.Length == 0)
                {
                    horseText = drHorse["HorseID"] + ", ";
                    horseText += drHorse["HorseName"] + ", ";
                    cboHorse.Items.Add(horseText);
                }
            }
        }

        private void HorseDeleteForm_Load(object sender, EventArgs e)
        {
            LoadHorse();
            cmOwner = (CurrencyManager)this.BindingContext[DC.dsHorseRacing, "Owner"];
            cmHorse = (CurrencyManager)this.BindingContext[DC.dsHorseRacing, "Horse"];
        }

        private void btnDeleteHorse_Click(object sender, EventArgs e)
        {
            int HorseID = Convert.ToInt32(txtHorseID.Text);
            cmHorse.Position = DC.horseView.Find(HorseID);
            DataRow drHorse = DC.dtHorse.Rows[cmHorse.Position];
                if (MessageBox.Show("Are you sure you want to delete this Horse?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    drHorse.Delete();
                    DC.UpdateHorse();
                    MessageBox.Show("Horse deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void cboHorse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHorse.SelectedItem != null)
            {
                string horse;
                horse = cboHorse.SelectedItem.ToString();
                string[] parts = horse.Split(',');
                txtHorseID.Text = parts[0];
                txtHorseName.Text = parts[1];
                int HorseID = Convert.ToInt32(txtHorseID.Text);
                cmHorse.Position = DC.horseView.Find(HorseID);
                DataRow drHorse = DC.dtHorse.Rows[cmHorse.Position];
                string DateOfBirth = drHorse["DateOfBirth"].ToString();
                dtpDateOfBirth.Text = DateOfBirth;
                int OwnerID = Convert.ToInt32(drHorse["OwnerID"]);
                cmOwner.Position = DC.ownerView.Find(OwnerID);
                DataRow drOwner = DC.dtOwner.Rows[cmOwner.Position];
                txtOwnerLastName.Text = drOwner["LastName"].ToString();
                txtOwnerFirstName.Text = drOwner["FirstName"].ToString();

            }
        }
    }
}
