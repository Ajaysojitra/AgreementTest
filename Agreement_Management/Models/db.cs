using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Agreement_Management.Models;
namespace Agreement_Management.Models
{
    public class db
    {
        SqlConnection con = new SqlConnection("Data Source=OCEAN\\SQLEXPRESS;Initial Catalog=Agreement_Database;Integrated Security=True");

        public int logincheck(Ad_login ad)
        {
            SqlCommand com = new SqlCommand("Sp_Login",con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UserName", ad.UserName);
            com.Parameters.AddWithValue("@Password", ad.Password);
            SqlParameter oblogin = new SqlParameter();
            oblogin.ParameterName = "@Isvalid";
            oblogin.SqlDbType = SqlDbType.Bit;
            oblogin.Direction = ParameterDirection.Output;
            com.Parameters.Add(oblogin);
            con.Open();
            com.ExecuteNonQuery();
            int res = Convert.ToInt32(oblogin.Value);
            con.Close();
            return res;
        }
    }
}
