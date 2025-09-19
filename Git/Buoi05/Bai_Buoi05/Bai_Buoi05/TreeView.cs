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
    public partial class TreeView : Form
    {
        XulyTreeView xl = new XulyTreeView();
        public TreeView()
        {
            InitializeComponent();
            btn_Them_pb.Click += Btn_Them_pb_Click;
            btn_Xoa_pb.Click += Btn_Xoa_pb_Click;
            btn_them.Click += Btn_them_Click;
            
        }
        //thêm nhân viên vào phòng ban chỉ định
        private void Btn_them_Click(object sender, EventArgs e)
        {
            string ten =  txt_Hoten.Text +"("+ txt_maso.Text +")";
            //txt_DiaChi.Clear();
            //if(xl.Isvalid(treeview_pb.SelectedNode, txt_nhap_pb.Text))
            //{
            //    treeview_pb.Nodes.Add(txt_nhap_pb.Text);
            //}
            //else
            //{
            //    txt_nhap_pb.Text = "";
            //    MessageBox.Show("Phòng ban đã tồn tại", "Lỗi");
            //    txt_nhap_pb.Focus();
            //}
            //Lấy thông tin của combobox
            foreach (TreeNode item in treeview_pb.Nodes)
            {
                if (item.Text == cbxPhongBan.SelectedItem.ToString())
                {
                    item.Nodes.Add(ten);
                    item.Expand();
                    txt_Hoten.Clear();
                    txt_maso.Clear();
                    txt_DiaChi.Clear();
                    return;
                }
            }

        }
        //xóa phòng ban được chọn
        private void Btn_Xoa_pb_Click(object sender, EventArgs e)
        {
            if (treeview_pb.SelectedNode != null)
            {
                treeview_pb.Nodes.Remove(treeview_pb.SelectedNode);
                treeview_pb.SelectedNode = null;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phòng ban để xóa", "Lỗi");
            }
        }
        //Thêm phòng ban
        private void Btn_Them_pb_Click(object sender, EventArgs e)
        {
            if(xl.Isvalid(treeview_pb.SelectedNode,txt_nhap_pb.Text))
            {
                treeview_pb.Nodes.Add(txt_nhap_pb.Text);
            }
            else
            {
                txt_nhap_pb.Text = "";
                MessageBox.Show("Phòng ban đã tồn tại", "Lỗi");
                    txt_nhap_pb.Focus();
            }
        }

        private void TreeView_Load(object sender, EventArgs e)
        {
            string[] phongban = {"Giám đốc","Hành chính nhân sự","Kế toán","Kinh doanh","IT","Marketing"};
            foreach (var item in phongban)
            {
                treeview_pb.Nodes.Add(item);
                cbxPhongBan.Items.Add(item);
            }
            cbxPhongBan.SelectedIndex = 0;
        }
    }
}
