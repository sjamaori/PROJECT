using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NZHORSERACING
{
    public partial class DataController : Form
    {
        public DataTable dtBooking;
        public DataTable dtHorse;
        public DataTable dtCustomer;
        public DataTable dtMeeting;
        public DataTable dtRace;
        public DataTable dtRaceEntry;
        public DataTable dtJockey;
        public DataTable dtOwner;
        public DataView bookingView;
        public DataView horseView;
        public DataView customerView;
        public DataView meetingView;
        public DataView raceView;
        public DataView raceEntryView;
        public DataView jockeyView;
        public DataView ownerView;

        public DataController()
        {
            InitializeComponent();
            dsHorseRacing.EnforceConstraints = false;
            daBooking.Fill(dsHorseRacing);
            daHorse.Fill(dsHorseRacing);
            daCustomer.Fill(dsHorseRacing);
            daJockey.Fill(dsHorseRacing);
            daMeeting.Fill(dsHorseRacing);
            daOwner.Fill(dsHorseRacing);
            daRace.Fill(dsHorseRacing);
            daRaceEntry.Fill(dsHorseRacing);
            dtBooking = dsHorseRacing.Tables["Booking"];
            bookingView = new DataView(dtBooking);
            bookingView.Sort = "BookingID";
            dtHorse = dsHorseRacing.Tables["Horse"];
            horseView = new DataView(dtHorse);
            horseView.Sort = "HorseID";
            dtCustomer = dsHorseRacing.Tables["Customer"];
            customerView = new DataView(dtCustomer);
            customerView.Sort = "CustomerID";
            dtMeeting = dsHorseRacing.Tables["Meeting"];
            meetingView = new DataView(dtMeeting);
            meetingView.Sort = "MeetingID";
            dtRace = dsHorseRacing.Tables["Race"];
            raceView = new DataView(dtRace);
            raceView.Sort = "RaceID";
            dtRaceEntry = dsHorseRacing.Tables["Race Entry"];
            raceEntryView = new DataView(dtRaceEntry);
            raceEntryView.Sort = "RaceEntryID";
            dtJockey = dsHorseRacing.Tables["Jockey"];
            jockeyView = new DataView(dtJockey);
            jockeyView.Sort = "JockeyID";
            dtOwner = dsHorseRacing.Tables["Owner"];
            ownerView = new DataView(dtOwner);
            ownerView.Sort = "OwnerID";
            dsHorseRacing.EnforceConstraints = true;
        }

        private void DataController_Load(object sender, EventArgs e)
        {

        }

        public void UpdateBooking()
        {
            daBooking.Update(dsHorseRacing, "Booking");
        }

        private void daBooking_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnHorseRacing);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["BookingID"] = newID;
            }
        }

        public void UpdateHorse()
        {
            daHorse.Update(dsHorseRacing, "Horse");
        }

        private void daHorse_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnHorseRacing);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["HorseID"] = newID;
            }
        }

        public void UpdateRaceEntry()
        {
            daRaceEntry.Update(dsHorseRacing, "Race Entry");
        }

        private void daRaceEntry_RowUpdated_1(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnHorseRacing);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["RaceEntryID"] = newID;
            }
        }
    }
}
