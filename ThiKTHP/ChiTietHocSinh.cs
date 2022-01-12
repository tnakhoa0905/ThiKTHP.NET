using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class ChiTietHocSinh : Form
    {
        private HocSinhDTO hocSinh;
        public ChiTietHocSinh(HocSinhDTO hs)
        {
            InitializeComponent();
            hocSinh = hs;
            load(hocSinh.MaHS);
        }
        public void load(long ma)
        {
            List<DiemDTO> ds = DiemBLL.getlist(ma);
            dataGridViewHS.DataSource = ds;
            cbmh.ValueMember = "MaMH";
            cbmh.DisplayMember = "MH";
            cbmh.DataSource = MonHocBLL.Getlist();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thành công");
            load(hocSinh.MaHS);
        }
    }
}
