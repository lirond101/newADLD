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
    public partial class EditStore : Form
    {
        Store thisStore;
        ServiceLayer sl = new ServiceLayer();

        public EditStore(Store thisStore)
        {
            InitializeComponent();
            this.thisStore = thisStore;
            try
            {
                sl = new ServiceLayer();
                List<City> Allcities = sl.getAllCities();
                foreach (City c in Allcities)
                    cmb_cities.Items.Add(c.name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditStore_Load(object sender, EventArgs e)
        {
            txt_storeID.Text = thisStore.storeID;
            txt_address.Text = thisStore.address;
            txt_desc.Text = thisStore.description;
            txt_Name.Text = thisStore.name;
            txt_Phone.Text = thisStore.phoneNum;
            cmb_pref.SelectedIndex = thisStore.catagory - 1;
            for (int i = 0; i < cmb_cities.Items.Count; i++)
            {
                if (cmb_cities.Items[i].ToString() == thisStore.city)
                {
                    cmb_cities.SelectedIndex = i;
                    break;
                }
            }

            
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                sl.editStore(thisStore.storeID, txt_Name.Text, txt_desc.Text, cmb_pref.SelectedIndex + 1, txt_address.Text, cmb_cities.SelectedItem.ToString(), txt_Phone.Text, "");
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
