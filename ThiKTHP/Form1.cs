using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BLL;
using DTO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var user = txtuser.Text;
            var pass = txtpass.Text;
            bool check = AdminBLL.Check(user, pass);
            if (check)
            {
                DialogResult rs = MessageBox.Show("Đăng nhập thành công");
                if (rs == DialogResult.OK) {
                    Manager f = new Manager();
                    this.Hide();
                    f.ShowDialog();
                    
                }
                
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
