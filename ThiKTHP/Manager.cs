using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quanlymon f = new quanlymon();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyLop f = new QuanLyLop();
            f.ShowDialog();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
