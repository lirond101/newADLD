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
    public partial class ViewCoupons : Form
    {
        List<Coupon> allCoupons;
        public ViewCoupons(List<Coupon> coupons)
        {
            InitializeComponent();
            allCoupons = coupons;
        }

        private void ViewCoupons_Load(object sender, EventArgs e)
        {
            lstview_AllCoupons.View = View.Details;
            lstview_AllCoupons.Columns.Add("Code");
            lstview_AllCoupons.Columns.Add("Name");
            lstview_AllCoupons.Columns.Add("Store");
            lstview_AllCoupons.Columns.Add("Price");
            lstview_AllCoupons.Columns.Add("Discount");
            lstview_AllCoupons.Columns.Add("Catagory");
            lstview_AllCoupons.Columns.Add("Deadline");
            lstview_AllCoupons.Columns.Add("Days Valid");
            lstview_AllCoupons.Columns.Add("Rank");
            lstview_AllCoupons.Columns.Add("NumberOfRanks");

            foreach (ColumnHeader c in lstview_AllCoupons.Columns)
            {
                c.Width = lstview_AllCoupons.Width / lstview_AllCoupons.Columns.Count;
            }
            updateList();
        }

        private void updateList()
        {
            foreach (Coupon c in allCoupons)
            {
                ListViewItem newItem = new ListViewItem(c.Code + "");

                newItem.SubItems.Add(c.Name);
                newItem.SubItems.Add(c.Store);
                newItem.SubItems.Add(c.originalPrice + "");
                newItem.SubItems.Add(c.discountPrice + "");
                newItem.SubItems.Add(c.getPrefrence());
                newItem.SubItems.Add(c.deadline.ToString("yyyy-MM-dd"));
                newItem.SubItems.Add(c.daysValid.ToString());
                newItem.SubItems.Add(c.couponRank + "");
                newItem.SubItems.Add(c.numOfRanks + "");
                lstview_AllCoupons.Items.Add(newItem);
            }
        }

        private void lstview_AllCoupons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
