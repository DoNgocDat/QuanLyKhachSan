using BUS_QLKS;
using DTO_QLKS;
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
    public partial class frmQuanLy : Form
    {
        BUS_HoaDon busHoaDon = new BUS_HoaDon();
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        BUS_Phong busPhong = new BUS_Phong();

        public frmQuanLy()
        {
            InitializeComponent();
        }

        // Show frmAdmin
        private void mnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frmadmin = new frmAdmin();
            frmadmin.Show();
        }

        private int quyen;

        // Load hóa đơn, phòng - phân quyền 
        private void frmQuanLy_Load_1(object sender, EventArgs e)
        {
            // Load hóa đơn, phòng
            dtgBill.DataSource = busHoaDon.getHoaDon();
            dtgRoom.DataSource = busPhong.getPhong();
            // Phân quyền
            quyen = busTaiKhoan.getQuyen(frmDangNhap.TenDangNhap);
            if (quyen == 0)
            {
                mnAdmin.Enabled = false;
            }
        }

        // Tìm kiếm phòng trống
        private void btnEmptyRoom_Click(object sender, EventArgs e)
        {
            if (txtEmptyRoom.Text != "")
            {
                if (busPhong.timPhongTrong(txtEmptyRoom.Text) != null)
                {
                    dtgRoom.DataSource = busPhong.timPhongTrong(txtEmptyRoom.Text);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập phòng cần tìm kiếm.", "Thông báo");
            }
        }

        // Tìm Kiếm hóa đơn theo mã hóa đơn
        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchBill.Text, out int mahoadon) && mahoadon > 0)
            {
                DataTable dt = busHoaDon.timHoaDon(mahoadon);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dtgBill.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn là số nguyên và lớn hơn 0.", "Thông báo");
            }
        }

        // Làm mới - quản lý
        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpDateIn.ResetText();
            dtpDateOut.ResetText();
            numIdRoom.ResetText();
            numNumber.ResetText();
            numSumPrice.ResetText();
        }

        // File - đổi mật khẩu
        private void mnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePass frmdoimatkhau = new frmChangePass();
            frmdoimatkhau.Show();
        }

        // File - đăng xuất
        private void mnLogOut_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn tật sự muốn đăng xuất.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        // Thanh toán
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (dtpDateIn.Text != "" && dtpDateOut.Text != "" && numIdRoom.Text != "" && numNumber.Text != "" && numSumPrice.Text != "" && cbbStatus.Text != "")
            {
                
                if (numIdRoom.Value > 0)
                {
                    if (cbbStatus.Text != "Đã Thanh Toán")
                    {
                        int maphong = Convert.ToInt32(numIdRoom.Value.ToString());
                        if (busHoaDon.thanhToan(maphong))
                        {
                            MessageBox.Show("Thanh toán thành công.", "Thông báo");
                            dtgBill.DataSource = busHoaDon.getHoaDon();
                            busPhong.thanhToan(maphong);
                            dtgRoom.DataSource = busPhong.getPhong();
                        }
                        else
                        {
                            MessageBox.Show("Thanh toán không thành công.", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phòng đã được thanh toán.", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phòng cần thanh toán.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần thanh toán.", "Thông báo");
            }
        }
         
        // Cell bill
        private void dtgBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgBill.CurrentCell.RowIndex;
            dtpDateIn.Text = dtgBill.Rows[i].Cells[1].Value.ToString();
            dtpDateOut.Text = dtgBill.Rows[i].Cells[2].Value.ToString();
            numIdRoom.Value = Convert.ToInt32(dtgBill.Rows[i].Cells[3].Value);
            numNumber.Value = Convert.ToInt16(dtgBill.Rows[i].Cells[4].Value);
            numSumPrice.Value = Convert.ToDecimal(dtgBill.Rows[i].Cells[5].Value);
            cbbStatus.Text = dtgBill.Rows[i].Cells[6].Value.ToString();
        }


        // Cell phòng - quản lý
        private void dtgRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtpDateOut.Value >= dtpDateIn.Value)
            {
                TimeSpan duration = dtpDateOut.Value - dtpDateIn.Value + new TimeSpan(1, 0, 0, 0);
                int days = duration.Days;
                int i = dtgRoom.CurrentCell.RowIndex;
                numIdRoom.Value = Convert.ToInt32(dtgRoom.Rows[i].Cells[0].Value);
                decimal roomPrice = decimal.Parse(dtgRoom.Rows[i].Cells[3].Value.ToString());
                decimal total = days * roomPrice;
                numSumPrice.Value = total;
            }
            else
            {
                MessageBox.Show("Ngày ra không được nhỏ hơn ngày vào", "Thông báo");
            }
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            if (dtpDateIn.Text != "" && dtpDateOut.Text != "" && numIdRoom.Text != "" && numNumber.Text != "" && numSumPrice.Text != "" && cbbStatus.Text != "")
            {
                if (numIdRoom.Value > 0)
                {
                    int i = dtgRoom.CurrentCell.RowIndex;
                    if (dtgRoom.Rows[i].Cells[4].Value.ToString() != "Đã Đặt")
                    {
                        int maphong = Convert.ToInt32(numIdRoom.Value.ToString());
                        DTO_HoaDon dp = new DTO_HoaDon(0, dtpDateIn.Value, dtpDateOut.Value, (int)numIdRoom.Value, (int)numNumber.Value, (float)numSumPrice.Value, cbbStatus.Text);
                        if (busPhong.datPhong(maphong))
                        {
                            busHoaDon.datPhong(dp);
                            MessageBox.Show("Đặt phòng thành công.", "Thông báo");
                            dtgRoom.DataSource = busPhong.getPhong();
                            dtgBill.DataSource = busHoaDon.getHoaDon();
                        }
                        else
                        {
                            MessageBox.Show("Đặt phòng không thành công.", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phòng này đã được đặt.", "Thông báo");
                    }
                }
                else
                {
                   MessageBox.Show("Vui lòng chọn phòng cần đặt.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần đặt.", "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn thật sự muốn thoát.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
