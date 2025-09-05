namespace Buoi3_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txt_Name = new TextBox();
            txt_NamSinh = new TextBox();
            lbl_Ten = new Label();
            lbl_NamSinh = new Label();
            btn_HienThi = new Button();
            btn_Xoa = new Button();
            btn_Thoat = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(113, 30);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(218, 23);
            txt_Name.TabIndex = 0;
            txt_Name.TextChanged += textBox1_TextChanged;
            txt_Name.Leave += txt_Name_Leave;
            // 
            // txt_NamSinh
            // 
            txt_NamSinh.Location = new Point(113, 72);
            txt_NamSinh.Name = "txt_NamSinh";
            txt_NamSinh.Size = new Size(218, 23);
            txt_NamSinh.TabIndex = 1;
            txt_NamSinh.TextChanged += txt_NamSinh_TextChanged;
            // 
            // lbl_Ten
            // 
            lbl_Ten.AutoSize = true;
            lbl_Ten.Location = new Point(49, 33);
            lbl_Ten.Name = "lbl_Ten";
            lbl_Ten.Size = new Size(58, 15);
            lbl_Ten.TabIndex = 2;
            lbl_Ten.Text = "Họ và tên";
            // 
            // lbl_NamSinh
            // 
            lbl_NamSinh.AutoSize = true;
            lbl_NamSinh.Location = new Point(49, 75);
            lbl_NamSinh.Name = "lbl_NamSinh";
            lbl_NamSinh.Size = new Size(58, 15);
            lbl_NamSinh.TabIndex = 3;
            lbl_NamSinh.Text = "Năm sinh";
            lbl_NamSinh.Click += label2_Click;
            // 
            // btn_HienThi
            // 
            btn_HienThi.Location = new Point(49, 117);
            btn_HienThi.Name = "btn_HienThi";
            btn_HienThi.Size = new Size(75, 23);
            btn_HienThi.TabIndex = 4;
            btn_HienThi.Text = "Hiển Thị";
            btn_HienThi.UseVisualStyleBackColor = false;
            btn_HienThi.Click += btn_HienThi_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(154, 117);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(75, 23);
            btn_Xoa.TabIndex = 5;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Thoat
            // 
            errorProvider1.SetIconAlignment(btn_Thoat, ErrorIconAlignment.TopLeft);
            btn_Thoat.Location = new Point(256, 117);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 6;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = false;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 162);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_HienThi);
            Controls.Add(lbl_NamSinh);
            Controls.Add(lbl_Ten);
            Controls.Add(txt_NamSinh);
            Controls.Add(txt_Name);
            Name = "Form1";
            Text = "My name project";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Name;
        private TextBox txt_NamSinh;
        private Label lbl_Ten;
        private Label lbl_NamSinh;
        private Button btn_HienThi;
        private Button btn_Xoa;
        private Button btn_Thoat;
        private ErrorProvider errorProvider1;
    }
}
