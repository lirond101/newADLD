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
    public partial class StoreOwnerWindow : Form
    {
        ServiceLayer sl = new ServiceLayer();
        string ownerID;
        List<Store> allStores = null;
        Store thisStore;

        public StoreOwnerWindow(string ID)
        {
            InitializeComponent();
            ownerID = ID;
        }

        private void StoreOwnerWindow_Load(object sender, EventArgs e)
        {
            try
            {
                updateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateList()
        {
            cmb_AllStores.Items.Clear();
            allStores = sl.getAllStoresByOwner(ownerID).Values.ToList();
            foreach (Store s in allStores)
                cmb_AllStores.Items.Add(s.storeID + " (" + s.name + ")");
        }

        private void cmb_AllStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_AllStores.SelectedItem.ToString() == null || cmb_AllStores.SelectedItem.ToString() == "")
                return;
            try
            {
                changeText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changeText()
        {
            string storeid = cmb_AllStores.SelectedItem.ToString().Split('(')[0].Trim();
            thisStore = sl.getStoreByID(storeid);
            txt_address.Text = thisStore.address;
            int cat = thisStore.catagory;
            if (cat == 1)
                txt_catagory.Text = "Restaraunt";
            else if (cat == 2)
                txt_catagory.Text = "Fun";
            else if (cat == 3)
                txt_catagory.Text = "Shopping";
            else
                txt_catagory.Text = "Sports";
            txt_city.Text = thisStore.city;
            txt_desc.Text = thisStore.description;
            txt_name.Text = thisStore.name;
            txt_storeID.Text = thisStore.storeID;
            txt_storeRank.Text = thisStore.rank.ToString();


        }
        private void button2_Click(object sender, EventArgs e)
        {
                AddCoupon addCoupons = new AddCoupon(txt_storeID.Text);
                addCoupons.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_serialKey.Text == "" || cmb_AllStores.Text == "")
                    return;
                DialogResult dr = MessageBox.Show("Are you sure?", "Approve", MessageBoxButtons.YesNo);
                Deal d = sl.getDealBySerialKey(txt_serialKey.Text);
                if (d.store != txt_storeID.Text)
                {
                    MessageBox.Show("Serial Key does not exist!");
                    return;
                }
                sl.setCouponDealToUsed(txt_serialKey.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (thisStore == null)
                return;
            EditStore editStore = new EditStore(thisStore);
            editStore.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmb_AllStores.Items.Clear();
            updateList();
            txt_city.Text = "";
            txt_desc.Text = "";
            txt_name.Text = "";
            txt_storeID.Text = "";
            txt_storeRank.Text = "";
            txt_catagory.Text = "";
            txt_address.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                List<Coupon> allCoupons = sl.getAllCouponsByStore(txt_storeID.Text);
                ViewCoupons vc = new ViewCoupons(allCoupons);
                vc.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
