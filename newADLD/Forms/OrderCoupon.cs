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
    public partial class OrderCoupon : Form
    {
        ServiceLayer order_sl = new ServiceLayer();
        string userName; 
        public OrderCoupon(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }
        
        public OrderCoupon(Dictionary<int, Coupon> dictionary, string userName)
        {
            InitializeComponent();
            this.userName = userName;
            // TODO: Complete member initialization
            lst_Coupons.View = View.Details;
            lst_Coupons.Columns.Add("Code");
            lst_Coupons.Columns.Add("Name");
            lst_Coupons.Columns.Add("Catagory");
            lst_Coupons.Columns.Add("Description");
            lst_Coupons.Columns.Add("Original price");
            lst_Coupons.Columns.Add("Discount price");
            lst_Coupons.Columns.Add("Days valid");
            lst_Coupons.Columns.Add("rank");
            lst_Coupons.Columns.Add("Number of Rankers");
            lst_Coupons.Columns.Add("Store");
            lst_Coupons.Columns.Add("City");

            foreach (ColumnHeader c in lst_Coupons.Columns)
            {
                c.Width = lst_Coupons.Width / lst_Coupons.Columns.Count;
            }
                
            foreach (KeyValuePair<int, Coupon> kvp in dictionary)
            {
                ListViewItem l_cDetails = new ListViewItem(kvp.Value.Code.ToString());
                l_cDetails.SubItems.Add(kvp.Value.Name);
                l_cDetails.SubItems.Add(kvp.Value.getPrefrence());
                l_cDetails.SubItems.Add(kvp.Value.Description);
                l_cDetails.SubItems.Add(kvp.Value.originalPrice.ToString());
                l_cDetails.SubItems.Add(kvp.Value.discountPrice.ToString());
                l_cDetails.SubItems.Add(kvp.Value.daysValid.ToString());
                l_cDetails.SubItems.Add(kvp.Value.couponRank.ToString());
                l_cDetails.SubItems.Add(kvp.Value.numOfRanks.ToString());
                l_cDetails.SubItems.Add(kvp.Value.Store);
                l_cDetails.SubItems.Add(kvp.Value.city);
                lst_Coupons.Items.Add(l_cDetails);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_Coupons.SelectedItems.Count > 0)
                {
                    ListViewItem selectedCoupoun = lst_Coupons.SelectedItems[0];
                    //get the selected coupon
                    int couponCode = Convert.ToInt32(selectedCoupoun.SubItems[0].Text);
                    string serialKey = GenerateSerial();
                    order_sl.addDeal(DateTime.Now, serialKey, couponCode, userName);
                    PaymentWindow pw = new PaymentWindow(serialKey);
                    pw.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GenerateSerial()
        {
            string s = "abcdefghijklmnopqrstuvwxyz0123456789";
            int l = s.Length;
            Random r = new Random();
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < 10; j++)
            {
                sb.Append(s[r.Next(l)]);
            }
            return sb.ToString();
        }
        private void OrderCoupon_Load(object sender, EventArgs e)
        {

        }

        private void lst_Coupons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
