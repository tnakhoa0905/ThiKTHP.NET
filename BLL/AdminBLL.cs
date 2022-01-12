using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AdminBLL
    {
        static AdminAccess adc = new AdminAccess();
        public static List<Admin> Getlist()
        {
            return adc.Getlist();
        }
        public static Boolean Check (string user,string pass)
        {
            return adc.check(user, pass);
        }
    }
}
