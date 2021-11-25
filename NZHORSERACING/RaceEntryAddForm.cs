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
    public partial class RaceEntryAddForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmRace;
        private CurrencyManager cmHorse;
        private CurrencyManager cmJockey;
        private CurrencyManager cmMeeting;

        public RaceEntryAddForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void RaceEntryAddForm_Load(object sender, EventArgs e)
        {
            LoadRace();
            cmRace = (CurrencyManager)this.BindingContext[DC.dsHorseRacing, "Race"];
            cmHorse = (CurrencyManager)this.BindingContext[DC.dsHorseRacing, "Horse"];
            cmJockey = (CurrencyManager)this.BindingContext[DC.dsHorseRacing, "Jockey"];
            cmMeeting = (CurrencyManager)this.BindingContext[DC.dsHorseRacing, "Meeting"];
            LoadRaceEntry();
            LoadHorse();
            LoadJockey();
        }

        private void LoadRaceEntry()
        {

        }

        private void LoadRace()
        {
            string raceText = "";
            foreach (DataRow drRace in DC.dtRace.Rows)
            {
                raceText = drRace["RaceID"] + ", ";
                raceText += drRace["RaceName"];
                cboRace.Items.Add(raceText);
            }
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

        private void LoadJockey()
        {
            string jockeyText = "";
            foreach (DataRow drJockey in DC.dtJockey.Rows)
            {
                jockeyText = drJockey["JockeyID"] + ", ";
                jockeyText += drJockey["FirstName"] + ", ";
                jockeyText += drJockey["LastName"];
                cboJockey.Items.Add(jockeyText);
            }
        }

        private void cboRace_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboRace.SelectedItem != null)
            {
                string race;
                lstRaceEntry.Items.Clear();
                race = cboRace.SelectedItem.ToString();
                string[] parts = race.Split(',');
                txtRaceID.Text = parts[0];
                txtRaceName.Text = parts[1];
                int raceID = Convert.ToInt32(txtRaceID.Text);
                cmRace.Position = DC.raceView.Find(raceID);
                DataRow drRace = DC.dtRace.Rows[cmRace.Position];
                int MeetingID = Convert.ToInt32(drRace["MeetingID"]);
                cmMeeting.Position = DC.meetingView.Find(MeetingID);
                DataRow drMeeting = DC.dtMeeting.Rows[cmMeeting.Position];
                txtMeetingName.Text = drMeeting["MeetingName"].ToString();
                DataRow[] drRaceEntries = drRace.GetChildRows(DC.dtRace.ChildRelations["RACE_RACEENTRY"]);
                foreach (DataRow drRaceEntry in drRaceEntries)
                {
                    string raceentryText = "";
                    int HorseID = Convert.ToInt32(drRaceEntry["HorseID"]);
                    cmHorse.Position = DC.horseView.Find(HorseID);
                    DataRow drHorse = DC.dtHorse.Rows[cmHorse.Position];
                    int JockeyID = Convert.ToInt32(drRaceEntry["JockeyID"]);
                    cmJockey.Position = DC.jockeyView.Find(JockeyID);
                    DataRow drJockey = DC.dtJockey.Rows[cmJockey.Position];
                    raceentryText += drRaceEntry["RaceEntryID"] + ", " + drHorse["HorseName"] + ", " + drJockey["LastName"] + ", " + drJockey["FirstName"];
                    lstRaceEntry.Items.Add(raceentryText);
                }
            }
        }

        private void cboJockey_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddRaceEntry_Click(object sender, EventArgs e)
        {
            if (txtRaceID.Text == "" || cboHorse.Text == "" || cboJockey.Text == "")
            {
                MessageBox.Show("If one or more fields is blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow newRaceEntryRow = DC.dtRaceEntry.NewRow();
                newRaceEntryRow["RaceID"] = txtRaceID.Text;
                string horse;
                horse = cboHorse.Text;
                string[] parts = horse.Split(',');
                int HorseID = Convert.ToInt32(parts[0]);
                newRaceEntryRow["HorseID"] = HorseID;
                string jockey;
                jockey = cboJockey.Text;
                parts = jockey.Split(',');
                int JockeyID = Convert.ToInt32(parts[0]);
                newRaceEntryRow["JockeyID"] = JockeyID;
                newRaceEntryRow["Status"] = cboStatus.Text;
                newRaceEntryRow["RaceEntryTime"] = "0:00";
                DC.dsHorseRacing.Tables["Race Entry"].Rows.Add(newRaceEntryRow);
                DC.UpdateRaceEntry();
                MessageBox.Show("RaceEntry added successfully", "Acknowledgement", MessageBoxButtons.OK,
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
