using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class KhoiDAL:DataProvider
    {
        public List<KhoiDTO> Getlist()
        {
            Moketnoi();
            List<KhoiDTO> ds = new List<KhoiDTO>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Khoi";
            cmd.Connection = conec;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                long ma = rd.GetInt64(0);
                string ten = rd.GetString(1);
                KhoiDTO kh = new KhoiDTO();
                kh.MaKhoi = ma;
                kh.TenKhoi = ten;
                ds.Add(kh);

            }
            rd.Close();
            return ds;
        }
    }
}
