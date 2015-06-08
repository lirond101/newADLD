using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CouponsSystems.Forms
{
    public partial class PaymentWindow : Form
    {

        string serialKey;

        public PaymentWindow(string serialKey)
        {
            InitializeComponent();
            this.serialKey = serialKey;
            rbt_PayPal.Checked = true;
        }

        private void rbt_MasterCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_MasterCard.Checked == true || rbt_Visa.Checked == true)
                textBox1.Enabled = true;
            else
                textBox1.Enabled = false;
        }

        private void rbt_PayPal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_PayPal.Checked == true)
                textBox1.Enabled = false;
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceLayer sl = new ServiceLayer();
                sl.setCouponDealToPayed(this.serialKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Payment Approved \nSerial Key: " + this.serialKey);
            this.Close();
            
        }

        private void rbt_Visa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_MasterCard.Checked == true || rbt_Visa.Checked == true)
                textBox1.Enabled = true;
            else
                textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
