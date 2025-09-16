using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Form
{
    public partial class DangKy : Form
    {
        XuLy dt = new XuLy();
        public DangKy()
        {
            InitializeComponent();
        }

        private void txt_UserName_Leave(object sender, EventArgs e)
        {
            if (txt_UserName.Text.Length == 0)
            {
                errorProvider1.SetError(txt_UserName, "Tên đăng nhập là bắt buộc!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (txt_Email.Text.Length == 0 || !dt.KT_Email(txt_Email.Text))
            {
                errorProvider1.SetError(txt_Email, "Vui lòng nhập email hợp lệ!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_MatKhau_Leave(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text.Length == 0)
            {
                errorProvider1.SetError(txt_MatKhau, "Vui lòng đặt mật khẩu!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btn_Sumit_Click(object sender, EventArgs e)
        {
            if (txt_Email.Text.Length == 0 || txt_UserName.Text.Length == 0 || txt_MatKhau.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào các ô đánh dấu (*) !", "Thông báo");

                return;
            }
            else
            {
                errorProvider1.Clear();
                MessageBox.Show("Đăng ký thành công !", "Thông báo");
            }
        }

        private void DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
