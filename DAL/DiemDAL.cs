using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DiemDAL:DataProvider
    {
        public List<DiemDTO> getlist(long ma)
        {
            Moketnoi();
            List<DiemDTO> ds = new List<DiemDTO>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select hs.HoTen,d.HocKy,d.Diem1,d.Diem2,mh.TenMH from HocSinh as hs join Diem as d on hs.MaHS = d.MaHS join MonHoc as mh on d.MaMH = mh.MaMH where hs.MaHS = @ma";
            cmd.Connection = conec;
            cmd.Parameters.AddWithValue("@ma", ma);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string hoten = reader.GetString(0);
                long hk = Convert.ToInt64(reader.GetString(1));
                double diem1 = reader.GetDouble(2);
                double diem2 = reader.GetDouble(3);
                string tenmh = reader.GetString(4);
                DiemDTO dto = new DiemDTO();
                dto.TenHS = hoten;
                dto.hocky = hk;
                dto.diem1 = diem1;
                dto.diem2 = diem2;
                dto.tenmh = tenmh;
                ds.Add(dto);
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
    }
}
