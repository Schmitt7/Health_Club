
namespace Health_Club
{
    partial class HealthClub
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
            this.gbMemberType = new System.Windows.Forms.GroupBox();
            this.rbSenior = new System.Windows.Forms.RadioButton();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.rbChild = new System.Windows.Forms.RadioButton();
            this.rbAdult = new System.Windows.Forms.RadioButton();
            this.gnOptions = new System.Windows.Forms.GroupBox();
            this.cbTrainer = new System.Windows.Forms.CheckBox();
            this.cbKarate = new System.Windows.Forms.CheckBox();
            this.cbYoga = new System.Windows.Forms.CheckBox();
            this.gbLength = new System.Windows.Forms.GroupBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.lblMonthAmt = new System.Windows.Forms.Label();
            this.gbFee = new System.Windows.Forms.GroupBox();
            this.lblTotalDisplay = new System.Windows.Forms.Label();
            this.lblFeeDisplay = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbMemberType.SuspendLayout();
            this.gnOptions.SuspendLayout();
            this.gbLength.SuspendLayout();
            this.gbFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMemberType
            // 
            this.gbMemberType.Controls.Add(this.rbSenior);
            this.gbMemberType.Controls.Add(this.rbStudent);
            this.gbMemberType.Controls.Add(this.rbChild);
            this.gbMemberType.Controls.Add(this.rbAdult);
            this.gbMemberType.Location = new System.Drawing.Point(65, 44);
            this.gbMemberType.Name = "gbMemberType";
            this.gbMemberType.Size = new System.Drawing.Size(370, 276);
            this.gbMemberType.TabIndex = 0;
            this.gbMemberType.TabStop = false;
            this.gbMemberType.Text = "Membership Type";
            // 
            // rbSenior
            // 
            this.rbSenior.AutoSize = true;
            this.rbSenior.Location = new System.Drawing.Point(7, 209);
            this.rbSenior.Name = "rbSenior";
            this.rbSenior.Size = new System.Drawing.Size(233, 29);
            this.rbSenior.TabIndex = 3;
            this.rbSenior.TabStop = true;
            this.rbSenior.Tag = "30";
            this.rbSenior.Text = "Senior Citizen (65+)";
            this.rbSenior.UseVisualStyleBackColor = true;
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Location = new System.Drawing.Point(6, 161);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(117, 29);
            this.rbStudent.TabIndex = 2;
            this.rbStudent.TabStop = true;
            this.rbStudent.Tag = "25";
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = true;
            // 
            // rbChild
            // 
            this.rbChild.AutoSize = true;
            this.rbChild.Location = new System.Drawing.Point(6, 108);
            this.rbChild.Name = "rbChild";
            this.rbChild.Size = new System.Drawing.Size(239, 29);
            this.rbChild.TabIndex = 1;
            this.rbChild.TabStop = true;
            this.rbChild.Tag = "20";
            this.rbChild.Text = "Child (12 and under)";
            this.rbChild.UseVisualStyleBackColor = true;
            
