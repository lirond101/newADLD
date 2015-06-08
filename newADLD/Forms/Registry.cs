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
    public partial class RegistryWindow : Form
    {
        ServiceLayer sl = new ServiceLayer();

        public RegistryWindow()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<City> Allcities = sl.getAllCities();
            foreach (City c in Allcities)
                cmb_city.Items.Add(c.name);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                sl.addCustomer(txt_un.Text, txt_pass.Text, txt_fname.Text, txt_lname.Text, cmb_city.SelectedItem.ToString(), txt_email.Text, dtp_dob.Value, txt_adrdress.Text, txt_phone.Text, cmb_pref.SelectedIndex + 1);
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

        private void cmb_city_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_pref_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
