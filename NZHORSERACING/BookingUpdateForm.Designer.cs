
namespace NZHORSERACING
{
    partial class BookingUpdateForm
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
            this.cboBooking = new System.Windows.Forms.ComboBox();
            this.lblBooking = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.lblCustomerFirstName = new System.Windows.Forms.Label();
            this.lblMeetingName = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.txtMeetingName = new System.Windows.Forms.TextBox();
            this.btnUpdateBooking = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboBooking
            // 
            this.cboBooking.FormattingEnabled = true;
            this.cboBooking.Location = new System.Drawing.Point(235, 58);
            this.cboBooking.MaxLength = 7;
            this.cboBooking.Name = "cboBooking";
            this.cboBooking.Size = new System.Drawing.Size(217, 27);
            this.cboBooking.TabIndex = 20;
            this.cboBooking.SelectedIndexChanged += new System.EventHandler(this.cboBooking_SelectedIndexChanged);
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Location = new System.Drawing.Point(72, 66);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(65, 19);
            this.lblBooking.TabIndex = 21;
            this.lblBooking.Text = "Booking:";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(54, 122);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(83, 19);
            this.lblBookingID.TabIndex = 22;
            this.lblBookingID.Text = "Booking ID:";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Location = new System.Drawing.Point(37, 178);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(100, 19);
            this.lblBookingDate.TabIndex = 23;
            this.lblBookingDate.Text = "Booking Date:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(68, 240);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 19);
            this.lblQuantity.TabIndex = 24;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(84, 300);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 19);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "Status:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(44, 353);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(93, 19);
            this.lblCustomerID.TabIndex = 26;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Location = new System.Drawing.Point(12, 405);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(148, 19);
            this.lblCustomerLastName.TabIndex = 27;
            this.lblCustomerLastName.Text = "Customer Last Name:";
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.AutoSize = true;
            this.lblCustomerFirstName.Location = new System.Drawing.Point(11, 456);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(149, 19);
            this.lblCustomerFirstName.TabIndex = 28;
            this.lblCustomerFirstName.Text = "Customer First Name:";
            // 
            // lblMeetingName
            // 
            this.lblMeetingName.AutoSize = true;
            this.lblMeetingName.Location = new System.Drawing.Point(51, 505);
            this.lblMeetingName.Name = "lblMeetingName";
            this.lblMeetingName.Size = new System.Drawing.Size(109, 19);
            this.lblMeetingName.TabIndex = 29;
            this.lblMeetingName.Text = "Meeting Name:";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(235, 114);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(55, 27);
            this.txtBookingID.TabIndex = 30;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Location = new System.Drawing.Point(235, 172);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(200, 27);
            this.dtpBookingDate.TabIndex = 31;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(235, 232);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(55, 27);
            this.txtQuantity.TabIndex = 32;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Pending",
            "Paid"});
            this.cboStatus.Location = new System.Drawing.Point(235, 292);
            this.cboStatus.MaxLength = 7;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(133, 27);
            this.cboStatus.TabIndex = 33;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(235, 345);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(55, 27);
            this.txtCustomerID.TabIndex = 34;
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(235, 405);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(217, 27);
            this.txtCustomerLastName.TabIndex = 35;
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Location = new System.Drawing.Point(235, 448);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(217, 27);
            this.txtCustomerFirstName.TabIndex = 36;
            // 
            // txtMeetingName
            // 
            this.txtMeetingName.Location = new System.Drawing.Point(235, 497);
            this.txtMeetingName.Name = "txtMeetingName";
            this.txtMeetingName.Size = new System.Drawing.Size(217, 27);
            this.txtMeetingName.TabIndex = 37;
            // 
            // btnUpdateBooking
            // 
            this.btnUpdateBooking.Location = new System.Drawing.Point(27, 571);
            this.btnUpdateBooking.Name = "btnUpdateBooking";
            this.btnUpdateBooking.Size = new System.Drawing.Size(170, 64);
            this.btnUpdateBooking.TabIndex = 38;
            this.btnUpdateBooking.Text = "Update Booking";
            this.btnUpdateBooking.UseVisualStyleBackColor = true;
            this.btnUpdateBooking.Click += new System.EventHandler(this.btnUpdateBooking_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(349, 571);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(170, 64);
            this.btnReturn.TabIndex = 39;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // BookingUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 658);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateBooking);
            this.Controls.Add(this.txtMeetingName);
            this.Controls.Add(this.txtCustomerFirstName);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dtpBookingDate);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.lblMeetingName);
            this.Controls.Add(this.lblCustomerFirstName);
            this.Controls.Add(this.lblCustomerLastName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblBookingDate);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.cboBooking);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookingUpdateForm";
            this.Text = "BookingUpdateForm";
            this.Load += new System.EventHandler(this.BookingUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBooking;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.Label lblCustomerFirstName;
        private System.Windows.Forms.Label lblMeetingName;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.TextBox txtMeetingName;
        private System.Windows.Forms.Button btnUpdateBooking;
        private System.Windows.Forms.Button btnReturn;
    }
}