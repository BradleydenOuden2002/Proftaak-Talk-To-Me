using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartyCarBasic
{
    class ShoppingCartClass
    {
        private FormShoppingCart list = new FormShoppingCart();
        public void ShoppingList(int AmountOrder, string selecteditemprice, string selecteditem, double total)
        {
            List<ListViewItem> ShoppingCartList = new List<ListViewItem>();
            string[] row = { selecteditem, Convert.ToString(AmountOrder), Convert.ToString(total) };
            var listviewitem = new ListViewItem(row);
            ShoppingCartList.Add(listviewitem);
            var message = string.Join(Environment.NewLine, ShoppingCartList);
            list.shoppingcart(ShoppingCartList);
        }

        public void OpenShoppingCartForm()
        {
            FormOrder order = new FormOrder();
            order.Hide();
            list.Show();
        }
    }
}
