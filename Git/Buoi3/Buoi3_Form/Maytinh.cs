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
    public partial class Maytinh : Form
    {
        XuLy xl = new XuLy();
        public Maytinh()
        {
            InitializeComponent();
        }

        private void btn_Cong_Click(object sender, EventArgs e)
        {
            txt_KetQua.Text = xl.Tong(txt_A.Text, txt_B.Text).ToString();
        }

        private void btn_Tru_Click(object sender, EventArgs e)
        {
            txt_KetQua.Text = xl.Hieu(txt_A.Text, txt_B.Text).ToString();
        }

        private void btn_Nhan_Click(object sender, EventArgs e)
        {
            txt_KetQua.Text = xl.Tich(txt_A.Text, txt_B.Text).ToString();
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            txt_KetQua.Text = xl.Chia(txt_A.Text, txt_B.Text).ToString();
        }

        private void txt_B_TextChanged(object sender, EventArgs e)
        {
            if (xl.KiemTraSo(txt_B.Text))
            {
                errorProvider1.SetError(txt_B, "Vui lòng chỉ nhập số!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_A_TextChanged(object sender, EventArgs e)
        {
            if (xl.KiemTraSo(txt_A.Text))
            {
                errorProvider1.SetError(txt_A, "Vui lòng chỉ nhập số!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_B.Clear();
            txt_A.Clear();
            txt_KetQua.Clear();
        }

        private void txt_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Maytinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
