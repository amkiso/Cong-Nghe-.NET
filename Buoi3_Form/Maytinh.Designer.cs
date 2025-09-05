namespace Buoi3_Form
{
    partial class Maytinh
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
            txt_A = new TextBox();
            txt_B = new TextBox();
            txt_KetQua = new TextBox();
            btn_Cong = new Button();
            btn_Tru = new Button();
            btn_Nhan = new Button();
            btn_chia = new Button();
            lbl_A = new Label();
            lbl_B = new Label();
            lbl_KetQua = new Label();
            errorProvider1 = new ErrorProvider(components);
            btn_Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txt_A
            // 
            txt_A.Location = new Point(77, 24);
            txt_A.Name = "txt_A";
            txt_A.Size = new Size(100, 23);
            txt_A.TabIndex = 0;
            txt_A.TextChanged += txt_A_TextChanged;
            txt_A.KeyPress += txt_A_KeyPress;
            // 
            // txt_B
            // 
            txt_B.Location = new Point(230, 24);
            txt_B.Name = "txt_B";
            txt_B.Size = new Size(100, 23);
            txt_B.TabIndex = 1;
            txt_B.TextChanged += txt_B_TextChanged;
            txt_B.KeyPress += txt_B_KeyPress;
            // 
            // txt_KetQua
            // 
            txt_KetQua.Location = new Point(77, 63);
            txt_KetQua.Name = "txt_KetQua";
            txt_KetQua.Size = new Size(253, 23);
            txt_KetQua.TabIndex = 2;
            // 
            // btn_Cong
            // 
            btn_Cong.Location = new Point(19, 92);
            btn_Cong.Name = "btn_Cong";
            btn_Cong.Size = new Size(52, 39);
            btn_Cong.TabIndex = 3;
            btn_Cong.Text = "+";
            btn_Cong.UseVisualStyleBackColor = true;
            btn_Cong.Click += btn_Cong_Click;
            // 
            // btn_Tru
            // 
            btn_Tru.Location = new Point(77, 92);
            btn_Tru.Name = "btn_Tru";
            btn_Tru.Size = new Size(53, 39);
            btn_Tru.TabIndex = 4;
            btn_Tru.Text = "-";
            btn_Tru.UseVisualStyleBackColor = true;
            btn_Tru.Click += btn_Tru_Click;
            // 
            // btn_Nhan
            // 
            btn_Nhan.Location = new Point(136, 92);
            btn_Nhan.Name = "btn_Nhan";
            btn_Nhan.Size = new Size(70, 39);
            btn_Nhan.TabIndex = 5;
            btn_Nhan.Text = "x";
            btn_Nhan.UseVisualStyleBackColor = true;
            btn_Nhan.Click += btn_Nhan_Click;
            // 
            // btn_chia
            // 
            btn_chia.Location = new Point(212, 92);
            btn_chia.Name = "btn_chia";
            btn_chia.Size = new Size(75, 39);
            btn_chia.TabIndex = 6;
            btn_chia.Text = "/";
            btn_chia.UseVisualStyleBackColor = true;
            btn_chia.Click += btn_chia_Click;
            // 
            // lbl_A
            // 
            lbl_A.AutoSize = true;
            lbl_A.Location = new Point(48, 32);
            lbl_A.Name = "lbl_A";
            lbl_A.Size = new Size(23, 15);
            lbl_A.TabIndex = 7;
            lbl_A.Text = "A=";
            // 
            // lbl_B
            // 
            lbl_B.AutoSize = true;
            lbl_B.Location = new Point(202, 32);
            lbl_B.Name = "lbl_B";
            lbl_B.Size = new Size(22, 15);
            lbl_B.TabIndex = 8;
            lbl_B.Text = "B=";
            // 
            // lbl_KetQua
            // 
            lbl_KetQua.AutoSize = true;
            lbl_KetQua.Location = new Point(19, 66);
            lbl_KetQua.Name = "lbl_KetQua";
            lbl_KetQua.Size = new Size(52, 15);
            lbl_KetQua.TabIndex = 9;
            lbl_KetQua.Text = "Kết Quả:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btn_Clear
            // 
            btn_Clear.FlatStyle = FlatStyle.System;
            btn_Clear.Location = new Point(293, 92);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(50, 39);
            btn_Clear.TabIndex = 10;
            btn_Clear.Text = "C";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += button1_Click;
            // 
            // Maytinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 143);
            Controls.Add(btn_Clear);
            Controls.Add(lbl_KetQua);
            Controls.Add(lbl_B);
            Controls.Add(lbl_A);
            Controls.Add(btn_chia);
            Controls.Add(btn_Nhan);
            Controls.Add(btn_Tru);
            Controls.Add(btn_Cong);
            Controls.Add(txt_KetQua);
            Controls.Add(txt_B);
            Controls.Add(txt_A);
            Name = "Maytinh";
            Text = "Maytinh";
            FormClosing += Maytinh_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_A;
        private TextBox txt_B;
        private TextBox txt_KetQua;
        private Button btn_Cong;
        private Button btn_Tru;
        private Button btn_Nhan;
        private Button btn_chia;
        private Label lbl_A;
        private Label lbl_B;
        private Label lbl_KetQua;
        private ErrorProvider errorProvider1;
        private Button btn_Clear;
    }
}