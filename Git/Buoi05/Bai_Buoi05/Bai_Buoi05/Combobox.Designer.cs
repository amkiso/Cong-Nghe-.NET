namespace Bai_Buoi05
{
    partial class Combobox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsb_UocSo = new System.Windows.Forms.ListBox();
            this.btn_tong = new System.Windows.Forms.Button();
            this.btn_Uoc_Chan = new System.Windows.Forms.Button();
            this.btn_SoNguyenTo = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txt_nhapso = new System.Windows.Forms.TextBox();
            this.cbxSo = new System.Windows.Forms.ComboBox();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_capnhat);
            this.groupBox1.Controls.Add(this.cbxSo);
            this.groupBox1.Controls.Add(this.txt_nhapso);
            this.groupBox1.Location = new System.Drawing.Point(38, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsb_UocSo);
            this.groupBox2.Location = new System.Drawing.Point(253, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // lsb_UocSo
            // 
            this.lsb_UocSo.FormattingEnabled = true;
            this.lsb_UocSo.Location = new System.Drawing.Point(17, 19);
            this.lsb_UocSo.Name = "lsb_UocSo";
            this.lsb_UocSo.Size = new System.Drawing.Size(182, 69);
            this.lsb_UocSo.TabIndex = 0;
            // 
            // btn_tong
            // 
            this.btn_tong.Location = new System.Drawing.Point(253, 132);
            this.btn_tong.Name = "btn_tong";
            this.btn_tong.Size = new System.Drawing.Size(205, 26);
            this.btn_tong.TabIndex = 2;
            this.btn_tong.Text = "Tổng các ước số";
            this.btn_tong.UseVisualStyleBackColor = true;
            // 
            // btn_Uoc_Chan
            // 
            this.btn_Uoc_Chan.Location = new System.Drawing.Point(253, 164);
            this.btn_Uoc_Chan.Name = "btn_Uoc_Chan";
            this.btn_Uoc_Chan.Size = new System.Drawing.Size(205, 26);
            this.btn_Uoc_Chan.TabIndex = 3;
            this.btn_Uoc_Chan.Text = "Số lượng các ước số chẵn";
            this.btn_Uoc_Chan.UseVisualStyleBackColor = true;
            // 
            // btn_SoNguyenTo
            // 
            this.btn_SoNguyenTo.Location = new System.Drawing.Point(253, 196);
            this.btn_SoNguyenTo.Name = "btn_SoNguyenTo";
            this.btn_SoNguyenTo.Size = new System.Drawing.Size(205, 26);
            this.btn_SoNguyenTo.TabIndex = 4;
            this.btn_SoNguyenTo.Text = "Số lượng các ước số nguyên tố";
            this.btn_SoNguyenTo.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(165, 196);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(63, 26);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // txt_nhapso
            // 
            this.txt_nhapso.Location = new System.Drawing.Point(19, 31);
            this.txt_nhapso.Name = "txt_nhapso";
            this.txt_nhapso.Size = new System.Drawing.Size(100, 20);
            this.txt_nhapso.TabIndex = 0;
            // 
            // cbxSo
            // 
            this.cbxSo.FormattingEnabled = true;
            this.cbxSo.Location = new System.Drawing.Point(19, 67);
            this.cbxSo.Name = "cbxSo";
            this.cbxSo.Size = new System.Drawing.Size(171, 21);
            this.cbxSo.TabIndex = 1;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(127, 31);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(67, 23);
            this.btn_capnhat.TabIndex = 2;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            // 
            // Combobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 240);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_SoNguyenTo);
            this.Controls.Add(this.btn_Uoc_Chan);
            this.Controls.Add(this.btn_tong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Combobox";
            this.Text = "Combobox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsb_UocSo;
        private System.Windows.Forms.Button btn_tong;
        private System.Windows.Forms.Button btn_Uoc_Chan;
        private System.Windows.Forms.Button btn_SoNguyenTo;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.ComboBox cbxSo;
        private System.Windows.Forms.TextBox txt_nhapso;
    }
}