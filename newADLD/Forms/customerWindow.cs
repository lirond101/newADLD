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
    public partial class customerWindow : Form
    {
        ServiceLayer customer_sl = new ServiceLayer();
        string userName = "";
        

        public customerWindow(string UserName)
        {
            InitializeComponent();
            userName = UserName;
            try
            {
                List<City> Allcities = customer_sl.getAllCities();
                foreach (City c in Allcities)
                    cmb_Location.Items.Add(c.name);
                cmb_Category.SelectedIndex = -1;
                cmb_Location.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Category.SelectedIndex == -1 && cmb_Location.SelectedIndex == -1)
                    return;
                Dictionary<int, Coupon> d_Coupon = new Dictionary<int, Coupon>();
                if (cmb_Category.SelectedIndex != -1 && cmb_Location.SelectedIndex != -1)
                    d_Coupon = customer_sl.searchByPrefrenceAndLocation(cmb_Location.SelectedItem.ToString(), cmb_Category.SelectedIndex + 1);
                else if (cmb_Category.SelectedIndex != -1)
                    d_Coupon = customer_sl.searchByPrefrence(cmb_Category.SelectedIndex + 1);
                else
                    d_Coupon = customer_sl.SearchByCity(cmb_Location.SelectedItem.ToString());
                OrderCoupon oc = new OrderCoupon(d_Coupon, this.userName);
                oc.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmb_Category.SelectedIndex = -1;
            cmb_Location.SelectedIndex = -1;
        }

        private void customerWindow_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<Deal> deals = customer_sl.AllDealsByCustomer(this.userName);
                ViewDeals vc = new ViewDeals(deals);
                vc.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                List<Deal> deals = customer_sl.AllDealsByCustomer(this.userName);
                List<Deal> UnpayedDeals = new List<Deal>();
                foreach (Deal d in deals)
                {
                    if (d.Status() == "Ordered")
                        UnpayedDeals.Add(d);
                }
                if (UnpayedDeals.Count == 0)
                {
                    MessageBox.Show("No Deals To Pay");
                    return;
                }
                ViewDeals vd = new ViewDeals(UnpayedDeals);
                vd.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
