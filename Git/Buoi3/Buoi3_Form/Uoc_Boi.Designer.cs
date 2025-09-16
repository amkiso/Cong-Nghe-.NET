namespace Buoi3_Form
{
    partial class Uoc_Boi
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
            txt_A = new TextBox();
            txt_B = new TextBox();
            txt_UC = new TextBox();
            txt_BC = new TextBox();
            btn_ThucHien = new Button();
            btn_Clear = new Button();
            btn_Thoat = new Button();
            lbl_A = new Label();
            lbl_B = new Label();
            lbl_UC = new Label();
            lbl_BC = new Label();
            lbl_Header = new Label();
            SuspendLayout();
            // 
            // txt_A
            // 
            txt_A.Location = new Point(201, 130);
            txt_A.Margin = new Padding(6);
            txt_A.Name = "txt_A";
            txt_A.Size = new Size(205, 39);
            txt_A.TabIndex = 0;
            // 
            // txt_B
            // 
            txt_B.Location = new Point(201, 192);
            txt_B.Margin = new Padding(6);
            txt_B.Name = "txt_B";
            txt_B.Size = new Size(205, 39);
            txt_B.TabIndex = 1;
            // 
            // txt_UC
            // 
            txt_UC.Location = new Point(306, 254);
            txt_UC.Margin = new Padding(6);
            txt_UC.Name = "txt_UC";
            txt_UC.ReadOnly = true;
            txt_UC.Size = new Size(99, 39);
            txt_UC.TabIndex = 2;
            // 
            // txt_BC
            // 
            txt_BC.Location = new Point(306, 316);
            txt_BC.Margin = new Padding(6);
            txt_BC.Name = "txt_BC";
            txt_BC.ReadOnly = true;
            txt_BC.Size = new Size(99, 39);
            txt_BC.TabIndex = 3;
            // 
            // btn_ThucHien
            // 
            btn_ThucHien.Location = new Point(32, 375);
            btn_ThucHien.Margin = new Padding(6);
            btn_ThucHien.Name = "btn_ThucHien";
            btn_ThucHien.Size = new Size(139, 49);
            btn_ThucHien.TabIndex = 4;
            btn_ThucHien.Text = "Thực hiện";
            btn_ThucHien.UseVisualStyleBackColor = true;
            btn_ThucHien.Click += btn_ThucHien_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(182, 378);
            btn_Clear.Margin = new Padding(6);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(139, 49);
            btn_Clear.TabIndex = 5;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(332, 378);
            btn_Thoat.Margin = new Padding(6);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(139, 49);
            btn_Thoat.TabIndex = 6;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // lbl_A
            // 
            lbl_A.AutoSize = true;
            lbl_A.Location = new Point(74, 137);
            lbl_A.Margin = new Padding(6, 0, 6, 0);
            lbl_A.Name = "lbl_A";
            lbl_A.Size = new Size(130, 32);
            lbl_A.TabIndex = 7;
            lbl_A.Text = "Nhập số A:";
            // 
            // lbl_B
            // 
            lbl_B.AutoSize = true;
            lbl_B.Location = new Point(74, 198);
            lbl_B.Margin = new Padding(6, 0, 6, 0);
            lbl_B.Name = "lbl_B";
            lbl_B.Size = new Size(129, 32);
            lbl_B.TabIndex = 8;
            lbl_B.Text = "Nhập số B:";
            // 
            // lbl_UC
            // 
            lbl_UC.AutoSize = true;
            lbl_UC.Location = new Point(63, 261);
            lbl_UC.Margin = new Padding(6, 0, 6, 0);
            lbl_UC.Name = "lbl_UC";
            lbl_UC.Size = new Size(231, 32);
            lbl_UC.TabIndex = 9;
            lbl_UC.Text = "Ước chung lớn nhất:";
            // 
            // lbl_BC
            // 
            lbl_BC.AutoSize = true;
            lbl_BC.Location = new Point(63, 316);
            lbl_BC.Margin = new Padding(6, 0, 6, 0);
            lbl_BC.Name = "lbl_BC";
            lbl_BC.Size = new Size(231, 32);
            lbl_BC.TabIndex = 10;
            lbl_BC.Text = "Bội chung nhỏ nhất:";
            // 
            // lbl_Header
            // 
            lbl_Header.AutoSize = true;
            lbl_Header.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbl_Header.ForeColor = Color.Red;
            lbl_Header.Location = new Point(32, 47);
            lbl_Header.Margin = new Padding(6, 0, 6, 0);
            lbl_Header.Name = "lbl_Header";
            lbl_Header.Size = new Size(489, 47);
            lbl_Header.TabIndex = 11;
            lbl_Header.Text = "Ước số chung - Bội số chung";
            // 
            // Uoc_Boi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 478);
            Controls.Add(lbl_Header);
            Controls.Add(lbl_BC);
            Controls.Add(lbl_UC);
            Controls.Add(lbl_B);
            Controls.Add(lbl_A);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_Clear);
            Controls.Add(btn_ThucHien);
            Controls.Add(txt_BC);
            Controls.Add(txt_UC);
            Controls.Add(txt_B);
            Controls.Add(txt_A);
            Margin = new Padding(6);
            Name = "Uoc_Boi";
            Text = "Uoc_Boi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_A;
        private TextBox txt_B;
        private TextBox txt_UC;
        private TextBox txt_BC;
        private Button btn_ThucHien;
        private Button btn_Clear;
        private Button btn_Thoat;
        private Label lbl_A;
        private Label lbl_B;
        private Label lbl_UC;
        private Label lbl_BC;
        private Label lbl_Header;
    }
}