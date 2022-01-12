using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class HocSinhBLL
    {
        static HocSinhDAL hs = new HocSinhDAL();
        public static List<HocSinhDTO> getlist(long ma)
        {
            return hs.getList(ma);
        }
        public static bool Delete(long ma)
        {
            return hs.XoaHS(ma);
        }
        public static bool Add(string ten, string gt, DateTime dt, string que,long malop)
        {
            return hs.ThemHS(ten, gt, dt, que, malop);
        }
        public static bool Update(long ma, string ten, string gt, DateTime dt, string que)
        {
            return hs.SuaHS(ma, ten, gt, dt,que);
        }

    }
}
