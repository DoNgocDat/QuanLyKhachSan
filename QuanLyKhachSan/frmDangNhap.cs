using BUS_QLKS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmDangNhap : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void ckbDisplayPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbDisplayPass.Checked == true)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn thật sự muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public static string TenDangNhap { get; set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtUserName.Text;
            string matkhau = txtPassWord.Text;
            if (txtUserName.Text != "" && txtPassWord.Text != "")
            {
                if (busTaiKhoan.dangNhap(tendangnhap, matkhau))
                {
                    TenDangNhap = tendangnhap; 
                    frmQuanLy frmquanly = new frmQuanLy();
                    this.Hide();
                    frmquanly.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo");
                    txtUserName.ResetText();
                    txtPassWord.ResetText();
                    txtUserName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo");
                txtUserName.Focus();
            }
        }
    }
}
