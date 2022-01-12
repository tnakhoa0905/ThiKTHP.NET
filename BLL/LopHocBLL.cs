using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LopHocBLL
    {
        static LopHocDAL lh = new LopHocDAL();
        public static List<LopHocDTO> Getlist()
        {
            return lh.Getlist();
        }
        public static bool Add(string ten, long khoi)
        {
            return lh.ThemLop(ten, khoi);
        }
        public static bool Delete(long ma)
        {
            return lh.Delete(ma);
        }
        public static bool Update(long ma, string ten, long khoi)
        {
            return lh.SuaLop(ma, ten, khoi);
        }
    }
}
