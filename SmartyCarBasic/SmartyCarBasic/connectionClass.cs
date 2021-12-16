using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartyCarBasic
{
    class connectionClass
    {
        public string connectionString { get; }
        public string QueryProducts { get; }

        public connectionClass(string QueryProducts, string connectionString)
        {
            this.QueryProducts = "SELECT * FROM products";
            this.connectionString   = "datasource=studmysql01.fhict.local;username=dbi486810;password=7653@Ajc;database=dbi486810;";
        }

    }
}