            // 
            // rbAdult
            // 
            this.rbAdult.AutoSize = true;
            this.rbAdult.Location = new System.Drawing.Point(7, 57);
            this.rbAdult.Name = "rbAdult";
            this.rbAdult.Size = new System.Drawing.Size(185, 29);
            this.rbAdult.TabIndex = 0;
            this.rbAdult.TabStop = true;
            this.rbAdult.Tag = "40";
            this.rbAdult.Text = "Standard Adult";
            this.rbAdult.UseVisualStyleBackColor = true;
            // 
            // gnOptions
            // 
            this.gnOptions.Controls.Add(this.cbTrainer);
            this.gnOptions.Controls.Add(this.cbKarate);
            this.gnOptions.Controls.Add(this.cbYoga);
            this.gnOptions.Location = new System.Drawing.Point(762, 44);
            this.gnOptions.Name = "gnOptions";
            this.gnOptions.Size = new System.Drawing.Size(413, 276);
            this.gnOptions.TabIndex = 1;
            this.gnOptions.TabStop = false;
            this.gnOptions.Text = "Options";
            // 
            // cbTrainer
            // 
            this.cbTrainer.AutoSize = true;
            this.cbTrainer.Location = new System.Drawing.Point(25, 161);
            this.cbTrainer.Name = "cbTrainer";
            this.cbTrainer.Size = new System.Drawing.Size(203, 29);
            this.cbTrainer.TabIndex = 2;
            this.cbTrainer.Tag = "50";
            this.cbTrainer.Text = "Personal Trainer";
            this.cbTrainer.UseVisualStyleBackColor = true;
            // 
            // cbKarate
            // 
            this.cbKarate.AutoSize = true;
            this.cbKarate.Location = new System.Drawing.Point(25, 108);
            this.cbKarate.Name = "cbKarate";
            this.cbKarate.Size = new System.Drawing.Size(107, 29);
            this.cbKarate.TabIndex = 1;
            this.cbKarate.Tag = "30";
            this.cbKarate.Text = "Karate";
            this.cbKarate.UseVisualStyleBackColor = true;
            // 
            // cbYoga
            // 
            this.cbYoga.AutoSize = true;
            this.cbYoga.Location = new System.Drawing.Point(25, 57);
            this.cbYoga.Name = "cbYoga";
            this.cbYoga.Size = new System.Drawing.Size(95, 29);
            this.cbYoga.TabIndex = 0;
            this.cbYoga.Tag = "10";
            this.cbYoga.Text = "Yoga";
            this.cbYoga.UseVisualStyleBackColor = true;
            // 
            // gbLength
            // 
            this.gbLength.Controls.Add(this.txtMonths);
            this.gbLength.Controls.Add(this.lblMonthAmt);
            this.gbLength.Location = new System.Drawing.Point(65, 360);
            this.gbLength.Name = "gbLength";
            this.gbLength.Size = new System.Drawing.Size(370, 210);
            this.gbLength.TabIndex = 2;
            this.gbLength.TabStop = false;
            this.gbLength.Text = "Membership Length";
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(50, 115);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(246, 31);
            this.txtMonths.TabIndex = 1;
            // 
            // lblMonthAmt
            // 
            this.lblMonthAmt.AutoSize = true;
            this.lblMonthAmt.Location = new System.Drawing.Point(45, 61);
            this.lblMonthAmt.Name = "lblMonthAmt";
            this.lblMonthAmt.Size = new System.Drawing.Size(251, 25);
            this.lblMonthAmt.TabIndex = 0;
            this.lblMonthAmt.Text = "Enter Number of Months:";
            // 
            // gbFee
            // 
            this.gbFee.Controls.Add(this.lblTotalDisplay);
            this.gbFee.Controls.Add(this.lblFeeDisplay);
            this.gbFee.Controls.Add(this.lblTotal);
            this.gbFee.Controls.Add(this.lblFee);
            this.gbFee.Location = new System.Drawing.Point(762, 360);
            this.gbFee.Name = "gbFee";
            this.gbFee.Size = new System.Drawing.Size(413, 210);
            this.gbFee.TabIndex = 3;
            this.gbFee.TabStop = false;
            this.gbFee.Text = "Membership Fees";
            // 
            // lblTotalDisplay
            // 
            this.lblTotalDisplay.AutoSize = true;
            this.lblTotalDisplay.Location = new System.Drawing.Point(239, 118);
            this.lblTotalDisplay.Name = "lblTotalDisplay";
            this.lblTotalDisplay.Size = new System.Drawing.Size(24, 25);
            this.lblTotalDisplay.TabIndex = 3;
            this.lblTotalDisplay.Text = "0";
            // 
            // lblFeeDisplay
            // 
            this.lblFeeDisplay.AutoSize = true;
            this.lblFeeDisplay.Location = new System.Drawing.Point(239, 60);
            this.lblFeeDisplay.Name = "lblFeeDisplay";
            this.lblFeeDisplay.Size = new System.Drawing.Size(24, 25);
            this.lblFeeDisplay.TabIndex = 2;
            this.lblFeeDisplay.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(25, 120);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 25);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(25, 60);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(137, 25);
            this.lblFee.TabIndex = 0;
            this.lblFee.Text = "Monthly Fee:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(173, 623);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(151, 62);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(531, 623);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 62);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(901, 623);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 62);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // HealthClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 729);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.gbFee);
            this.Controls.Add(this.gbLength);
            this.Controls.Add(this.gnOptions);
            this.Controls.Add(this.gbMemberType);
            this.Name = "HealthClub";
            this.Text = "Form1";
            this.gbMemberType.ResumeLayout(false);
            this.gbMemberType.PerformLayout();
            this.gnOptions.ResumeLayout(false);
            this.gnOptions.PerformLayout();
            this.gbLength.ResumeLayout(false);
            this.gbLength.PerformLayout();
            this.gbFee.ResumeLayout(false);
            this.gbFee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMemberType;
        private System.Windows.Forms.RadioButton rbSenior;
        private System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.RadioButton rbChild;
        private System.Windows.Forms.RadioButton rbAdult;
        private System.Windows.Forms.GroupBox gnOptions;
        private System.Windows.Forms.CheckBox cbTrainer;
        private System.Windows.Forms.CheckBox cbKarate;
        private System.Windows.Forms.CheckBox cbYoga;
        private System.Windows.Forms.GroupBox gbLength;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.Label lblMonthAmt;
        private System.Windows.Forms.GroupBox gbFee;
        private System.Windows.Forms.Label lblTotalDisplay;
        private System.Windows.Forms.Label lblFeeDisplay;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

