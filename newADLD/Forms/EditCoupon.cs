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
    public partial class EditCoupon : Form
    {
        ServiceLayer sl = new ServiceLayer();
        int couponID;

        public EditCoupon()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            try
            {
                couponID = 0;
                if (!int.TryParse(txt_couponID.Text, out couponID))
                {
                    MessageBox.Show("Coupon ID must be an integer");
                    return;
                }
                Coupon c = sl.getCoupon(couponID);
                txt_daysValid.Text = c.daysValid.ToString();
                txt_desc.Text = c.Description;
                txt_storeID.Text = c.Store;
                txt_Discount.Text = c.discountPrice.ToString();
                txt_Original.Text = c.originalPrice.ToString();
                dtp_deadLine.Value = c.deadline;
                txt_name.Text = c.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            double originalPrice = 0;
            double discountPrice = 0;
            int daysValid = 0;
            if (!double.TryParse(txt_Original.Text, out originalPrice) ||
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
                sl.editCoupon(couponID, txt_name.Text, dtp_deadLine.Value, txt_desc.Text, txt_storeID.Text, originalPrice, discountPrice, daysValid);
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
    }
}

