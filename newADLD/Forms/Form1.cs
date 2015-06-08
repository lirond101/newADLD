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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceLayer sl = new ServiceLayer();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string usertype = sl.login(usernameText.Text, passwordText.Text);
                if (usertype == "Customer")
                {
                    customerWindow cw = new customerWindow(usernameText.Text);
                    cw.Show();
                    disableAll();
                }
                else if (usertype == "Administrator")
                {
                    AdminWindow aw = new AdminWindow();
                    aw.Show();
                    disableAll();
                }
                else if (usertype == "Store Owner")
                {
                    StoreOwnerWindow sow = new StoreOwnerWindow(usernameText.Text);
                    sow.Show();
                    disableAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryWindow rw = new RegistryWindow();
            rw.Show();
        }

        private void disableAll()
        {
            usernameText.Enabled = false;
            passwordText.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void enableAll()
        {
            usernameText.Enabled = true;
            passwordText.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enableAll();
            usernameText.Text = "";
            passwordText.Text = "";
        }
    }
}
