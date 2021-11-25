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
    public partial class RaceEntryDeleteForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmRace;
        private CurrencyManager cmJockey;
        private CurrencyManager cmHorse;
        private CurrencyManager cmRaceEntry;

        public RaceEntryDeleteForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void RaceEntryDeleteForm_Load(object sender, EventArgs e)
        {
            LoadRace();
            cmRace = (CurrencyManager)this.BindingContext[DC.dsHorseRacing, "Race"];
            cmJockey = (CurrencyManager)this.BindingContext[DC.dsHorseRacing, "Jockey"];
            cmHorse = (CurrencyManager)this.BindingContext[DC.dsHorseRacing, "Horse"];
            cmRaceEntry = (CurrencyManager)this.BindingContext[DC.dsHorseRacing, "Race Entry"];
            LoadHorse();
        }

        private void cboRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRace.SelectedItem != null)
            {
                string race;
                duRaceEntry.Items.Clear();
                race = cboRace.SelectedItem.ToString();
                string[] parts = race.Split(',');
                txtRaceID.Text = parts[0];
                txtRaceName.Text = parts[1];
                int raceID = Convert.ToInt32(txtRaceID.Text);
                cmRace.Position = DC.raceView.Find(raceID);
                DataRow drRace = DC.dtRace.Rows[cmRace.Position];
                string Status = drRace["Status"].ToString();
                txtStatus.Text = Status;
                DataRow[] drRaceEntries = drRace.GetChildRows(DC.dtRace.ChildRelations["RACE_RACEENTRY"]);
                foreach (DataRow drRaceEntry in drRaceEntries)
                {
                    string raceentryText = "";
                    raceentryText += drRaceEntry["RaceEntryID"] + ", ";
                    int HorseID = Convert.ToInt32(drRaceEntry["HorseID"]);
                    cmHorse.Position = DC.horseView.Find(HorseID);
                    DataRow drHorse = DC.dtHorse.Rows[cmHorse.Position];
                    raceentryText += drHorse["HorseName"] + ", ";
                    int JockeyID = Convert.ToInt32(drRaceEntry["JockeyID"]);
                    cmJockey.Position = DC.jockeyView.Find(JockeyID);
                    DataRow drJockey = DC.dtJockey.Rows[cmJockey.Position];
                    raceentryText += drJockey["LastName"] + ", " + drJockey["FirstName"];
                    duRaceEntry.Items.Add(raceentryText);
                }
            }
        }

        private void LoadRace()
        {
            string raceText = "";
            cboRace.Items.Clear();
            foreach (DataRow drRace in DC.dtRace.Rows)
            {
                DataRow[] drRaceEntries = drRace.GetChildRows(DC.dtRace.ChildRelations["RACE_RACEENTRY"]);
                if (drRaceEntries.Length != 0)
                {
                    raceText = drRace["RaceID"] + ", ";
                    raceText += drRace["RaceName"];
                    cboRace.Items.Add(raceText);
                }
            }
        }

        private void LoadHorse()
        {

        }

        private void btnDeleteRaceEntry_Click(object sender, EventArgs e)
        {
            int raceentryID = Convert.ToInt32(txtRaceEntryID.Text);
            cmRaceEntry.Position = DC.raceEntryView.Find(raceentryID);
            DataRow drRaceEntry = DC.dtRaceEntry.Rows[cmRaceEntry.Position];
                if (MessageBox.Show("Are you sure you want to delete this RaceEntry?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    drRaceEntry.Delete();
                    DC.UpdateRaceEntry();
                    MessageBox.Show("RaceEntry deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                }

        }


        private void duRaceEntry_SelectedItemChanged(object sender, EventArgs e)
        {
            if (duRaceEntry.SelectedItem != null)

            {
                string raceentry;
                raceentry = duRaceEntry.SelectedItem.ToString();
                string[] parts = raceentry.Split(',');
                txtRaceEntryID.Text = parts[0];
                txtJockeyLastName.Text = parts[2];
                txtHorseName.Text = parts[1];
                txtJockeyFirstName.Text = parts[3];
                int raceentryID = Convert.ToInt32(txtRaceEntryID.Text);
                cmRaceEntry.Position = DC.raceEntryView.Find(raceentryID);              
                DataRow drRaceEntry = DC.dtRaceEntry.Rows[cmRaceEntry.Position];
                string Status = drRaceEntry["Status"].ToString();
                txtStatus2.Text = Status;
                string RaceEntryTime = drRaceEntry["RaceEntryTime"].ToString();
                txtRaceEntryTime.Text = RaceEntryTime;


            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }

}

