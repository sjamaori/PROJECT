
namespace NZHORSERACING
{
    partial class HorseUpdateForm
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
            this.lblHorse = new System.Windows.Forms.Label();
            this.cboHorse = new System.Windows.Forms.ComboBox();
            this.txtHorseName = new System.Windows.Forms.TextBox();
            this.lblHorseName = new System.Windows.Forms.Label();
            this.txtHorseID = new System.Windows.Forms.TextBox();
            this.lblHorseID = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtOwnerFirstName = new System.Windows.Forms.TextBox();
            this.txtOwnerLastName = new System.Windows.Forms.TextBox();
            this.lblOwnerFirstName = new System.Windows.Forms.Label();
            this.lblOwnerLastName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.btnUpdateHorse = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHorse
            // 
            this.lblHorse.AutoSize = true;
            this.lblHorse.Location = new System.Drawing.Point(95, 66);
            this.lblHorse.Name = "lblHorse";
            this.lblHorse.Size = new System.Drawing.Size(51, 19);
            this.lblHorse.TabIndex = 23;
            this.lblHorse.Text = "Horse:";
            // 
            // cboHorse
            // 
            this.cboHorse.FormattingEnabled = true;
            this.cboHorse.Location = new System.Drawing.Point(213, 58);
            this.cboHorse.MaxLength = 7;
            this.cboHorse.Name = "cboHorse";
            this.cboHorse.Size = new System.Drawing.Size(217, 27);
            this.cboHorse.TabIndex = 22;
            this.cboHorse.SelectedIndexChanged += new System.EventHandler(this.cboHorse_SelectedIndexChanged_1);
            // 
            // txtHorseName
            // 
            this.txtHorseName.Location = new System.Drawing.Point(213, 191);
            this.txtHorseName.Name = "txtHorseName";
            this.txtHorseName.Size = new System.Drawing.Size(217, 27);
            this.txtHorseName.TabIndex = 34;
            // 
            // lblHorseName
            // 
            this.lblHorseName.AutoSize = true;
            this.lblHorseName.Location = new System.Drawing.Point(53, 199);
            this.lblHorseName.Name = "lblHorseName";
            this.lblHorseName.Size = new System.Drawing.Size(93, 19);
            this.lblHorseName.TabIndex = 33;
            this.lblHorseName.Text = "Horse Name:";
            // 
            // txtHorseID
            // 
            this.txtHorseID.Location = new System.Drawing.Point(213, 127);
            this.txtHorseID.Name = "txtHorseID";
            this.txtHorseID.Size = new System.Drawing.Size(55, 27);
            this.txtHorseID.TabIndex = 32;
            // 
            // lblHorseID
            // 
            this.lblHorseID.AutoSize = true;
            this.lblHorseID.Location = new System.Drawing.Point(77, 135);
            this.lblHorseID.Name = "lblHorseID";
            this.lblHorseID.Size = new System.Drawing.Size(69, 19);
            this.lblHorseID.TabIndex = 31;
            this.lblHorseID.Text = "Horse ID:";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Gelding"});
            this.cboGender.Location = new System.Drawing.Point(213, 262);
            this.cboGender.MaxLength = 7;
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(217, 27);
            this.cboGender.TabIndex = 36;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(86, 270);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 19);
            this.lblGender.TabIndex = 35;
            this.lblGender.Text = "Gender:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(213, 327);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 27);
            this.dtpDateOfBirth.TabIndex = 42;
            // 
            // txtOwnerFirstName
            // 
            this.txtOwnerFirstName.Location = new System.Drawing.Point(213, 452);
            this.txtOwnerFirstName.Name = "txtOwnerFirstName";
            this.txtOwnerFirstName.Size = new System.Drawing.Size(217, 27);
            this.txtOwnerFirstName.TabIndex = 41;
            // 
            // txtOwnerLastName
            // 
            this.txtOwnerLastName.Location = new System.Drawing.Point(213, 391);
            this.txtOwnerLastName.Name = "txtOwnerLastName";
            this.txtOwnerLastName.Size = new System.Drawing.Size(217, 27);
            this.txtOwnerLastName.TabIndex = 40;
            // 
            // lblOwnerFirstName
            // 
            this.lblOwnerFirstName.AutoSize = true;
            this.lblOwnerFirstName.Location = new System.Drawing.Point(16, 460);
            this.lblOwnerFirstName.Name = "lblOwnerFirstName";
            this.lblOwnerFirstName.Size = new System.Drawing.Size(130, 19);
            this.lblOwnerFirstName.TabIndex = 39;
            this.lblOwnerFirstName.Text = "Owner First Name:";
            // 
            // lblOwnerLastName
            // 
            this.lblOwnerLastName.AutoSize = true;
            this.lblOwnerLastName.Location = new System.Drawing.Point(17, 391);
            this.lblOwnerLastName.Name = "lblOwnerLastName";
            this.lblOwnerLastName.Size = new System.Drawing.Size(129, 19);
            this.lblOwnerLastName.TabIndex = 38;
            this.lblOwnerLastName.Text = "Owner Last Name:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(44, 335);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(99, 19);
            this.lblDateOfBirth.TabIndex = 37;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            // 
            // btnUpdateHorse
            // 
            this.btnUpdateHorse.Location = new System.Drawing.Point(21, 573);
            this.btnUpdateHorse.Name = "btnUpdateHorse";
            this.btnUpdateHorse.Size = new System.Drawing.Size(177, 60);
            this.btnUpdateHorse.TabIndex = 43;
            this.btnUpdateHorse.Text = "Update Horse";
            this.btnUpdateHorse.UseVisualStyleBackColor = true;
            this.btnUpdateHorse.Click += new System.EventHandler(this.btnUpdateHorse_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(339, 573);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(177, 60);
            this.btnReturn.TabIndex = 44;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // HorseUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 658);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateHorse);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtOwnerFirstName);
            this.Controls.Add(this.txtOwnerLastName);
            this.Controls.Add(this.lblOwnerFirstName);
            this.Controls.Add(this.lblOwnerLastName);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtHorseName);
            this.Controls.Add(this.lblHorseName);
            this.Controls.Add(this.txtHorseID);
            this.Controls.Add(this.lblHorseID);
            this.Controls.Add(this.lblHorse);
            this.Controls.Add(this.cboHorse);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HorseUpdateForm";
            this.Text = "HorseUpdateForm";
            this.Load += new System.EventHandler(this.HorseUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorse;
        private System.Windows.Forms.ComboBox cboHorse;
        private System.Windows.Forms.TextBox txtHorseName;
        private System.Windows.Forms.Label lblHorseName;
        private System.Windows.Forms.TextBox txtHorseID;
        private System.Windows.Forms.Label lblHorseID;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtOwnerFirstName;
        private System.Windows.Forms.TextBox txtOwnerLastName;
        private System.Windows.Forms.Label lblOwnerFirstName;
        private System.Windows.Forms.Label lblOwnerLastName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Button btnUpdateHorse;
        private System.Windows.Forms.Button btnReturn;
    }
}