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

    public partial class Uoc_Boi : Form
    {
        XuLy xl = new XuLy();
        public Uoc_Boi()
        {
            InitializeComponent();
        }

        private void btn_ThucHien_Click(object sender, EventArgs e)
        {
            txt_BC.Text = xl.BoiChung(int.Parse(txt_A.Text), int.Parse(txt_B.Text)).ToString();
            txt_UC.Text = xl.UocChung(int.Parse(txt_A.Text), int.Parse(txt_B.Text)).ToString();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_UC.Clear();
            txt_BC.Clear();
            txt_A.Clear();
            txt_B.Clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn thoát chương trình không?",
        "Xác nhận thoát",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // 
            }
        }
    }
}
