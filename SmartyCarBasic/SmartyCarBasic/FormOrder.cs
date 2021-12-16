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
        OrderClass order = new OrderClass();
        ShoppingCartClass cart = new ShoppingCartClass();
        int AmountOrder;
        string selecteditem;
        string selecteditemprice;
        double total;
        public FormOrder()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
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
            selecteditem = item.Text;
            selecteditemprice = item.SubItems[2].Text;
            LbItemSelected.Text = selecteditem;
            LbSelecteditemPrice.Text = ("€" + selecteditemprice);
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            AmountOrder++;
            LbAmountOrder.Text = Convert.ToString(AmountOrder);
            PriceCal(AmountOrder, selecteditemprice, selecteditem);
        }

        private void BtSup_Click(object sender, EventArgs e)
        {
            if (AmountOrder > 0)
            {
                AmountOrder--;
            }
            else
            {
                AmountOrder = 0;
            }
            LbAmountOrder.Text = Convert.ToString(AmountOrder);
            PriceCal(AmountOrder, selecteditemprice, selecteditem);
        }

        private void PriceCal(int AmountOrder, string selecteditemprice, string selecteditem)
        {
            double selecteditempricedouble = Convert.ToDouble(selecteditemprice);
            total = order.PriceCal(AmountOrder, selecteditempricedouble, selecteditem);
            LbTotal.Text = "total: " + total;
        }

        private void BtMainMenu_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();
            this.Close();
        }

        private void BtAddToCart_Click(object sender, EventArgs e)
        {
            cart.ShoppingList(AmountOrder, selecteditemprice, selecteditem, total);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cart.OpenShoppingCartForm();
        }
    }
}
