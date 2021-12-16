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
    public partial class FormShoppingCart : Form
    {
        public FormShoppingCart()
        {
            InitializeComponent();
        }

        private void BtOrder_Click(object sender, EventArgs e)
        {
            FormOrder order = new FormOrder();
            order.Show();
            this.Close();
        }

        private void BtHome_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();
            this.Close();
        }

        private void BtShoppingCard_Click(object sender, EventArgs e)
        {

        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public void shoppingcart (List<ListViewItem> Shoppingcart)
        {
            var message = string.Join(Environment.NewLine, Shoppingcart);
            MessageBox.Show(message);
            MessageBox.Show("Recieved");
            foreach (var item in Shoppingcart)
            {
                LvShoppingCart.Items.Add(item);
            }
        }

        private void FormShoppingCart_Load(object sender, EventArgs e)
        {

        }
    }
}
