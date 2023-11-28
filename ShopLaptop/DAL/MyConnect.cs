using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ShopLaptop.DAL
{
    public class MyConnect
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop; User Id=" + Form_DangNhap.username + ";Password=" +
            Form_DangNhap.password + ";");
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        // open the connection
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
