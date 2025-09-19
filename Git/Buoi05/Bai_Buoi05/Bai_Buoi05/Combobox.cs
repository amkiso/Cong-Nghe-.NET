using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Buoi05
{

    public partial class Combobox : Form
    {
        Xuly xl = new Xuly();

        public Combobox()
        {
            InitializeComponent();
            btn_capnhat.Click += Btn_capnhat_Click;
            btn_tong.Click += Btn_tong_Click;
            btn_Uoc_Chan.Click += Btn_Uoc_Chan_Click;
            cbxSo.SelectedIndexChanged += CbxSo_SelectedIndexChanged;
            btn_SoNguyenTo.Click += Btn_SoNguyenTo_Click;
        }

        //Sự kiện Lựa chọn trong combobox thay đổi ?
        private void CbxSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lấy giá trị
            //gửi về class xuly
            //nhận kết quả
            //Hiển thị
            lsb_UocSo.Items.Clear();
            xl.TimUocSo(int.Parse(cbxSo.Items[cbxSo.SelectedIndex].ToString()));
            foreach (var item in xl.uocSo)
            {
                
                lsb_UocSo.Items.Add(item);
            }
        }
        //Hiển thị số lượng số nguyên tố có trong listbox(là ước số của số đang được chọn trong combobox)
        private void Btn_SoNguyenTo_Click(object sender, EventArgs e)
        {
            try {
                if (xl.SLSoNguyenTo() == 0)
                {
                    MessageBox.Show("Không có ước số nguyên tố", "Kết quả");
                }
                else
                {
                    MessageBox.Show("Số lượng các ước số nguyên tố là: " + xl.SLSoNguyenTo(), "Kết quả");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi: Bạn chưa chọn số trong combobox","Thông báo");
            }
        }
        //Hiển thị số lượng số chẵn có trong listbox(là ước số của số đang được chọn trong combobox)
        private void Btn_Uoc_Chan_Click(object sender, EventArgs e)
        {
            try { if (xl.SoluongUocSoChan() == 0)
                {
                    MessageBox.Show("Không có ước số chẵn", "Kết quả");
                }
                else
                {
                    MessageBox.Show("Số lượng các ước số chẵn là: " + xl.SoluongUocSoChan(),"Kết quả");
                }
            }
            catch { MessageBox.Show(" Bạn chưa chọn số trong combobox", "Thông báo"); }
        }
        //Hiện thị tổng các ước số trong list
        private void Btn_tong_Click(object sender, EventArgs e)
        {
            try { MessageBox.Show("Tổng các ước số là: " + xl.TongUocSo(), "Kết quả"); }
            catch { MessageBox.Show(" Bạn chưa chọn số trong combobox hoặc ước số rỗng", "Thông báo"); }
        }
        //add số vừa nhập ở textbox vào combobox
        private void Btn_capnhat_Click(object sender, EventArgs e)
        {
            if (cbxSo.Items.Count == 0)
            {
                cbxSo.Items.Add(int.Parse(txt_nhapso.Text));
            }
            else
            {
                for (int i = 0; i < cbxSo.Items.Count; i++)
                {
                    xl.ComboBox = new List<int>();
                    xl.ComboBox.Add((int)cbxSo.Items[i]);
                }
                if (xl.KT(txt_nhapso.Text))
                {
                    cbxSo.Items.Add(int.Parse(txt_nhapso.Text));
                }
                else
                {
                    MessageBox.Show("Số bạn nhập đã tồn tại trong combobox");
                }
            }
        }
    }
}
