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
    public partial class HorseUpdateForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmHorse;

        public HorseUpdateForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void HorseUpdateForm_Load(object sender, EventArgs e)
        {
            LoadHorse();
            cmHorse = (CurrencyManager)this.BindingContext[DC.dsHorseRacing, "Horse"];
        }

        private void LoadHorse()
        {
            string horseText = "";
            foreach (DataRow drHorse in DC.dtHorse.Rows)
            {
                horseText = drHorse["HorseID"] + ", ";
                horseText += drHorse["HorseName"];
                cboHorse.Items.Add(horseText);
            }
        }

        private void cboHorse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateHorse_Click(object sender, EventArgs e)
        {
            int horseID = Convert.ToInt32(txtHorseID.Text);
            cmHorse.Position = DC.horseView.Find(horseID);
            DataRow updateHorseRow = DC.dtHorse.Rows[cmHorse.Position];
            {
                updateHorseRow["HorseName"] = txtHorseName.Text;
                updateHorseRow["Gender"] = cboGender.Text;
                updateHorseRow["DateOfBirth"] = dtpDateOfBirth.Text;
                cmHorse.EndCurrentEdit();
                DC.UpdateHorse();
                MessageBox.Show("Horse updated Successfully", "Success");
            }
        }

        private void cboHorse_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboHorse.SelectedItem != null)
            {
                string horse;
                horse = cboHorse.SelectedItem.ToString();
                string[] parts = horse.Split(',');
                txtHorseID.Text = parts[0];
                txtHorseName.Text = parts[1];

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }
}
