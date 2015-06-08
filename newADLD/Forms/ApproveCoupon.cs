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
    public partial class ApproveCoupon : Form
    {

        ServiceLayer sl = new ServiceLayer();
        public ApproveCoupon()
        {
            InitializeComponent();
        }

        private void ApproveCoupon_Load(object sender, EventArgs e)
        {
            lstview_AllCoupons.View = View.Details;
            lstview_AllCoupons.Columns.Add("Code");
            lstview_AllCoupons.Columns.Add("Name");
            lstview_AllCoupons.Columns.Add("Store");
            lstview_AllCoupons.Columns.Add("Price");
            lstview_AllCoupons.Columns.Add("Discount");
            lstview_AllCoupons.Columns.Add("Deadline");
            lstview_AllCoupons.Columns.Add("Days Valid");
            foreach (ColumnHeader c in lstview_AllCoupons.Columns)
            {
                c.Width = lstview_AllCoupons.Width / lstview_AllCoupons.Columns.Count;
            }
            updateList();
        }

        private void updateList()
        {
            Dictionary<int, Coupon> toApprove =  sl.getAllUnapprovedCoupons();
            //Dictionary<int, Coupon> toApprove = sl.getAllApprovedCouponsByCatagory(3);
            foreach (Coupon c in toApprove.Values)
            {
                ListViewItem newItem = new ListViewItem(c.Code + "");
                newItem.SubItems.Add(c.Name);
                newItem.SubItems.Add(c.Store);
                newItem.SubItems.Add(c.originalPrice + "");
                newItem.SubItems.Add(c.discountPrice + "");
                newItem.SubItems.Add(c.deadline.ToString("yyyy-MM-dd"));
                newItem.SubItems.Add(c.daysValid.ToString());
                lstview_AllCoupons.Items.Add(newItem);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstview_AllCoupons.SelectedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem i in lstview_AllCoupons.SelectedItems)
                    {
                        int code = 0;
                        int.TryParse(i.SubItems[0].Text, out code);
                        sl.approveCoupon(code);
                        lstview_AllCoupons.Items.Remove(i);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); 
                }
            }
        }

        private void lstview_AllCoupons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
