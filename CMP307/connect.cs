using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CMP307
{ 
    class connect
    {
        SqlConnection con = new SqlConnection("Data Source=tolmount.abertay.ac.uk;Initial Catalog=sql1802193;Persist Security Info=True;User ID=sql1802193;Password=YbQm7PZdye");
        public SqlConnection Active()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
    }
}
