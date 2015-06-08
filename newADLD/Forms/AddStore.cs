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
    public partial class AddStore : Form
    {

        ServiceLayer sl;

        public AddStore()
        {
            InitializeComponent();
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
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            { 
                sl.addStore(txt_storeID.Text, txt_Name.Text, txt_desc.Text, txt_address.Text, cmb_pref.SelectedIndex + 1, cmb_cities.SelectedItem.ToString(), txt_Phone.Text, txt_OwnerID.Text); 
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);}
            finally { this.Close(); }
        }

        private void AddStore_Load(object sender, EventArgs e)
        {

        }
    }
}
