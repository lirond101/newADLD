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
    public partial class AddCoupon : Form
    {
        string storeID;

        public AddCoupon(string storeID)
        {
            InitializeComponent();
            this.storeID = storeID;
            if (storeID == null || storeID != "")
            {
                txt_storeID.Text = storeID;
                txt_storeID.Enabled = false;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            double originalPrice = 0;
            double discountPrice = 0;
            int daysValid = 0;
            if (!double.TryParse(txt_Original.Text, out originalPrice)  ||
                !double.TryParse(txt_Discount.Text, out discountPrice) ||
                !int.TryParse(txt_daysValid.Text, out daysValid))
            {
                MessageBox.Show("Wrong input!");
                return;
            }
            if (originalPrice <= discountPrice)
            {
                MessageBox.Show("Discount price can't be larger than original price");
                return;
            }
            if (dtp_deadLine.Value < DateTime.Today)
            {
                MessageBox.Show("Can't be past deadline date");
                return;
            }
            try
            {
                ServiceLayer sl = new ServiceLayer();
                sl.addCoupon(txt_name.Text, txt_desc.Text, txt_storeID.Text, originalPrice, discountPrice, dtp_deadLine.Value, daysValid);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void AddCoupon_Load(object sender, EventArgs e)
        {

        }
    }
}
