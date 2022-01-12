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
    public partial class quanlymon : Form
    {
        public quanlymon()
        {
            InitializeComponent();
            load();


        }

        public void load()
        {
            List<MonHoc> ds = MonHocBLL.Getlist();
            dataGridViewMH.DataSource = ds;
        }

        public MonHoc SelectMH
        {
            get
            {
                DataGridViewRow ds = dataGridViewMH.CurrentRow;
                return new MonHoc
                {
                    MaMH = Convert.ToInt64(ds.Cells[0].Value),
                    MH = ds.Cells[1].Value.ToString(),
                };
            }
        }
        private void clickSelectMH(object sender, EventArgs e)
        {
            txtmon.Text = SelectMH.MH;
            txtma.Text = Convert.ToString(SelectMH.MaMH);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNoCancel);
            if(ds == DialogResult.Yes)
            {
                MonHocBLL.Delete(SelectMH.MaMH);
                MessageBox.Show("Xóa thành công");
                dataGridViewMH.Refresh();
                List<MonHoc> ds1 = MonHocBLL.Getlist();
                dataGridViewMH.DataSource = ds1;
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string ten = txtmon.Text.Trim();
            if (MonHocBLL.Add(ten))
            {
                MessageBox.Show("Thêm thành công");
                load();
            }
            else
            {
                MessageBox.Show("Lỗi rồi bạn ơi");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string ten = txtmon.Text.Trim();
            long ma = Convert.ToInt64(txtma.Text.Trim());
            if (MonHocBLL.Update(ma,ten))
            {
                MessageBox.Show("Sửa thành công");
                load();
            }
            else
            {
                MessageBox.Show("Lỗi rồi bạn ơi");
            }
        }
    }
}
