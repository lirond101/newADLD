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
    public partial class ViewDeals : Form
    {
        List<Deal> allDeals;

        public ViewDeals(List<Deal> allDeals)
        {
            InitializeComponent();
            this.allDeals = allDeals;
        }

        private void ViewDeals_Load(object sender, EventArgs e)
        {
            lstview_AllDeals.View = View.Details;
            lstview_AllDeals.Columns.Add("Purchase Code");
            lstview_AllDeals.Columns.Add("Status");
            lstview_AllDeals.Columns.Add("Serial Key");
            lstview_AllDeals.Columns.Add("Store");
            lstview_AllDeals.Columns.Add("Order Date");
            lstview_AllDeals.Columns.Add("Coupon Code");
            lstview_AllDeals.Columns.Add("Name");
            lstview_AllDeals.Columns.Add("Price");
            lstview_AllDeals.Columns.Add("Days To Use");

            foreach (ColumnHeader c in lstview_AllDeals.Columns)
            {
                c.Width = lstview_AllDeals.Width / lstview_AllDeals.Columns.Count;
            }
            comboBox1.Enabled = false;
            comboBox1.SelectedIndex = -1;
            comboBox1.Enabled = false;
            button2.Enabled = false;
            updateList();
        }

        private void updateList()
        {
            foreach (Deal d in allDeals)
            {
                ListViewItem newItem = new ListViewItem(d.purchaseCode + "");
                newItem.SubItems.Add(d.Status());
                string serial = "";
                if (d.status == 1)
                    serial = "";
                else
                    serial = d.serialKey;
                newItem.SubItems.Add(serial);
                newItem.SubItems.Add(d.store);
                newItem.SubItems.Add(d.orderDate.ToString("yyyy-MM-dd"));
                newItem.SubItems.Add(d.CouponCode + "");
                newItem.SubItems.Add(d.name);
                newItem.SubItems.Add(d.price + "");
                newItem.SubItems.Add(d.daysToUse + "");
                lstview_AllDeals.Items.Add(newItem);
            }
        }

        private void lstview_AllDeals_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (lstview_AllDeals.SelectedItems.Count == 0)
                    return;
                else
                {

                    ServiceLayer sl = new ServiceLayer();
                    ListViewItem selected = lstview_AllDeals.SelectedItems[0];
                    string purchaseCode = selected.SubItems[0].Text;
                    int code = 0;
                    int.TryParse(purchaseCode, out code);
                    Deal current = sl.getDealByPurchaseCode(code);
                    if (current.Status() == "Ordered")
                        button1.Enabled = true;
                    else
                        button1.Enabled = false;
                    if (current.userRank != 0 || current.Status() == "Ordered")
                    {
                        comboBox1.Enabled = false;
                        button2.Enabled = false;
                    }
                    else
                    {
                        comboBox1.Enabled = true;
                        button2.Enabled = true;
                    }
                    
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstview_AllDeals.SelectedItems.Count == 0)
                    return;
                else
                {
                    ServiceLayer sl = new ServiceLayer();
                    ListViewItem selected = lstview_AllDeals.SelectedItems[0];
                    string purchaseCode = selected.SubItems[0].Text;
                    int code = 0;
                    int.TryParse(purchaseCode, out code);
                    Deal current = sl.getDealByPurchaseCode(code);
                    PaymentWindow pw = new PaymentWindow(current.serialKey);
                    pw.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstview_AllDeals.SelectedItems.Count == 0 || comboBox1.SelectedIndex == -1)
                    return;
                else
                {
                    ServiceLayer sl = new ServiceLayer();
                    ListViewItem selected = lstview_AllDeals.SelectedItems[0];
                    string couponCode = selected.SubItems[5].Text;
                    int code = 0;
                    int.TryParse(couponCode, out code);
                    string purchaseCode = selected.SubItems[0].Text;
                    int pCode = 0;
                    int.TryParse(purchaseCode, out pCode);
                    sl.updateCouponRank(code, pCode, comboBox1.SelectedIndex + 1);
                    comboBox1.SelectedIndex = -1;
                    comboBox1.Enabled = false;
                    button2.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
