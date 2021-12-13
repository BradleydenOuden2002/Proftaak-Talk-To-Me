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
            main.Close();
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
    }
}
