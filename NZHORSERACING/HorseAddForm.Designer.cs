
namespace NZHORSERACING
{
    partial class HorseAddForm
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
            this.lblHorseName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnAddHorse = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtHorseName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cboOwner = new System.Windows.Forms.ComboBox();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblHorseName
            // 
            this.lblHorseName.AutoSize = true;
            this.lblHorseName.Location = new System.Drawing.Point(51, 40);
            this.lblHorseName.Name = "lblHorseName";
            this.lblHorseName.Size = new System.Drawing.Size(93, 19);
            this.lblHorseName.TabIndex = 1;
            this.lblHorseName.Text = "Horse Name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(84, 83);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 19);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(45, 132);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(99, 19);
            this.lblDateOfBirth.TabIndex = 3;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(88, 184);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(56, 19);
            this.lblOwner.TabIndex = 4;
            this.lblOwner.Text = "Owner:";
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(70, 232);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(74, 19);
            this.lblOwnerID.TabIndex = 5;
            this.lblOwnerID.Text = "Owner ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(62, 282);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 19);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(61, 334);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 19);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnAddHorse
            // 
            this.btnAddHorse.Location = new System.Drawing.Point(27, 557);
            this.btnAddHorse.Name = "btnAddHorse";
            this.btnAddHorse.Size = new System.Drawing.Size(163, 68);
            this.btnAddHorse.TabIndex = 8;
            this.btnAddHorse.Text = "Add Horse";
            this.btnAddHorse.UseVisualStyleBackColor = true;
            this.btnAddHorse.Click += new System.EventHandler(this.btnAddHorse_Click_1);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(348, 557);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(163, 68);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtHorseName
            // 
            this.txtHorseName.Location = new System.Drawing.Point(225, 32);
            this.txtHorseName.Name = "txtHorseName";
            this.txtHorseName.Size = new System.Drawing.Size(217, 27);
            this.txtHorseName.TabIndex = 13;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(225, 274);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(217, 27);
            this.txtLastName.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(225, 326);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(217, 27);
            this.txtFirstName.TabIndex = 15;
            // 
            // cboOwner
            // 
            this.cboOwner.FormattingEnabled = true;
            this.cboOwner.Location = new System.Drawing.Point(225, 176);
            this.cboOwner.Name = "cboOwner";
            this.cboOwner.Size = new System.Drawing.Size(217, 27);
            this.cboOwner.TabIndex = 16;
            this.cboOwner.SelectedIndexChanged += new System.EventHandler(this.cboOwner_SelectedIndexChanged);
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(225, 224);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(55, 27);
            this.txtOwnerID.TabIndex = 17;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Gelding"});
            this.cboGender.Location = new System.Drawing.Point(225, 80);
            this.cboGender.MaxLength = 7;
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(217, 27);
            this.cboGender.TabIndex = 18;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(225, 124);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(217, 27);
            this.dtpDateOfBirth.TabIndex = 19;
            // 
            // HorseAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 658);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.cboOwner);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtHorseName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddHorse);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblHorseName);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HorseAddForm";
            this.Text = "HorseAddForm";
            this.Load += new System.EventHandler(this.HorseAddForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHorseName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnAddHorse;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtHorseName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cboOwner;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
    }
}