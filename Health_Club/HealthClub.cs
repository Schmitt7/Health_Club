using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Club
{
    public partial class HealthClub : Form
    {

        public HealthClub()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMonths.Text = String.Empty;
            
            cbYoga.Checked = false;
            cbKarate.Checked = false;
            cbTrainer.Checked = false;

            rbAdult.Checked = false;
            rbChild.Checked = false;
            rbSenior.Checked = false;
            rbStudent.Checked = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal OptionFee = 0;
            decimal BaseFee = 0;

            int Months = Convert.ToInt16(txtMonths.Text);

            if (rbAdult.Checked)
            {
                BaseFee = Convert.ToDecimal(rbAdult.Tag);
            }
            else if (rbChild.Checked)
            {
                BaseFee = Convert.ToDecimal(rbChild.Tag);
            }
            else if (rbStudent.Checked) {
                BaseFee = Convert.ToDecimal(rbStudent.Tag);
            }
            else if(rbSenior.Checked){
                BaseFee = Convert.ToDecimal(rbSenior.Tag);
            }

            if (cbYoga.Checked) {
                OptionFee = (OptionFee + Convert.ToDecimal(cbYoga.Tag));
            }
            if (cbKarate.Checked) {
                OptionFee = (OptionFee + Convert.ToDecimal(cbKarate.Tag));
            }
            if (cbTrainer.Checked) {
                OptionFee = (OptionFee + Convert.ToDecimal(cbTrainer.Tag));
            }

            decimal MonthlyFee = (BaseFee + OptionFee);
            lblFeeDisplay.Text = MonthlyFee.ToString("c");

            decimal Total = (BaseFee + OptionFee) * Months;
            lblTotalDisplay.Text = Total.ToString("c");
        }

        
    }
}
