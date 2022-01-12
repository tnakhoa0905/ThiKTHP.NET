using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using DTO;

using System.Data;

using System.Data.SqlClient;
namespace DAL
{
    public class AdminAccess:DataProvider
    {
        List<Admin> ds = new List<Admin>();
        public List<Admin> Getlist()
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select tdn as 'Tên đăng nhập',pass as 'Mật khẩu' from Login";
            command.Connection = conec;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string ten = reader.GetString(0);
                string pass = reader.GetString(1);
                Admin ad = new Admin();
                ad.Tdn = ten;
                ad.Mk = pass;
                ds.Add(ad);
            }
            reader.Close();
            return ds;
        }
        public Boolean check(string ten, string mk)
        {
            Moketnoi();
            Console.WriteLine(ten);
            Console.WriteLine(mk);

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Login where tdn = @ten and pass = @mk";
            command.Connection = conec;
            command.Parameters.Add("@ten",SqlDbType.VarChar).Value = ten;
            command.Parameters.Add("@mk", SqlDbType.VarChar).Value = mk;
            SqlDataReader reader = command.ExecuteReader();
            bool kq = reader.Read();
            reader.Close();
            return kq;
        }
    }
}
