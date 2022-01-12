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
    public partial class ChiTietLopHoc : Form
    {
        private LopHocDTO chnge;
        HocSinhDTO hocSinh = new HocSinhDTO();
        public ChiTietLopHoc(LopHocDTO lp)
        {
            InitializeComponent();
            chnge = lp;
            lbLop.Text = chnge.Name;
            load(chnge.IdLop);
        }
        public void load(long ma)
        {
            List<HocSinhDTO> ds = HocSinhBLL.getlist(ma);
            dataGridViewHS.DataSource = ds;
            this.dataGridViewHS.Columns["MaHS"].Visible = false;
            
        }
        private void lbLop_Click(object sender, EventArgs e)
        {

        }
        public HocSinhDTO SelectHS
        {
            get
            {
                DataGridViewRow ds = dataGridViewHS.CurrentRow;
                return new HocSinhDTO
                {
                    MaHS = Convert.ToInt64(ds.Cells[0].Value),
                    hoten = ds.Cells[1].Value.ToString(),
                    gioitinh = ds.Cells[2].Value.ToString(),
                    ngaysinh = Convert.ToDateTime(ds.Cells[3].Value),
                    quequan = ds.Cells[4].Value.ToString(),
                };
            }
        }
        private void dataGridViewHS_Click(object sender, EventArgs e)
        {
            txtHoten.Text = SelectHS.hoten.ToString();
            txtGT.Text = SelectHS.gioitinh.ToString();
            dtime.Text = SelectHS.ngaysinh.ToLongDateString();
            txtAdd.Text = SelectHS.quequan.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNoCancel);
            if (ds == DialogResult.Yes)
            {
                HocSinhBLL.Delete(SelectHS.MaHS);
                MessageBox.Show("Xóa thành công");
                load(chnge.IdLop);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = txtHoten.Text.ToString();
            string gt = txtGT.Text.ToString();
            DateTime dt = Convert.ToDateTime(dtime.Value.ToString()) ;
            string que = txtAdd.Text.ToString();
            if (HocSinhBLL.Add(ten, gt, dt, que,chnge.IdLop))
            {
                MessageBox.Show("Thêm thành công");
                load(chnge.IdLop);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ten = txtHoten.Text.ToString();
            string gt = txtGT.Text.ToString();
            DateTime dt = Convert.ToDateTime(dtime.Value.ToString());
            string que = txtAdd.Text.ToString();
            if (HocSinhBLL.Update(SelectHS.MaHS,ten, gt, dt, que))
            {
                MessageBox.Show("Sửa ok");
                load(chnge.IdLop);
            }
        }

        private void dataGridViewHS_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hocSinh = SelectHS;
            ChiTietHocSinh f = new ChiTietHocSinh(hocSinh);
            f.Show();
        }
    }
}
