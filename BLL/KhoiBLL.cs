﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class KhoiBLL
    {
        static KhoiDAL kh = new KhoiDAL();
        public static List<KhoiDTO> Getlist()
        {
            return kh.Getlist();
        } 
    }
}
