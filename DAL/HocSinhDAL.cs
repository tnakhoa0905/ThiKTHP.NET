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
    public class HocSinhDAL:DataProvider
    {

        public List<HocSinhDTO> getList(long ma)
        {
            Moketnoi();
            List<HocSinhDTO> ds = new List<HocSinhDTO>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select MaHS,HoTen,GioiTinh,NgaySinh,QueQuan from HocSinh where MaLop = @ma";
            cmd.Connection = conec;
            cmd.Parameters.AddWithValue("@ma", ma);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                long mahs = reader.GetInt64(0);
                string ht = reader.GetString(1);
                string gt = reader.GetString(2);
                DateTime dt = reader.GetDateTime(3);
                string que = reader.GetString(4);
                HocSinhDTO hsdto =  new HocSinhDTO();
                hsdto.MaHS = mahs;
                hsdto.hoten = ht;
                hsdto.gioitinh = gt;
                hsdto.ngaysinh= dt;
                hsdto.quequan= que;
                ds.Add(hsdto);
            }
            reader.Close();
            return ds;
        }
        public bool XoaHS(long ma)
        {
            Moketnoi();
            SqlCommand commnand = new SqlCommand();
            commnand.CommandType = CommandType.Text;
            commnand.CommandText = "delete from HocSinh where MaHS = @ma";
            commnand.Connection = conec;
            commnand.Parameters.AddWithValue("@ma", ma);
            int kq = commnand.ExecuteNonQuery();
            return kq > 0;
        }
        public bool ThemHS(string ten,string gt, DateTime dt,string que,long malop)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = " insert into HocSinh(HoTen,GioiTinh,NgaySinh,QueQuan,MaLop) Values(@ten,@gt,@dt,@que,@ml)";
            command.Connection = conec;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@gt", SqlDbType.NVarChar).Value=gt;
            command.Parameters.Add("@dt",SqlDbType.DateTime).Value = dt;
            command.Parameters.Add("@que", SqlDbType.NVarChar).Value = que;
            command.Parameters.Add("@ml", SqlDbType.BigInt).Value = malop;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public bool SuaHS(long ma, string ten, string gt, DateTime dt, string que)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update HocSinh set HoTen = @ten,  GioiTinh = @gt,  NgaySinh = @dt,  QueQuan = @que where MaHS = @ma";
            command.Connection = conec;
            command.Parameters.Add("@ma", SqlDbType.BigInt).Value = ma;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@gt", SqlDbType.NVarChar).Value = gt;
            command.Parameters.Add("@dt", SqlDbType.DateTime).Value = dt;
            command.Parameters.Add("@que", SqlDbType.NVarChar).Value = que;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
    }
}
