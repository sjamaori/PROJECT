
namespace NZHORSERACING
{
    partial class HorseDeleteForm
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
            this.cboHorse = new System.Windows.Forms.ComboBox();
            this.lblHorse = new System.Windows.Forms.Label();
            this.lblHorseID = new System.Windows.Forms.Label();
            this.txtHorseID = new System.Windows.Forms.TextBox();
            this.lblHorseName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblOwnerLastName = new System.Windows.Forms.Label();
            this.lblOwnerFirstName = new System.Windows.Forms.Label();
            this.btnDeleteHorse = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtHorseName = new System.Windows.Forms.TextBox();
            this.txtOwnerLastName = new System.Windows.Forms.TextBox();
            this.txtOwnerFirstName = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cboHorse
            // 
            this.cboHorse.FormattingEnabled = true;
            this.cboHorse.Location = new System.Drawing.Point(197, 62);
            this.cboHorse.MaxLength = 7;
            this.cboHorse.Name = "cboHorse";
            this.cboHorse.Size = new System.Drawing.Size(217, 27);
            this.cboHorse.TabIndex = 20;
            this.cboHorse.SelectedIndexChanged += new System.EventHandler(this.cboHorse_SelectedIndexChanged);
            // 
            // lblHorse
            // 
            this.lblHorse.AutoSize = true;
            this.lblHorse.Location = new System.Drawing.Point(79, 70);
            this.lblHorse.Name = "lblHorse";
            this.lblHorse.Size = new System.Drawing.Size(51, 19);
            this.lblHorse.TabIndex = 21;
            this.lblHorse.Text = "Horse:";
            // 
            // lblHorseID
            // 
            this.lblHorseID.AutoSize = true;
            this.lblHorseID.Location = new System.Drawing.Point(61, 128);
            this.lblHorseID.Name = "lblHorseID";
            this.lblHorseID.Size = new System.Drawing.Size(69, 19);
            this.lblHorseID.TabIndex = 22;
            this.lblHorseID.Text = "Horse ID:";
            // 
            // txtHorseID
            // 
            this.txtHorseID.Enabled = false;
            this.txtHorseID.Location = new System.Drawing.Point(197, 120);
            this.txtHorseID.Name = "txtHorseID";
            this.txtHorseID.Size = new System.Drawing.Size(55, 27);
            this.txtHorseID.TabIndex = 23;
            // 
            // lblHorseName
            // 
            this.lblHorseName.AutoSize = true;
            this.lblHorseName.Location = new System.Drawing.Point(37, 192);
            this.lblHorseName.Name = "lblHorseName";
            this.lblHorseName.Size = new System.Drawing.Size(93, 19);
            this.lblHorseName.TabIndex = 24;
            this.lblHorseName.Text = "Horse Name:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(28, 260);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(99, 19);
            this.lblDateOfBirth.TabIndex = 25;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            // 
            // lblOwnerLastName
            // 
            this.lblOwnerLastName.AutoSize = true;
            this.lblOwnerLastName.Location = new System.Drawing.Point(1, 316);
            this.lblOwnerLastName.Name = "lblOwnerLastName";
            this.lblOwnerLastName.Size = new System.Drawing.Size(129, 19);
            this.lblOwnerLastName.TabIndex = 26;
            this.lblOwnerLastName.Text = "Owner Last Name:";
            // 
            // lblOwnerFirstName
            // 
            this.lblOwnerFirstName.AutoSize = true;
            this.lblOwnerFirstName.Location = new System.Drawing.Point(0, 385);
            this.lblOwnerFirstName.Name = "lblOwnerFirstName";
            this.lblOwnerFirstName.Size = new System.Drawing.Size(130, 19);
            this.lblOwnerFirstName.TabIndex = 27;
            this.lblOwnerFirstName.Text = "Owner First Name:";
            // 
            // btnDeleteHorse
            // 
            this.btnDeleteHorse.Location = new System.Drawing.Point(32, 562);
            this.btnDeleteHorse.Name = "btnDeleteHorse";
            this.btnDeleteHorse.Size = new System.Drawing.Size(169, 62);
            this.btnDeleteHorse.TabIndex = 28;
            this.btnDeleteHorse.Text = "Delete Horse";
            this.btnDeleteHorse.UseVisualStyleBackColor = true;
            this.btnDeleteHorse.Click += new System.EventHandler(this.btnDeleteHorse_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(340, 562);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(169, 62);
            this.btnReturn.TabIndex = 29;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtHorseName
            // 
            this.txtHorseName.Enabled = false;
            this.txtHorseName.Location = new System.Drawing.Point(197, 184);
            this.txtHorseName.Name = "txtHorseName";
            this.txtHorseName.Size = new System.Drawing.Size(217, 27);
            this.txtHorseName.TabIndex = 30;
            // 
            // txtOwnerLastName
            // 
            this.txtOwnerLastName.Enabled = false;
            this.txtOwnerLastName.Location = new System.Drawing.Point(197, 316);
            this.txtOwnerLastName.Name = "txtOwnerLastName";
            this.txtOwnerLastName.Size = new System.Drawing.Size(217, 27);
            this.txtOwnerLastName.TabIndex = 31;
            // 
            // txtOwnerFirstName
            // 
            this.txtOwnerFirstName.Enabled = false;
            this.txtOwnerFirstName.Location = new System.Drawing.Point(197, 377);
            this.txtOwnerFirstName.Name = "txtOwnerFirstName";
            this.txtOwnerFirstName.Size = new System.Drawing.Size(217, 27);
            this.txtOwnerFirstName.TabIndex = 32;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Enabled = false;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(197, 252);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 27);
            this.dtpDateOfBirth.TabIndex = 33;
            // 
            // HorseDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 658);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtOwnerFirstName);
            this.Controls.Add(this.txtOwnerLastName);
            this.Controls.Add(this.txtHorseName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteHorse);
            this.Controls.Add(this.lblOwnerFirstName);
            this.Controls.Add(this.lblOwnerLastName);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblHorseName);
            this.Controls.Add(this.txtHorseID);
            this.Controls.Add(this.lblHorseID);
            this.Controls.Add(this.lblHorse);
            this.Controls.Add(this.cboHorse);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HorseDeleteForm";
            this.Text = "HorseDeleteForm";
            this.Load += new System.EventHandler(this.HorseDeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboHorse;
        private System.Windows.Forms.Label lblHorse;
        private System.Windows.Forms.Label lblHorseID;
        private System.Windows.Forms.TextBox txtHorseID;
        private System.Windows.Forms.Label lblHorseName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblOwnerLastName;
        private System.Windows.Forms.Label lblOwnerFirstName;
        private System.Windows.Forms.Button btnDeleteHorse;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtHorseName;
        private System.Windows.Forms.TextBox txtOwnerLastName;
        private System.Windows.Forms.TextBox txtOwnerFirstName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
    }
}