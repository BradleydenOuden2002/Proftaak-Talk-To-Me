using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartyCarBasic
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            System.Windows.Forms.Application.Exit();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            OrderClass order = new OrderClass();
            List<ListViewItem> product = order.Product();
            foreach (var item in product)
            {
                LvProducts.Items.Add(item);
            }

        }

        private void LvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvProducts.SelectedItems.Count == 0)
                return;

            var item = LvProducts.SelectedItems[0];
            var selecteditem = item.Text;
            var selecteditemprice = item.SubItems[2].Text;
            LbItemSelected.Text = selecteditem;
            LbSelecteditemPrice.Text = ("€" + selecteditemprice);

        }
    }
}
