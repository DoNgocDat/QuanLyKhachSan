using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BUS_QLKS;
using DTO_QLKS;

namespace QuanLyKhachSan
{
    public partial class frmAdmin : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        BUS_Phong busPhong = new BUS_Phong();
        BUS_DanhMuc busDanhMuc = new BUS_DanhMuc();

        public frmAdmin()
        {
            InitializeComponent();
        }

        // Load dữ liệu lên datagridview
        private void frmAdmin_Load_1(object sender, EventArgs e)
        {
            dtgAccount.DataSource = busTaiKhoan.getTaiKhoan();
            dtgRoom.DataSource = busPhong.getPhong();
            dtgCategory.DataSource = busDanhMuc.getDanhMuc();
        }

        // Thêm tài khoản
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if(txtNameAccount.Text != "" && txtDisplayName.Text != "" && txtPassAccount.Text != "" && numTypeAccount.Text != "")
            {
                DTO_TaiKhoan tk = new DTO_TaiKhoan(txtNameAccount.Text, txtDisplayName.Text, txtPassAccount.Text, (int)numTypeAccount.Value);
                if (busTaiKhoan.themTaiKhoan(tk))
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo");
                    dtgAccount.DataSource = busTaiKhoan.getTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo");
            }
        }

        // Thêm Danh mục
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtNameCategory.Text != "")
            {
                DTO_DanhMuc dm = new DTO_DanhMuc(0, txtNameCategory.Text);
                if (busDanhMuc.themDanhMuc(dm))
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo");
                    dtgCategory.DataSource = busDanhMuc.getDanhMuc();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo");
            }
        }

        // Thêm phòng
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomName.Text != "" && numRoomCategory.Text != "" && numPrice.Text != "" && txtRoomStatus.Text != "")
            {
                DTO_Phong tp = new DTO_Phong(0, txtRoomName.Text, (int)numRoomCategory.Value, (float)numPrice.Value, txtRoomStatus.Text);
                if (busPhong.themPhong(tp))
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo");
                    dtgRoom.DataSource = busPhong.getPhong();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
            }
        }

        // Xóa tài khoản
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if(dtgAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgAccount.SelectedRows[0];
                string tdn = row.Cells[0].Value.ToString();
                if (busTaiKhoan.xoaTaiKhoan(tdn))
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo");
                    dtgAccount.DataSource = busTaiKhoan.getTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản muốn xóa.", "Thông báo");
            }
        }

        // Xóa danh mục
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dtgCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgCategory.SelectedRows[0];
                int mdm = Convert.ToInt16(row.Cells[0].Value.ToString());
                if (busDanhMuc.xoaDanhMuc(mdm))
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo");
                    dtgCategory.DataSource = busDanhMuc.getDanhMuc();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục muốn xóa.", "Thông báo");
            }
        }

        // Xóa phòng
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dtgRoom.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgRoom.SelectedRows[0];
                int mp = Convert.ToInt16(row.Cells[0].Value.ToString());
                if (busPhong.xoaPhong(mp))
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo");
                    dtgRoom.DataSource = busPhong.getPhong();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng muốn xóa.", "Thông báo");
            }
        }

        // Sửa tài khoản
        private void btnFixAccount_Click(object sender, EventArgs e)
        {
            if(dtgAccount.SelectedRows.Count > 0)
            {
                if (txtDisplayName.Text != "" && txtPassAccount.Text != "" && numTypeAccount.Text != "")
                {
                    int i = dtgAccount.CurrentCell.RowIndex;
                    string tdn = dtgAccount.Rows[i].Cells[0].Value.ToString();
                    DTO_TaiKhoan tk = new DTO_TaiKhoan(tdn, txtDisplayName.Text, txtPassAccount.Text, (int)numTypeAccount.Value);
                    if(busTaiKhoan.suaTaiKhoan(tk))
                    {
                        MessageBox.Show("Sửa thành công.", "Thông báo");
                        dtgAccount.DataSource = busTaiKhoan.getTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công.", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tài khoản muốn sửa.", "Thông báo");
                }
            }
        }

        // Sửa danh mục
        private void btnFix_Click(object sender, EventArgs e)
        {
            if(dtgCategory.Rows.Count > 0)
            {
                if(txtNameCategory.Text != "")
                {
                    int i = dtgCategory.CurrentCell.RowIndex;
                    int mdm = Convert.ToInt16(dtgCategory.Rows[i].Cells[0].Value.ToString());
                    DTO_DanhMuc dm = new DTO_DanhMuc(mdm, txtNameCategory.Text);
                    if (busDanhMuc.suaDanhMuc(dm))
                    {
                        MessageBox.Show("Sửa thành công.", "Thông báo");
                        dtgCategory.DataSource = busDanhMuc.getDanhMuc();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công.", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn danh mục muốn sửa.", "Thông báo");
                }
            }
        }

        // Sửa phòng
        private void btnFixRoom_Click(object sender, EventArgs e)
        {
            if(dtgRoom.Rows.Count > 0)
            {
                if(txtRoomName.Text != "" && numRoomCategory.Text != "" && numPrice.Text != "" && txtRoomStatus.Text != "")
                {
                    int i = dtgRoom.CurrentCell.RowIndex;
                    int mp = Convert.ToInt32(dtgRoom.Rows[i].Cells[0].Value.ToString());
                    DTO_Phong pp = new DTO_Phong(mp, txtRoomName.Text, (int)numRoomCategory.Value, (float)numPrice.Value, txtRoomStatus.Text);
                    if(busPhong.suaPhong(pp))
                    {
                        MessageBox.Show("Sửa thành công.", "Thông báo");
                        dtgRoom.DataSource = busPhong.getPhong();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công.", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phòng muốn sửa.", "Thông báo");
                }
            }
        }

        // làm mới tài khoản
        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            txtNameAccount.ResetText();
            txtDisplayName.ResetText();
            txtPassAccount.ResetText();
            numTypeAccount.ResetText();
        }

        // Làm mới phòng
        private void btnNewRoom_Click(object sender, EventArgs e)
        {
            txtIdRoom.ResetText();
            txtRoomName.ResetText();
            numRoomCategory.ResetText();
            numPrice.ResetText();
            txtRoomStatus.ResetText();
            txtSearch.ResetText();
        }

        // Làm mới danh mục
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtIdCategory.ResetText();
            txtNameCategory.ResetText();
        }

        // Tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                if (busPhong.timPhong(txtSearch.Text) != null)
                {
                    dtgRoom.DataSource = busPhong.timPhong(txtSearch.Text);
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

        private void dtgCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgCategory.CurrentCell.RowIndex;
            txtIdCategory.Text = dtgCategory.Rows[i].Cells[0].Value.ToString();
            txtNameCategory.Text = dtgCategory.Rows[i].Cells[1].Value.ToString();
        }

        private void dtgRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgRoom.CurrentCell.RowIndex;
            txtIdRoom.Text = dtgRoom.Rows[i].Cells[0].Value.ToString();
            txtRoomName.Text = dtgRoom.Rows[i].Cells[1].Value.ToString();
            numRoomCategory.Value = Convert.ToInt32(dtgRoom.Rows[i].Cells[2].Value);
            numPrice.Value = Convert.ToDecimal(dtgRoom.Rows[i].Cells[3].Value);
            txtRoomStatus.Text = dtgRoom.Rows[i].Cells[4].Value.ToString();
        }

        private void dtgAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgAccount.CurrentCell.RowIndex;
            txtNameAccount.Text = dtgAccount.Rows[i].Cells[0].Value.ToString();
            txtDisplayName.Text = dtgAccount.Rows[i].Cells[1].Value.ToString();
            txtPassAccount.Text = dtgAccount.Rows[i].Cells[2].Value.ToString();
            numTypeAccount.Value = Convert.ToInt32(dtgAccount.Rows[i].Cells[3].Value);
        }
    }
}
