using BUS_QLKS;
using DTO_QLKS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmChangePass : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();

        public frmChangePass()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn thật sự muốn thoát.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtOldPass.Text != "" && txtNewPass.Text != "" && txtRetypeNewPass.Text != "")
            {
                if (txtNewPass.Text == txtRetypeNewPass.Text)
                {
                    DTO_TaiKhoan tk = new DTO_TaiKhoan();
                    tk.TenDangNhap = txtUserName.Text;
                    tk.MatKhau = txtNewPass.Text;
                    if (busTaiKhoan.doiMatKhau(tk))
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công.", "Thông báo");
                        txtUserName.ResetText();
                        txtOldPass.ResetText();
                        txtNewPass.ResetText();
                        txtRetypeNewPass.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi mật khẩu không thành công.", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu mới không đúng", "Thông báo");
                    txtRetypeNewPass.ResetText();
                    txtRetypeNewPass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui điền đầy đủ thông tin để thay đổi mật khẩu.", "Thông báo");
            }
        }
    }
}
