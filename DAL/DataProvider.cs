using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DataProvider
    {
        public SqlConnection conec = null;

        string strconec = @"server =DESKTOP-D3KKHSJ\SQLEXPRESS ; Database=QuanLyHocBa ; User ID=sa; PWd=123456";

        public void Moketnoi()

        {

            if (conec == null)

            {
                conec = new SqlConnection(strconec);
            }

            if (conec.State == ConnectionState.Closed)

            {
                conec.Open();
            }

        }

        public void DongKetNoi()

        {
            if (conec != null && conec.State == ConnectionState.Open)
            {

                conec.Close();

            }

        }
    }
}
