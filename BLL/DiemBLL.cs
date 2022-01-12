using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class DiemBLL
    {
        static DiemDAL d = new DiemDAL();
        public static List<DiemDTO> getlist(long ma)
        {
            return d.getlist(ma);
        }
    }
}
