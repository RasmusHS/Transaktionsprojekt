namespace Transaktionsprojekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSpecifyFlight = new System.Windows.Forms.Label();
            this.cmbBoxPickFlightNo = new System.Windows.Forms.ComboBox();
            this.grpBoxTransaction = new System.Windows.Forms.GroupBox();
            this.btnReserveSeats = new System.Windows.Forms.Button();
            this.txtBoxSeatsToReserve = new System.Windows.Forms.TextBox();
            this.lblNumberToReserve = new System.Windows.Forms.Label();
            this.grpBoxGetSeats = new System.Windows.Forms.GroupBox();
            this.txtBoxFreeSeats = new System.Windows.Forms.TextBox();
            this.lblFreeSeatsOnFlight = new System.Windows.Forms.Label();
            this.btnSerilazable = new System.Windows.Forms.Button();
            this.btnReadUncommited = new System.Windows.Forms.Button();
            this.lblGetSeatsMethod = new System.Windows.Forms.Label();
            this.lblFeedbackServer = new System.Windows.Forms.Label();
            this.txtBoxFeedbackServer = new System.Windows.Forms.TextBox();
            this.grpBoxTransaction.SuspendLayout();
            this.grpBoxGetSeats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSpecifyFlight
            // 
            this.lblSpecifyFlight.AutoSize = true;
            this.lblSpecifyFlight.Location = new System.Drawing.Point(44, 21);
            this.lblSpecifyFlight.Name = "lblSpecifyFlight";
            this.lblSpecifyFlight.Size = new System.Drawing.Size(142, 15);
            this.lblSpecifyFlight.TabIndex = 0;
            this.lblSpecifyFlight.Text = " Please specify a flightNo:";
            // 
            // cmbBoxPickFlightNo
            // 
            this.cmbBoxPickFlightNo.FormattingEnabled = true;
            this.cmbBoxPickFlightNo.Location = new System.Drawing.Point(264, 18);
            this.cmbBoxPickFlightNo.Name = "cmbBoxPickFlightNo";
            this.cmbBoxPickFlightNo.Size = new System.Drawing.Size(121, 23);
            this.cmbBoxPickFlightNo.TabIndex = 1;
            // 
            // grpBoxTransaction
            // 
            this.grpBoxTransaction.Controls.Add(this.btnReserveSeats);
            this.grpBoxTransaction.Controls.Add(this.txtBoxSeatsToReserve);
            this.grpBoxTransaction.Controls.Add(this.lblNumberToReserve);
            this.grpBoxTransaction.Controls.Add(this.grpBoxGetSeats);
            this.grpBoxTransaction.Location = new System.Drawing.Point(11, 68);
            this.grpBoxTransaction.Name = "grpBoxTransaction";
            this.grpBoxTransaction.Size = new System.Drawing.Size(442, 348);
            this.grpBoxTransaction.TabIndex = 2;
            this.grpBoxTransaction.TabStop = false;
            this.grpBoxTransaction.Text = "Transaction:";
            // 
            // btnReserveSeats
            // 
            this.btnReserveSeats.Location = new System.Drawing.Point(274, 289);
            this.btnReserveSeats.Name = "btnReserveSeats";
            this.btnReserveSeats.Size = new System.Drawing.Size(100, 23);
            this.btnReserveSeats.TabIndex = 3;
            this.btnReserveSeats.Text = "Reserve seats";
            this.btnReserveSeats.UseVisualStyleBackColor = true;
            this.btnReserveSeats.Click += new System.EventHandler(this.btnReserveSeats_Click);
            // 
            // txtBoxSeatsToReserve
            // 
            this.txtBoxSeatsToReserve.Location = new System.Drawing.Point(274, 246);
            this.txtBoxSeatsToReserve.Name = "txtBoxSeatsToReserve";
            this.txtBoxSeatsToReserve.Size = new System.Drawing.Size(100, 23);
            this.txtBoxSeatsToReserve.TabIndex = 2;
            // 
            // lblNumberToReserve
            // 
            this.lblNumberToReserve.AutoSize = true;
            this.lblNumberToReserve.Location = new System.Drawing.Point(12, 249);
            this.lblNumberToReserve.Name = "lblNumberToReserve";
            this.lblNumberToReserve.Size = new System.Drawing.Size(151, 15);
            this.lblNumberToReserve.TabIndex = 1;
            this.lblNumberToReserve.Text = "Number of seats to reserve:";
            // 
            // grpBoxGetSeats
            // 
            this.grpBoxGetSeats.Controls.Add(this.txtBoxFreeSeats);
            this.grpBoxGetSeats.Controls.Add(this.lblFreeSeatsOnFlight);
            this.grpBoxGetSeats.Controls.Add(this.btnSerilazable);
            this.grpBoxGetSeats.Controls.Add(this.btnReadUncommited);
            this.grpBoxGetSeats.Controls.Add(this.lblGetSeatsMethod);
            this.grpBoxGetSeats.Location = new System.Drawing.Point(6, 37);
            this.grpBoxGetSeats.Name = "grpBoxGetSeats";
            this.grpBoxGetSeats.Size = new System.Drawing.Size(430, 175);
            this.grpBoxGetSeats.TabIndex = 0;
            this.grpBoxGetSeats.TabStop = false;
            this.grpBoxGetSeats.Text = "Get seats:";
            // 
            // txtBoxFreeSeats
            // 
            this.txtBoxFreeSeats.Location = new System.Drawing.Point(268, 124);
            this.txtBoxFreeSeats.Name = "txtBoxFreeSeats";
            this.txtBoxFreeSeats.ReadOnly = true;
            this.txtBoxFreeSeats.Size = new System.Drawing.Size(100, 23);
            this.txtBoxFreeSeats.TabIndex = 4;
            // 
            // lblFreeSeatsOnFlight
            // 
            this.lblFreeSeatsOnFlight.AutoSize = true;
            this.lblFreeSeatsOnFlight.Location = new System.Drawing.Point(6, 127);
            this.lblFreeSeatsOnFlight.Name = "lblFreeSeatsOnFlight";
            this.lblFreeSeatsOnFlight.Size = new System.Drawing.Size(145, 15);
            this.lblFreeSeatsOnFlight.TabIndex = 3;
            this.lblFreeSeatsOnFlight.Text = "Free seats on the flightNo:";
            // 
            // btnSerilazable
            // 
            this.btnSerilazable.Location = new System.Drawing.Point(293, 75);
            this.btnSerilazable.Name = "btnSerilazable";
            this.btnSerilazable.Size = new System.Drawing.Size(75, 23);
            this.btnSerilazable.TabIndex = 2;
            this.btnSerilazable.Text = "Serilazable";
            this.btnSerilazable.UseVisualStyleBackColor = true;
            this.btnSerilazable.Click += new System.EventHandler(this.btnSerilazable_Click);
            // 
            // btnReadUncommited
            // 
            this.btnReadUncommited.Location = new System.Drawing.Point(6, 75);
            this.btnReadUncommited.Name = "btnReadUncommited";
            this.btnReadUncommited.Size = new System.Drawing.Size(124, 23);
            this.btnReadUncommited.TabIndex = 1;
            this.btnReadUncommited.Text = "Read Uncommited";
            this.btnReadUncommited.UseVisualStyleBackColor = true;
            this.btnReadUncommited.Click += new System.EventHandler(this.btnReadUncommited_Click);
            // 
            // lblGetSeatsMethod
            // 
            this.lblGetSeatsMethod.AutoSize = true;
            this.lblGetSeatsMethod.Location = new System.Drawing.Point(6, 33);
            this.lblGetSeatsMethod.Name = "lblGetSeatsMethod";
            this.lblGetSeatsMethod.Size = new System.Drawing.Size(167, 15);
            this.lblGetSeatsMethod.TabIndex = 0;
            this.lblGetSeatsMethod.Text = "Get available seats by method:";
            // 
            // lblFeedbackServer
            // 
            this.lblFeedbackServer.AutoSize = true;
            this.lblFeedbackServer.Location = new System.Drawing.Point(23, 476);
            this.lblFeedbackServer.Name = "lblFeedbackServer";
            this.lblFeedbackServer.Size = new System.Drawing.Size(123, 15);
            this.lblFeedbackServer.TabIndex = 3;
            this.lblFeedbackServer.Text = "Feedback from server:";
            // 
            // txtBoxFeedbackServer
            // 
            this.txtBoxFeedbackServer.Location = new System.Drawing.Point(285, 473);
            this.txtBoxFeedbackServer.Name = "txtBoxFeedbackServer";
            this.txtBoxFeedbackServer.ReadOnly = true;
            this.txtBoxFeedbackServer.Size = new System.Drawing.Size(100, 23);
            this.txtBoxFeedbackServer.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 562);
            this.Controls.Add(this.txtBoxFeedbackServer);
            this.Controls.Add(this.lblFeedbackServer);
            this.Controls.Add(this.grpBoxTransaction);
            this.Controls.Add(this.cmbBoxPickFlightNo);
            this.Controls.Add(this.lblSpecifyFlight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxTransaction.ResumeLayout(false);
            this.grpBoxTransaction.PerformLayout();
            this.grpBoxGetSeats.ResumeLayout(false);
            this.grpBoxGetSeats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpecifyFlight;
        private System.Windows.Forms.ComboBox cmbBoxPickFlightNo;
        private System.Windows.Forms.GroupBox grpBoxTransaction;
        private System.Windows.Forms.GroupBox grpBoxGetSeats;
        private System.Windows.Forms.Button btnSerilazable;
        private System.Windows.Forms.Button btnReadUncommited;
        private System.Windows.Forms.Label lblGetSeatsMethod;
        private System.Windows.Forms.Label lblFreeSeatsOnFlight;
        private System.Windows.Forms.TextBox txtBoxFreeSeats;
        private System.Windows.Forms.Label lblNumberToReserve;
        private System.Windows.Forms.TextBox txtBoxSeatsToReserve;
        private System.Windows.Forms.Button btnReserveSeats;
        private System.Windows.Forms.Label lblFeedbackServer;
        private System.Windows.Forms.TextBox txtBoxFeedbackServer;
    }
}
