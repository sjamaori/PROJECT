
namespace NZHORSERACING
{
    partial class MainForm
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
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnAddHorse = new System.Windows.Forms.Button();
            this.btnDeleteHorse = new System.Windows.Forms.Button();
            this.btnDeleteRaceEntry = new System.Windows.Forms.Button();
            this.btnAddRaceEntry = new System.Windows.Forms.Button();
            this.btnUpdateHorse = new System.Windows.Forms.Button();
            this.btnUpdateBooking = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(25, 23);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(228, 88);
            this.btnAddBooking.TabIndex = 0;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(282, 22);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(228, 88);
            this.btnDeleteBooking.TabIndex = 1;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnAddHorse
            // 
            this.btnAddHorse.Location = new System.Drawing.Point(25, 142);
            this.btnAddHorse.Name = "btnAddHorse";
            this.btnAddHorse.Size = new System.Drawing.Size(228, 88);
            this.btnAddHorse.TabIndex = 2;
            this.btnAddHorse.Text = "Add Horse";
            this.btnAddHorse.UseVisualStyleBackColor = true;
            this.btnAddHorse.Click += new System.EventHandler(this.btnAddHorse_Click);
            // 
            // btnDeleteHorse
            // 
            this.btnDeleteHorse.Location = new System.Drawing.Point(282, 142);
            this.btnDeleteHorse.Name = "btnDeleteHorse";
            this.btnDeleteHorse.Size = new System.Drawing.Size(228, 88);
            this.btnDeleteHorse.TabIndex = 3;
            this.btnDeleteHorse.Text = "Delete Horse";
            this.btnDeleteHorse.UseVisualStyleBackColor = true;
            this.btnDeleteHorse.Click += new System.EventHandler(this.btnDeleteHorse_Click);
            // 
            // btnDeleteRaceEntry
            // 
            this.btnDeleteRaceEntry.Location = new System.Drawing.Point(282, 261);
            this.btnDeleteRaceEntry.Name = "btnDeleteRaceEntry";
            this.btnDeleteRaceEntry.Size = new System.Drawing.Size(228, 88);
            this.btnDeleteRaceEntry.TabIndex = 4;
            this.btnDeleteRaceEntry.Text = "Delete Race Entry";
            this.btnDeleteRaceEntry.UseVisualStyleBackColor = true;
            this.btnDeleteRaceEntry.Click += new System.EventHandler(this.btnDeleteRaceEntry_Click);
            // 
            // btnAddRaceEntry
            // 
            this.btnAddRaceEntry.Location = new System.Drawing.Point(25, 261);
            this.btnAddRaceEntry.Name = "btnAddRaceEntry";
            this.btnAddRaceEntry.Size = new System.Drawing.Size(228, 88);
            this.btnAddRaceEntry.TabIndex = 5;
            this.btnAddRaceEntry.Text = "Add Race Entry";
            this.btnAddRaceEntry.UseVisualStyleBackColor = true;
            this.btnAddRaceEntry.Click += new System.EventHandler(this.btnAddRaceEntry_Click);
            // 
            // btnUpdateHorse
            // 
            this.btnUpdateHorse.Location = new System.Drawing.Point(282, 380);
            this.btnUpdateHorse.Name = "btnUpdateHorse";
            this.btnUpdateHorse.Size = new System.Drawing.Size(228, 88);
            this.btnUpdateHorse.TabIndex = 6;
            this.btnUpdateHorse.Text = "Update Horse";
            this.btnUpdateHorse.UseVisualStyleBackColor = true;
            this.btnUpdateHorse.Click += new System.EventHandler(this.btnUpdateHorse_Click);
            // 
            // btnUpdateBooking
            // 
            this.btnUpdateBooking.Location = new System.Drawing.Point(25, 380);
            this.btnUpdateBooking.Name = "btnUpdateBooking";
            this.btnUpdateBooking.Size = new System.Drawing.Size(228, 88);
            this.btnUpdateBooking.TabIndex = 7;
            this.btnUpdateBooking.Text = "Update Booking";
            this.btnUpdateBooking.UseVisualStyleBackColor = true;
            this.btnUpdateBooking.Click += new System.EventHandler(this.btnUpdateBooking_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(153, 498);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(228, 88);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 613);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateBooking);
            this.Controls.Add(this.btnUpdateHorse);
            this.Controls.Add(this.btnAddRaceEntry);
            this.Controls.Add(this.btnDeleteRaceEntry);
            this.Controls.Add(this.btnDeleteHorse);
            this.Controls.Add(this.btnAddHorse);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.btnAddBooking);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "NZHORSERACING";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnAddHorse;
        private System.Windows.Forms.Button btnDeleteHorse;
        private System.Windows.Forms.Button btnDeleteRaceEntry;
        private System.Windows.Forms.Button btnAddRaceEntry;
        private System.Windows.Forms.Button btnUpdateHorse;
        private System.Windows.Forms.Button btnUpdateBooking;
        private System.Windows.Forms.Button btnExit;
    }
}

