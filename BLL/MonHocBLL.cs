using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class MonHocBLL
    {
        static quanlymon ql = new quanlymon();
        public static List<MonHoc> Getlist()
        {
            return ql.Getlist();
        }
        public static bool Delete(long ma)
        {
            return ql.XoaMon(ma);
        }
        public static bool Add(string ten)
        {
            return ql.ThemMonHoc(ten);
        }
        public static bool Update(long ma, string ten)
        {
            return ql.SuaMonHoc(ma, ten);
        }
    }
}
