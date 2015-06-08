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
    public partial class AddStoreOwner : Form
    {

        ServiceLayer sl = new ServiceLayer();

        public AddStoreOwner()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {

                sl.addStoreOwner(txt_un.Text, txt_pass.Text, txt_fname.Text, txt_lname.Text, txt_email.Text, txt_phone.Text);
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

        private void AddStoreOwner_Load(object sender, EventArgs e)
        {

        }
    }
}
