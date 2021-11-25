
namespace NZHORSERACING
{
    partial class RaceEntryAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRaceName = new System.Windows.Forms.TextBox();
            this.txtRaceID = new System.Windows.Forms.TextBox();
            this.cboRace = new System.Windows.Forms.ComboBox();
            this.lblRaceName = new System.Windows.Forms.Label();
            this.lblRaceID = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblMeetingName = new System.Windows.Forms.Label();
            this.txtMeetingName = new System.Windows.Forms.TextBox();
            this.lblRaceEntry = new System.Windows.Forms.Label();
            this.lstRaceEntry = new System.Windows.Forms.ListBox();
            this.cboHorse = new System.Windows.Forms.ComboBox();
            this.lblHorse = new System.Windows.Forms.Label();
            this.lblJockey = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAddRaceEntry = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboJockey = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtRaceName
            // 
            this.txtRaceName.Location = new System.Drawing.Point(238, 127);
            this.txtRaceName.Name = "txtRaceName";
            this.txtRaceName.Size = new System.Drawing.Size(217, 27);
            this.txtRaceName.TabIndex = 40;
            // 
            // txtRaceID
            // 
            this.txtRaceID.Location = new System.Drawing.Point(238, 81);
            this.txtRaceID.Name = "txtRaceID";
            this.txtRaceID.Size = new System.Drawing.Size(55, 27);
            this.txtRaceID.TabIndex = 39;
            // 
            // cboRace
            // 
            this.cboRace.FormattingEnabled = true;
            this.cboRace.Location = new System.Drawing.Point(238, 33);
            this.cboRace.MaxLength = 7;
            this.cboRace.Name = "cboRace";
            this.cboRace.Size = new System.Drawing.Size(217, 27);
            this.cboRace.TabIndex = 38;
            this.cboRace.SelectedIndexChanged += new System.EventHandler(this.cboRace_SelectedIndexChanged_1);
            // 
            // lblRaceName
            // 
            this.lblRaceName.AutoSize = true;
            this.lblRaceName.Location = new System.Drawing.Point(35, 129);
            this.lblRaceName.Name = "lblRaceName";
            this.lblRaceName.Size = new System.Drawing.Size(87, 19);
            this.lblRaceName.TabIndex = 37;
            this.lblRaceName.Text = "Race Name:";
            // 
            // lblRaceID
            // 
            this.lblRaceID.AutoSize = true;
            this.lblRaceID.Location = new System.Drawing.Point(59, 89);
            this.lblRaceID.Name = "lblRaceID";
            this.lblRaceID.Size = new System.Drawing.Size(63, 19);
            this.lblRaceID.TabIndex = 36;
            this.lblRaceID.Text = "Race ID:";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(77, 41);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(45, 19);
            this.lblRace.TabIndex = 35;
            this.lblRace.Text = "Race:";
            // 
            // lblMeetingName
            // 
            this.lblMeetingName.AutoSize = true;
            this.lblMeetingName.Location = new System.Drawing.Point(13, 180);
            this.lblMeetingName.Name = "lblMeetingName";
            this.lblMeetingName.Size = new System.Drawing.Size(109, 19);
            this.lblMeetingName.TabIndex = 41;
            this.lblMeetingName.Text = "Meeting Name:";
            // 
            // txtMeetingName
            // 
            this.txtMeetingName.Location = new System.Drawing.Point(238, 172);
            this.txtMeetingName.Name = "txtMeetingName";
            this.txtMeetingName.Size = new System.Drawing.Size(217, 27);
            this.txtMeetingName.TabIndex = 42;
            // 
            // lblRaceEntry
            // 
            this.lblRaceEntry.AutoSize = true;
            this.lblRaceEntry.Location = new System.Drawing.Point(40, 226);
            this.lblRaceEntry.Name = "lblRaceEntry";
            this.lblRaceEntry.Size = new System.Drawing.Size(82, 19);
            this.lblRaceEntry.TabIndex = 43;
            this.lblRaceEntry.Text = "Race Entry:";
            // 
            // lstRaceEntry
            // 
            this.lstRaceEntry.FormattingEnabled = true;
            this.lstRaceEntry.ItemHeight = 19;
            this.lstRaceEntry.Location = new System.Drawing.Point(238, 226);
            this.lstRaceEntry.Name = "lstRaceEntry";
            this.lstRaceEntry.Size = new System.Drawing.Size(217, 213);
            this.lstRaceEntry.TabIndex = 44;
            this.lstRaceEntry.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cboHorse
            // 
            this.cboHorse.FormattingEnabled = true;
            this.cboHorse.Location = new System.Drawing.Point(238, 466);
            this.cboHorse.MaxLength = 7;
            this.cboHorse.Name = "cboHorse";
            this.cboHorse.Size = new System.Drawing.Size(217, 27);
            this.cboHorse.TabIndex = 45;
            // 
            // lblHorse
            // 
            this.lblHorse.AutoSize = true;
            this.lblHorse.Location = new System.Drawing.Point(71, 474);
            this.lblHorse.Name = "lblHorse";
            this.lblHorse.Size = new System.Drawing.Size(51, 19);
            this.lblHorse.TabIndex = 46;
            this.lblHorse.Text = "Horse:";
            // 
            // lblJockey
            // 
            this.lblJockey.AutoSize = true;
            this.lblJockey.Location = new System.Drawing.Point(68, 519);
            this.lblJockey.Name = "lblJockey";
            this.lblJockey.Size = new System.Drawing.Size(54, 19);
            this.lblJockey.TabIndex = 47;
            this.lblJockey.Text = "Jockey:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(69, 566);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 19);
            this.lblStatus.TabIndex = 48;
            this.lblStatus.Text = "Status:";
            // 
            // btnAddRaceEntry
            // 
            this.btnAddRaceEntry.Location = new System.Drawing.Point(17, 630);
            this.btnAddRaceEntry.Name = "btnAddRaceEntry";
            this.btnAddRaceEntry.Size = new System.Drawing.Size(192, 57);
            this.btnAddRaceEntry.TabIndex = 49;
            this.btnAddRaceEntry.Text = "Add Race Entry";
            this.btnAddRaceEntry.UseVisualStyleBackColor = true;
            this.btnAddRaceEntry.Click += new System.EventHandler(this.btnAddRaceEntry_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(288, 630);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(192, 57);
            this.btnReturn.TabIndex = 50;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Pending",
            "Disqualified",
            "Confirmed"});
            this.cboStatus.Location = new System.Drawing.Point(238, 558);
            this.cboStatus.MaxLength = 7;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(117, 27);
            this.cboStatus.TabIndex = 51;
            // 
            // cboJockey
            // 
            this.cboJockey.FormattingEnabled = true;
            this.cboJockey.Location = new System.Drawing.Point(238, 511);
            this.cboJockey.MaxLength = 7;
            this.cboJockey.Name = "cboJockey";
            this.cboJockey.Size = new System.Drawing.Size(217, 27);
            this.cboJockey.TabIndex = 52;
            this.cboJockey.SelectedIndexChanged += new System.EventHandler(this.cboJockey_SelectedIndexChanged);
            // 
            // RaceEntryAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 710);
            this.Controls.Add(this.cboJockey);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddRaceEntry);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblJockey);
            this.Controls.Add(this.lblHorse);
            this.Controls.Add(this.cboHorse);
            this.Controls.Add(this.lstRaceEntry);
            this.Controls.Add(this.lblRaceEntry);
            this.Controls.Add(this.txtMeetingName);
            this.Controls.Add(this.lblMeetingName);
            this.Controls.Add(this.txtRaceName);
            this.Controls.Add(this.txtRaceID);
            this.Controls.Add(this.cboRace);
            this.Controls.Add(this.lblRaceName);
            this.Controls.Add(this.lblRaceID);
            this.Controls.Add(this.lblRace);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RaceEntryAddForm";
            this.Text = "RaceEntryAddForm";
            this.Load += new System.EventHandler(this.RaceEntryAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRaceName;
        private System.Windows.Forms.TextBox txtRaceID;
        private System.Windows.Forms.ComboBox cboRace;
        private System.Windows.Forms.Label lblRaceName;
        private System.Windows.Forms.Label lblRaceID;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblMeetingName;
        private System.Windows.Forms.TextBox txtMeetingName;
        private System.Windows.Forms.Label lblRaceEntry;
        private System.Windows.Forms.ListBox lstRaceEntry;
        private System.Windows.Forms.ComboBox cboHorse;
        private System.Windows.Forms.Label lblHorse;
        private System.Windows.Forms.Label lblJockey;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAddRaceEntry;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboJockey;
    }
}