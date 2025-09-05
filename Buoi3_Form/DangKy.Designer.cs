namespace Buoi3_Form
{
    partial class DangKy
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
            components = new System.ComponentModel.Container();
            lbl_Header = new Label();
            lbl_UserName = new Label();
            lbl_Email = new Label();
            lbl_MatKhau = new Label();
            lbl_ReMatKhau = new Label();
            lbl_User_BatBuoc = new Label();
            lbl_Email_batBuoc = new Label();
            lbl_MatKhau_batBuoc = new Label();
            txt_UserName = new TextBox();
            txt_Email = new TextBox();
            txt_MatKhau = new TextBox();
            txt_ReMatKhau = new TextBox();
            btn_Sumit = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Header
            // 
            lbl_Header.AutoSize = true;
            lbl_Header.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbl_Header.ForeColor = SystemColors.MenuHighlight;
            lbl_Header.Location = new Point(100, 24);
            lbl_Header.Name = "lbl_Header";
            lbl_Header.Size = new Size(200, 30);
            lbl_Header.TabIndex = 0;
            lbl_Header.Text = "Đăng ký tài khoản";
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.Location = new Point(33, 83);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(85, 15);
            lbl_UserName.TabIndex = 1;
            lbl_UserName.Text = "Tên đăng nhập";
            lbl_UserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(43, 109);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(75, 15);
            lbl_Email.TabIndex = 2;
            lbl_Email.Text = "Địa chỉ email";
            // 
            // lbl_MatKhau
            // 
            lbl_MatKhau.AutoSize = true;
            lbl_MatKhau.Location = new Point(61, 141);
            lbl_MatKhau.Name = "lbl_MatKhau";
            lbl_MatKhau.Size = new Size(57, 15);
            lbl_MatKhau.TabIndex = 3;
            lbl_MatKhau.Text = "Mật khẩu";
            // 
            // lbl_ReMatKhau
            // 
            lbl_ReMatKhau.AutoSize = true;
            lbl_ReMatKhau.Location = new Point(12, 170);
            lbl_ReMatKhau.Name = "lbl_ReMatKhau";
            lbl_ReMatKhau.Size = new Size(109, 15);
            lbl_ReMatKhau.TabIndex = 4;
            lbl_ReMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // lbl_User_BatBuoc
            // 
            lbl_User_BatBuoc.AutoSize = true;
            lbl_User_BatBuoc.Location = new Point(297, 80);
            lbl_User_BatBuoc.Name = "lbl_User_BatBuoc";
            lbl_User_BatBuoc.Size = new Size(20, 15);
            lbl_User_BatBuoc.TabIndex = 5;
            lbl_User_BatBuoc.Text = "(*)";
            // 
            // lbl_Email_batBuoc
            // 
            lbl_Email_batBuoc.AutoSize = true;
            lbl_Email_batBuoc.Location = new Point(297, 109);
            lbl_Email_batBuoc.Name = "lbl_Email_batBuoc";
            lbl_Email_batBuoc.Size = new Size(20, 15);
            lbl_Email_batBuoc.TabIndex = 8;
            lbl_Email_batBuoc.Text = "(*)";
            // 
            // lbl_MatKhau_batBuoc
            // 
            lbl_MatKhau_batBuoc.AutoSize = true;
            lbl_MatKhau_batBuoc.Location = new Point(297, 138);
            lbl_MatKhau_batBuoc.Name = "lbl_MatKhau_batBuoc";
            lbl_MatKhau_batBuoc.Size = new Size(20, 15);
            lbl_MatKhau_batBuoc.TabIndex = 9;
            lbl_MatKhau_batBuoc.Text = "(*)";
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(124, 80);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(167, 23);
            txt_UserName.TabIndex = 10;
            txt_UserName.Leave += txt_UserName_Leave;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(124, 109);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(167, 23);
            txt_Email.TabIndex = 11;
            txt_Email.Leave += txt_Email_Leave;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(124, 138);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(167, 23);
            txt_MatKhau.TabIndex = 12;
            txt_MatKhau.Leave += txt_MatKhau_Leave;
            // 
            // txt_ReMatKhau
            // 
            txt_ReMatKhau.Location = new Point(124, 167);
            txt_ReMatKhau.Name = "txt_ReMatKhau";
            txt_ReMatKhau.Size = new Size(167, 23);
            txt_ReMatKhau.TabIndex = 13;
            // 
            // btn_Sumit
            // 
            btn_Sumit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Sumit.ForeColor = SystemColors.MenuHighlight;
            btn_Sumit.Location = new Point(124, 196);
            btn_Sumit.Name = "btn_Sumit";
            btn_Sumit.Size = new Size(167, 45);
            btn_Sumit.TabIndex = 14;
            btn_Sumit.Text = "Đăng ký";
            btn_Sumit.UseVisualStyleBackColor = true;
            btn_Sumit.Click += btn_Sumit_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 275);
            Controls.Add(btn_Sumit);
            Controls.Add(txt_ReMatKhau);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_Email);
            Controls.Add(txt_UserName);
            Controls.Add(lbl_MatKhau_batBuoc);
            Controls.Add(lbl_Email_batBuoc);
            Controls.Add(lbl_User_BatBuoc);
            Controls.Add(lbl_ReMatKhau);
            Controls.Add(lbl_MatKhau);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_UserName);
            Controls.Add(lbl_Header);
            Name = "DangKy";
            Text = "DangKy";
            FormClosing += DangKy_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Header;
        private Label lbl_UserName;
        private Label lbl_Email;
        private Label lbl_MatKhau;
        private Label lbl_ReMatKhau;
        private Label lbl_User_BatBuoc;
        private Label lbl_Email_batBuoc;
        private Label lbl_MatKhau_batBuoc;
        private TextBox txt_UserName;
        private TextBox txt_Email;
        private TextBox txt_MatKhau;
        private TextBox txt_ReMatKhau;
        private Button btn_Sumit;
        private ErrorProvider errorProvider1;
    }
}