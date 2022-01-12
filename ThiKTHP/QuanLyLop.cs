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
    public partial class QuanLyLop : Form
    {
        LopHocDTO change = new LopHocDTO();
        public QuanLyLop()
        {
            InitializeComponent();
            load();
        }

        private void QuanLyLop_Load(object sender, EventArgs e)
        {

        }
        public void load()
        {
            List<LopHocDTO> ds = LopHocBLL.Getlist();
            dataGridViewLOP.DataSource = ds;
            comboBox1.ValueMember = "MaKhoi";
            comboBox1.DisplayMember = "TenKhoi";
            comboBox1.DataSource = KhoiBLL.Getlist();
        }

        public LopHocDTO SelectLop
        {
            get
            {
                DataGridViewRow ds = dataGridViewLOP.CurrentRow;
                return new LopHocDTO
                {
                    IdLop = Convert.ToInt64(ds.Cells[0].Value),
                    Name = ds.Cells[1].Value.ToString(),
                    Khoi = Convert.ToInt64(ds.Cells[2].Value),
                };
            }
        }
        private void clickLopHoc(object sender, EventArgs e)
        {
            txtLop.Text = SelectLop.Name;
            txtidLop.Text = Convert.ToString(SelectLop.IdLop);
            if (SelectLop.Khoi == 1)
            {
                comboBox1.Text = "Khối 10";
            }
            if (SelectLop.Khoi == 2)
            {
                comboBox1.Text = "Khối 11";
            }
            if (SelectLop.Khoi == 3)
            {
                comboBox1.Text = "Khối 12";
            }



        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            long khoi = long.Parse(comboBox1.SelectedValue.ToString());
            string ten = txtLop.Text;
            /*Console.WriteLine();*/
            if (LopHocBLL.Add(ten, khoi))
            {
                MessageBox.Show("Thêm thành công");
                load();
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNoCancel);
            if (ds == DialogResult.Yes)
            {
                LopHocBLL.Delete(SelectLop.IdLop);
                MessageBox.Show("Xóa thành công");
                load();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            long khoi = long.Parse(comboBox1.SelectedValue.ToString());
            string ten = txtLop.Text;
            if (LopHocBLL.Update(SelectLop.IdLop, ten, khoi))
            {
                MessageBox.Show("Cập nhật thành công");
                load();
            }
        }

        private void dataGridViewLOP_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change = SelectLop;
            ChiTietLopHoc f = new ChiTietLopHoc(change);
            f.ShowDialog();
        }
    }
}
