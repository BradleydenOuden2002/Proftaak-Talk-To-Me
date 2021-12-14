using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SmartyCarBasic
{
    class OrderClass
    {
        private string connectionString = "datasource=studmysql01.fhict.local;username=dbi486810;password=7653@Ajc;database=dbi486810;";
        public List<ListViewItem> Product()
        {
            string query = "SELECT * FROM products";
            List<ListViewItem> product = new List<ListViewItem>();
            
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] row = {reader.GetString(1), reader.GetString(2), Convert.ToString(reader.GetString(4))};
                    var listviewitem = new ListViewItem(row);
                    product.Add(listviewitem);
                }
            }

            databaseConnection.Close();
            return product;
        }
        public double PriceCal(int AmountOrder, double selecteditempricedouble)
        {
            double total = AmountOrder * selecteditempricedouble;
            return total;
        }
    }
}
