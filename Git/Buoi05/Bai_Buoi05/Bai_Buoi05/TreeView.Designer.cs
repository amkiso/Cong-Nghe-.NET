namespace Bai_Buoi05
{
    partial class TreeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rgb_PhongBan = new System.Windows.Forms.GroupBox();
            this.btn_Xoa_pb = new System.Windows.Forms.Button();
            this.btn_Them_pb = new System.Windows.Forms.Button();
            this.txt_nhap_pb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.treeview_pb = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_manv = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_Hoten = new System.Windows.Forms.Label();
            this.txt_maso = new System.Windows.Forms.TextBox();
            this.cbxPhongBan = new System.Windows.Forms.ComboBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_Hoten = new System.Windows.Forms.TextBox();
            this.lbl_phongban = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.rgb_PhongBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // rgb_PhongBan
            // 
            this.rgb_PhongBan.Controls.Add(this.btn_Xoa_pb);
            this.rgb_PhongBan.Controls.Add(this.btn_Them_pb);
            this.rgb_PhongBan.Controls.Add(this.txt_nhap_pb);
            this.rgb_PhongBan.Controls.Add(this.label5);
            this.rgb_PhongBan.Controls.Add(this.treeview_pb);
            this.rgb_PhongBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgb_PhongBan.Location = new System.Drawing.Point(14, 18);
            this.rgb_PhongBan.Name = "rgb_PhongBan";
            this.rgb_PhongBan.Size = new System.Drawing.Size(245, 392);
            this.rgb_PhongBan.TabIndex = 0;
            this.rgb_PhongBan.TabStop = false;
            this.rgb_PhongBan.Text = "Phòng ban";
            // 
            // btn_Xoa_pb
            // 
            this.btn_Xoa_pb.Location = new System.Drawing.Point(85, 349);
            this.btn_Xoa_pb.Name = "btn_Xoa_pb";
            this.btn_Xoa_pb.Size = new System.Drawing.Size(142, 23);
            this.btn_Xoa_pb.TabIndex = 10;
            this.btn_Xoa_pb.Text = "Xóa phòng ban";
            this.btn_Xoa_pb.UseVisualStyleBackColor = true;
            // 
            // btn_Them_pb
            // 
            this.btn_Them_pb.Location = new System.Drawing.Point(85, 320);
            this.btn_Them_pb.Name = "btn_Them_pb";
            this.btn_Them_pb.Size = new System.Drawing.Size(142, 23);
            this.btn_Them_pb.TabIndex = 9;
            this.btn_Them_pb.Text = "Thêm phòng ban";
            this.btn_Them_pb.UseVisualStyleBackColor = true;
            // 
            // txt_nhap_pb
            // 
            this.txt_nhap_pb.Location = new System.Drawing.Point(85, 292);
            this.txt_nhap_pb.Name = "txt_nhap_pb";
            this.txt_nhap_pb.Size = new System.Drawing.Size(142, 22);
            this.txt_nhap_pb.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phòng ban:";
            // 
            // treeview_pb
            // 
            this.treeview_pb.Location = new System.Drawing.Point(14, 26);
            this.treeview_pb.Name = "treeview_pb";
            this.treeview_pb.Size = new System.Drawing.Size(213, 253);
            this.treeview_pb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(280, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỒ SƠ NHÂN VIÊN";
            // 
            // lbl_manv
            // 
            this.lbl_manv.AutoSize = true;
            this.lbl_manv.Location = new System.Drawing.Point(282, 61);
            this.lbl_manv.Name = "lbl_manv";
            this.lbl_manv.Size = new System.Drawing.Size(38, 13);
            this.lbl_manv.TabIndex = 2;
            this.lbl_manv.Text = "Mã Số";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(285, 115);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(40, 13);
            this.lbl_DiaChi.TabIndex = 3;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // lbl_Hoten
            // 
            this.lbl_Hoten.AutoSize = true;
            this.lbl_Hoten.Location = new System.Drawing.Point(473, 61);
            this.lbl_Hoten.Name = "lbl_Hoten";
            this.lbl_Hoten.Size = new System.Drawing.Size(46, 13);
            this.lbl_Hoten.TabIndex = 4;
            this.lbl_Hoten.Text = "Họ Tên:";
            // 
            // txt_maso
            // 
            this.txt_maso.Location = new System.Drawing.Point(350, 58);
            this.txt_maso.Name = "txt_maso";
            this.txt_maso.Size = new System.Drawing.Size(100, 20);
            this.txt_maso.TabIndex = 6;
            // 
            // cbxPhongBan
            // 
            this.cbxPhongBan.FormattingEnabled = true;
            this.cbxPhongBan.Location = new System.Drawing.Point(350, 165);
            this.cbxPhongBan.Name = "cbxPhongBan";
            this.cbxPhongBan.Size = new System.Drawing.Size(348, 21);
            this.cbxPhongBan.TabIndex = 7;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(350, 206);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Location = new System.Drawing.Point(525, 58);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(173, 20);
            this.txt_Hoten.TabIndex = 9;
            // 
            // lbl_phongban
            // 
            this.lbl_phongban.AutoSize = true;
            this.lbl_phongban.Location = new System.Drawing.Point(285, 165);
            this.lbl_phongban.Name = "lbl_phongban";
            this.lbl_phongban.Size = new System.Drawing.Size(59, 13);
            this.lbl_phongban.TabIndex = 10;
            this.lbl_phongban.Text = "Phòng ban";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(350, 115);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(348, 20);
            this.txt_DiaChi.TabIndex = 11;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(444, 206);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 12;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 418);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.lbl_phongban);
            this.Controls.Add(this.txt_Hoten);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.cbxPhongBan);
            this.Controls.Add(this.txt_maso);
            this.Controls.Add(this.lbl_Hoten);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_manv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rgb_PhongBan);
            this.Name = "TreeView";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.TreeView_Load);
            this.rgb_PhongBan.ResumeLayout(false);
            this.rgb_PhongBan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox rgb_PhongBan;
        private System.Windows.Forms.TreeView treeview_pb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_manv;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_Hoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maso;
        private System.Windows.Forms.ComboBox cbxPhongBan;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_Xoa_pb;
        private System.Windows.Forms.Button btn_Them_pb;
        private System.Windows.Forms.TextBox txt_nhap_pb;
        private System.Windows.Forms.TextBox txt_Hoten;
        private System.Windows.Forms.Label lbl_phongban;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Button btn_thoat;
    }
}