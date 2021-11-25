
namespace NZHORSERACING
{
    partial class BookingDeleteForm
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
            this.lblBooking = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCustonerID = new System.Windows.Forms.Label();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.lblCustomerFirstName = new System.Windows.Forms.Label();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cboBooking = new System.Windows.Forms.ComboBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Location = new System.Drawing.Point(43, 46);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(65, 19);
            this.lblBooking.TabIndex = 0;
            this.lblBooking.Text = "Booking:";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(25, 98);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(83, 19);
            this.lblBookingID.TabIndex = 1;
            this.lblBookingID.Text = "Booking ID:";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Location = new System.Drawing.Point(8, 144);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(100, 19);
            this.lblBookingDate.TabIndex = 2;
            this.lblBookingDate.Text = "Booking Date:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(39, 191);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 19);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(55, 242);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 19);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // lblCustonerID
            // 
            this.lblCustonerID.AutoSize = true;
            this.lblCustonerID.Location = new System.Drawing.Point(15, 292);
            this.lblCustonerID.Name = "lblCustonerID";
            this.lblCustonerID.Size = new System.Drawing.Size(93, 19);
            this.lblCustonerID.TabIndex = 5;
            this.lblCustonerID.Text = "Customer ID:";
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Location = new System.Drawing.Point(25, 342);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(148, 19);
            this.lblCustomerLastName.TabIndex = 6;
            this.lblCustomerLastName.Text = "Customer Last Name:";
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.AutoSize = true;
            this.lblCustomerFirstName.Location = new System.Drawing.Point(25, 394);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(149, 19);
            this.lblCustomerFirstName.TabIndex = 7;
            this.lblCustomerFirstName.Text = "Customer First Name:";
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(19, 571);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(148, 64);
            this.btnDeleteBooking.TabIndex = 8;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(326, 571);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(148, 64);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cboBooking
            // 
            this.cboBooking.FormattingEnabled = true;
            this.cboBooking.Location = new System.Drawing.Point(189, 38);
            this.cboBooking.MaxLength = 7;
            this.cboBooking.Name = "cboBooking";
            this.cboBooking.Size = new System.Drawing.Size(217, 27);
            this.cboBooking.TabIndex = 19;
            this.cboBooking.SelectedIndexChanged += new System.EventHandler(this.cboBooking_SelectedIndexChanged);
            // 
            // txtBookingID
            // 
            this.txtBookingID.Enabled = false;
            this.txtBookingID.Location = new System.Drawing.Point(189, 90);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(55, 27);
            this.txtBookingID.TabIndex = 20;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Enabled = false;
            this.dtpBookingDate.Location = new System.Drawing.Point(189, 136);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(200, 27);
            this.dtpBookingDate.TabIndex = 21;
            this.dtpBookingDate.ValueChanged += new System.EventHandler(this.dtpBookingDate_ValueChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(189, 183);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(55, 27);
            this.txtQuantity.TabIndex = 22;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(189, 284);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(55, 27);
            this.txtCustomerID.TabIndex = 24;
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Enabled = false;
            this.txtCustomerLastName.Location = new System.Drawing.Point(189, 334);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(217, 27);
            this.txtCustomerLastName.TabIndex = 25;
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Enabled = false;
            this.txtCustomerFirstName.Location = new System.Drawing.Point(189, 386);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(217, 27);
            this.txtCustomerFirstName.TabIndex = 26;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(189, 234);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(217, 27);
            this.txtStatus.TabIndex = 27;
            // 
            // BookingDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 658);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtCustomerFirstName);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dtpBookingDate);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.cboBooking);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.lblCustomerFirstName);
            this.Controls.Add(this.lblCustomerLastName);
            this.Controls.Add(this.lblCustonerID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblBookingDate);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.lblBooking);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookingDeleteForm";
            this.Text = "BookingDeleteForm";
            this.Load += new System.EventHandler(this.BookingDeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCustonerID;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.Label lblCustomerFirstName;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cboBooking;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.TextBox txtStatus;
    }
}