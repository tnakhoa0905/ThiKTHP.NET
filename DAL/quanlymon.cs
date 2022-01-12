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
    public class quanlymon : DataProvider
    {
        
        public List<MonHoc> Getlist(){
            Moketnoi();
            List<MonHoc> ds = new List<MonHoc>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from MonHoc";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read()){
                long mh = dr.GetInt64(0);
                string ten = dr.GetString(1);
                MonHoc monHoc = new MonHoc ();
                monHoc.MaMH = mh;
                monHoc.MH = ten;
                ds.Add(monHoc);
            }
            dr.Close();
            return ds;
        }
        public bool XoaMon(long ma)
        {
            Moketnoi();
            SqlCommand commnand = new SqlCommand();
            commnand.CommandType = CommandType.Text;
            commnand.CommandText = "delete from MonHoc where MaMH = @ma";
            commnand.Connection = conec;
            commnand.Parameters.AddWithValue("@ma", ma);
            int kq = commnand.ExecuteNonQuery();
            return kq > 0;
        }
        public bool ThemMonHoc(string ten)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = " insert into MonHoc(TenMH) Values(@ten)";
            command.Connection = conec;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public bool SuaMonHoc(long ma, string ten)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update MonHoc set TenMH = @ten where MaMH = @ma";
            command.Connection = conec;
            command.Parameters.Add("@ma", SqlDbType.BigInt).Value = ma;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
    }
}
