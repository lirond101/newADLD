using CouponsSystems.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CouponsSystems
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addAdmin_Click(object sender, EventArgs e)
        {
            AddAdmin addWindow = new AddAdmin();
            addWindow.Show();
        }

        private void btn_addStore_Click(object sender, EventArgs e)
        {
            AddStore addStore = new AddStore();
            addStore.Show();
        }

        private void btn_addStoreOwner_Click(object sender, EventArgs e)
        {
            AddStoreOwner aso = new AddStoreOwner();
            aso.Show();
        }

        private void btn_addCoupon_Click(object sender, EventArgs e)
        {
            AddCoupon addCoupon = new AddCoupon("");
            addCoupon.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditCoupon editCoupon = new EditCoupon();
            editCoupon.Show();
        }

        private void btn_delStore_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete store?", "Delete", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
                return;
            string storeID = txt_storeID.Text;
            try
            {
                ServiceLayer sl = new ServiceLayer();
                sl.deleteStore(storeID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delCoupon_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete coupon?", "Delete", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
                return;
            int couponID = 0;
            if (!int.TryParse(txt_couponID.Text, out couponID))
            {
                MessageBox.Show("Coupon ID is an integer");
                return;
            }
            try
            {
                ServiceLayer sl = new ServiceLayer();
                sl.deleteCoupon(couponID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
            ApproveCoupon approveCoupon = new ApproveCoupon();
            approveCoupon.Show();
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
