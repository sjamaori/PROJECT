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
    public partial class MainForm : Form
    {
        private DataController DC;
        private BookingAddForm frmBookingAdd;
        private BookingUpdateForm frmBookingUpdate;
        private BookingDeleteForm frmBookingDelete;
        private HorseAddForm frmHorseAdd;
        private HorseUpdateForm frmHorseUpdate;
        private HorseDeleteForm frmHorseDelete;
        private RaceEntryAddForm frmRaceEntryAdd;
        private RaceEntryDeleteForm frmRaceEntryDelete;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            if (frmBookingAdd == null)
            {
                frmBookingAdd = new BookingAddForm(DC, this);
            }
            frmBookingAdd.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DC = new DataController();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddHorse_Click(object sender, EventArgs e)
        {
            if (frmHorseAdd == null)
            {
                frmHorseAdd = new HorseAddForm(DC, this);
            }
            frmHorseAdd.ShowDialog();
        }

        private void btnAddRaceEntry_Click(object sender, EventArgs e)
        {
            if (frmRaceEntryAdd == null)
            {
                frmRaceEntryAdd = new RaceEntryAddForm(DC, this);
            }
            frmRaceEntryAdd.ShowDialog();
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (frmBookingDelete == null)
            {
                frmBookingDelete = new BookingDeleteForm(DC, this);

            }
            frmBookingDelete.ShowDialog();
        }

        private void btnDeleteHorse_Click(object sender, EventArgs e)
        {
            if (frmHorseDelete == null)
            {
                frmHorseDelete = new HorseDeleteForm(DC, this);
            }
            frmHorseDelete.ShowDialog();
        }

        private void btnDeleteRaceEntry_Click(object sender, EventArgs e)
        {
            if (frmRaceEntryDelete == null)
            {
                frmRaceEntryDelete = new RaceEntryDeleteForm(DC, this);
            }
            frmRaceEntryDelete.ShowDialog();
        }

        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            if (frmBookingUpdate == null)
            {
                frmBookingUpdate = new BookingUpdateForm(DC, this);
            }
            frmBookingUpdate.ShowDialog();
        }

        private void btnUpdateHorse_Click(object sender, EventArgs e)
        {
            if (frmHorseUpdate == null)
            {
                frmHorseUpdate = new HorseUpdateForm(DC, this);
            }
            frmHorseUpdate.ShowDialog();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
