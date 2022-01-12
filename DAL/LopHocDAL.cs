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
    public class LopHocDAL:DataProvider
    {
        public List<LopHocDTO> Getlist()
        {
            Moketnoi();
            List<LopHocDTO> ds = new List<LopHocDTO>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Lop";
            cmd.Connection = conec;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                long ma = rd.GetInt64(0);
                string ten = rd.GetString(1);
                long khoi = rd.GetInt64(2);
                LopHocDTO lop = new LopHocDTO();
                lop.IdLop = ma;
                lop.Name = ten;
                lop.Khoi = khoi;
                ds.Add(lop);
            }
            rd.Close();
            return ds;
        }
        public bool Delete(long ma)
        {
            Moketnoi();
            SqlCommand commnand = new SqlCommand();
            commnand.CommandType = CommandType.Text;
            commnand.CommandText = "delete from Lop where MaLop = @ma";
            commnand.Connection = conec;
            commnand.Parameters.AddWithValue("@ma", ma);
            int kq = commnand.ExecuteNonQuery();
            return kq > 0;

        }
        public bool ThemLop(string ten,long khoi)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = " insert into Lop(TenLop,MaKhoi) Values(@ten,@khoi)";
            command.Connection = conec;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@khoi", SqlDbType.BigInt).Value = khoi;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public bool SuaLop(long ma, string ten, long khoi)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update Lop set TenLop = @ten, MaKhoi = @khoi where MaLop = @ma";
            command.Connection = conec;
            command.Parameters.Add("@ma", SqlDbType.BigInt).Value = ma;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@khoi", SqlDbType.BigInt).Value = khoi;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
    }
}
