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
    public partial class Form1 : Form
    {
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
            btn_to_right.Click += Btn_to_right_Click;
            btn_to_left.Click += Btn_to_left_Click;
            btn_all_Right.Click += Btn_all_Right_Click;
            btn_all_to_left.Click += Btn_all_to_left_Click;
            btn_Tao_List_Trai.Click += Btn_Tao_List_Trai_Click;
            btn_Tao_list_phai.Click += Btn_Tao_list_phai_Click;
            btn_xoa.Click += Btn_xoa_Click;
        }

        private void Btn_Tao_list_phai_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {

                lsb_phai.Items.Add(rd.Next(1, 100));
            }
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            lsb_phai.Items.Clear();
            lsb_trai.Items.Clear();
        }

        private void Btn_Tao_List_Trai_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= 10; i++)
            {
                
                lsb_trai.Items.Add(rd.Next(1,100));
            }
        }

        private void Btn_all_to_left_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsb_phai.Items.Count; i++)
            {
                lsb_trai.Items.Add(lsb_phai.Items[i]);
            }
            lsb_phai.Items.Clear();
        }

        private void Btn_all_Right_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lsb_trai.Items.Count; i++)
            {
                lsb_phai.Items.Add(lsb_trai.Items[i]);
            }
            lsb_trai.Items.Clear();
        }

        private void Btn_to_left_Click(object sender, EventArgs e)
        {
            try
            {
                lsb_trai.Items.Add(lsb_phai.SelectedItem);
                lsb_phai.Items.Remove(lsb_phai.SelectedItem);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn ít nhất một phần tử để chuyển !","Thông báo");
            }
        }

        private void Btn_to_right_Click(object sender, EventArgs e)
        {
            try {
                lsb_phai.Items.Add(lsb_trai.SelectedItem);
                lsb_trai.Items.Remove(lsb_trai.SelectedItem);
            } catch { MessageBox.Show("Vui lòng chọn ít nhất một phần tử để chuyển !", "Thông báo"); }
            
        }
    }
}
