using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4
{
    public partial class MangSoNguyen : Form
    {
        XuLyMang xl = new XuLyMang();
        
        public MangSoNguyen()
        {
            InitializeComponent();
        }

        private void MangSoNguyen_Load(object sender, EventArgs e)
        {

        }

        private void btn_Nhapmang_Click(object sender, EventArgs e)
        {
            
            txt_mang.Text =string.Join(" ",xl.TaoMangNgauNhien());
        }

        private void btn_ThucHien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mang.Text))
            {
                MessageBox.Show("Vui lòng tạo mảng trước", "Thông báo");
                return;
            }

            //sắp xếp mảng
            if (rdb_SXGiam.Checked)
            {
                txt_KqSapXep.Text = string.Join(" ", xl.SapXepGiam());

            }
            else if (rdb_SXTang.Checked)
            {
                txt_KqSapXep.Text = string.Join(" ", xl.SapXepTang());
            }
            //Tìm kiếm
            if (rdb_Gia_Tri_Can_Tim.Checked)
            {
                if (int.TryParse(txt_Gt_TimKiem.Text, out _))
                {
                    txt_KqTimKiem.Text = xl.TimGiaTri(int.Parse(txt_Gt_TimKiem.Text)).ToString();
                }
                else MessageBox.Show("Vui lòng nhập giá trị hợp lệ !", "Thông báo");
            }
            else if (rdb_VT_Can_Tim.Checked)
            {
                if (int.TryParse(txt_Vt_TimKiem.Text, out _))
                {
                    txt_KqTimKiem.Text = xl.VtGTCanTim(int.Parse(txt_Vt_TimKiem.Text)).ToString();
                }
                else MessageBox.Show("Vui lòng nhập giá trị hợp lệ !", "Thông báo");
            }
            //Xóa giá trị
            if (rdb_Tim_Xoa_Gt.Checked)
            {
                if (xl.XoaGiaTri(int.Parse(txt_Gia_Tri_Can_Xoa.Text)))
                {
                    lbl_Xoa.Text = "Đã Xóa thành công !";
                    txt_mang.Text = string.Join(" ", xl.MangHienTai);
                }
                else lbl_Xoa.Text = "không tìm thấy giá trị cần xóa !";
            }
            else if (rdb_VT_Xoa.Checked)
            {
                if (xl.XoaViTri(int.Parse(txt_Vi_Tri_Can_Xoa.Text)))
                {
                    lbl_Xoa.Text = "Đã Xóa thành công !";
                    txt_mang.Text = string.Join(" ", xl.MangHienTai);
                }
                else lbl_Xoa.Text = "Vị Trí nhập vào không hợp lệ !";
            }
            //Thêm giá trị vào mảng
            if (rdb_Gt_Can_Them.Checked)
            {
                txt_KqSapXep.Text = string.Join(" ", xl.Themtaivt(int.Parse(txt_Gt_CanThem.Text), int.Parse(txt_Vt_CanThem.Text)));

            }
            //Thay thế
            if (rdb_Gt_ThayThe.Checked)
            {
                if (int.TryParse(txt_SoThayThe.Text, out _) || int.TryParse(txt_GtThayThe.Text, out _))
                {
                    if (xl.ThayTheGt(int.Parse(txt_GtThayThe.Text), int.Parse(txt_SoThayThe.Text)))
                    {
                        MessageBox.Show("Đã thay thế thành công !", "Thông báo");
                        txt_KqSapXep.Text = string.Join(" ", xl.MangHienTai);
                    }
                    else MessageBox.Show("Không tìm thấy giá trị cần thay thế !", "Thông báo");
                }
                else { MessageBox.Show("Xin vui lòng nhập vào các giá trị hợp lệ !", "Thông báo"); }
            }
            else if (rdb_Vt_ThayThe.Checked)
            {
                if (int.TryParse(txt_SoThayThe.Text, out _) || int.TryParse(txt_VtThayThe.Text, out _))
                {
                    if (xl.ThayTheViTri(int.Parse(txt_VtThayThe.Text), int.Parse(txt_SoThayThe.Text)))
                    {
                        MessageBox.Show("Đã thay thế thành công !", "Thông báo");
                        txt_KqSapXep.Text = string.Join(" ", xl.MangHienTai);
                    }
                    else MessageBox.Show("Vị trí bạn chọn không hợp lệ !", "Thông báo");
                }
                else { MessageBox.Show("Xin vui lòng nhập vào các giá trị hợp lệ !", "Thông báo"); }
            
            }
           

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn thoát chương trình?",
        "Xác nhận thoát",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach(Control crtl in this.Controls)
            {
                if(crtl is TextBox)
                {
                    if(((TextBox)crtl).Name != "txt_mang")
                    {
                        ((TextBox)crtl).Clear();
                    }
                }
                else if (crtl is GroupBox) 
                {
                    foreach (Control subCtrl in crtl.Controls)
                    {
                        if (subCtrl is RadioButton)
                        {
                            ((RadioButton)subCtrl).Checked = false;
                        }
                        else if (subCtrl is TextBox)
                        {
                            ((TextBox)subCtrl).Clear();
                        }
                    }
                }
            }
            lbl_Xoa.Text = "Cần sắp xếp tăng";
            lbl_Them.Text = "Cần sắp xếp tăng";
        }

        private void grb_TimKiem_Enter(object sender, EventArgs e)
        {
            txt_KqTimKiem.Clear();
            txt_Gt_TimKiem.Clear();
            txt_Vt_TimKiem.Clear();
        }

        private void btn_TinhTong_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Sum_Chan.Text = xl.TongChan();
                txt_Sum_Le.Text = xl.TongLe();
                txt_Sum_Mang.Text = xl.TongMang();
            }
            catch { MessageBox.Show("Bạn cần tạo một mảng trước !", "Thông báo"); }
            
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                txt_MaxValue.Text = xl.SoLonNhat();
                txt_MinValue.Text = xl.SoNhoNhat();
            }
            catch { MessageBox.Show("Bạn cần tạo một mảng trước !", "Thông báo"); }
            
        }

        private void grb_Xoa_Enter(object sender, EventArgs e)
        {
            lbl_Xoa.Text = "...";
            txt_Vi_Tri_Can_Xoa.Clear();
            txt_Gia_Tri_Can_Xoa.Clear();
            rdb_Tim_Xoa_Gt.Checked = false;
            rdb_VT_Xoa.Checked = false;
        }
    }
}
