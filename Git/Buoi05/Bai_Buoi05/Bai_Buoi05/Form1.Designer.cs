namespace Bai_Buoi05
{
    partial class Form1
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
            this.lsb_trai = new System.Windows.Forms.ListBox();
            this.lsb_phai = new System.Windows.Forms.ListBox();
            this.btn_to_right = new System.Windows.Forms.Button();
            this.btn_all_Right = new System.Windows.Forms.Button();
            this.btn_all_to_left = new System.Windows.Forms.Button();
            this.btn_to_left = new System.Windows.Forms.Button();
            this.btn_Tao_List_Trai = new System.Windows.Forms.Button();
            this.btn_Tao_list_phai = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsb_trai
            // 
            this.lsb_trai.FormattingEnabled = true;
            this.lsb_trai.Location = new System.Drawing.Point(60, 31);
            this.lsb_trai.Name = "lsb_trai";
            this.lsb_trai.Size = new System.Drawing.Size(273, 355);
            this.lsb_trai.TabIndex = 0;
            // 
            // lsb_phai
            // 
            this.lsb_phai.FormattingEnabled = true;
            this.lsb_phai.Location = new System.Drawing.Point(460, 31);
            this.lsb_phai.Name = "lsb_phai";
            this.lsb_phai.Size = new System.Drawing.Size(273, 355);
            this.lsb_phai.TabIndex = 1;
            // 
            // btn_to_right
            // 
            this.btn_to_right.Location = new System.Drawing.Point(360, 129);
            this.btn_to_right.Name = "btn_to_right";
            this.btn_to_right.Size = new System.Drawing.Size(75, 23);
            this.btn_to_right.TabIndex = 2;
            this.btn_to_right.Text = ">";
            this.btn_to_right.UseVisualStyleBackColor = true;
            // 
            // btn_all_Right
            // 
            this.btn_all_Right.Location = new System.Drawing.Point(360, 169);
            this.btn_all_Right.Name = "btn_all_Right";
            this.btn_all_Right.Size = new System.Drawing.Size(75, 23);
            this.btn_all_Right.TabIndex = 3;
            this.btn_all_Right.Text = ">>";
            this.btn_all_Right.UseVisualStyleBackColor = true;
            // 
            // btn_all_to_left
            // 
            this.btn_all_to_left.Location = new System.Drawing.Point(360, 251);
            this.btn_all_to_left.Name = "btn_all_to_left";
            this.btn_all_to_left.Size = new System.Drawing.Size(75, 23);
            this.btn_all_to_left.TabIndex = 5;
            this.btn_all_to_left.Text = "<<";
            this.btn_all_to_left.UseVisualStyleBackColor = true;
            // 
            // btn_to_left
            // 
            this.btn_to_left.Location = new System.Drawing.Point(360, 211);
            this.btn_to_left.Name = "btn_to_left";
            this.btn_to_left.Size = new System.Drawing.Size(75, 23);
            this.btn_to_left.TabIndex = 4;
            this.btn_to_left.Text = "<";
            this.btn_to_left.UseVisualStyleBackColor = true;
            // 
            // btn_Tao_List_Trai
            // 
            this.btn_Tao_List_Trai.Location = new System.Drawing.Point(140, 392);
            this.btn_Tao_List_Trai.Name = "btn_Tao_List_Trai";
            this.btn_Tao_List_Trai.Size = new System.Drawing.Size(93, 45);
            this.btn_Tao_List_Trai.TabIndex = 6;
            this.btn_Tao_List_Trai.Text = "Tạo list trái";
            this.btn_Tao_List_Trai.UseVisualStyleBackColor = true;
            // 
            // btn_Tao_list_phai
            // 
            this.btn_Tao_list_phai.Location = new System.Drawing.Point(564, 393);
            this.btn_Tao_list_phai.Name = "btn_Tao_list_phai";
            this.btn_Tao_list_phai.Size = new System.Drawing.Size(93, 45);
            this.btn_Tao_list_phai.TabIndex = 7;
            this.btn_Tao_list_phai.Text = "Tạo list phải";
            this.btn_Tao_list_phai.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.White;
            this.btn_xoa.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_xoa.FlatAppearance.BorderSize = 3;
            this.btn_xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_xoa.Location = new System.Drawing.Point(360, 292);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 45);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa tất cả";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_Tao_list_phai);
            this.Controls.Add(this.btn_Tao_List_Trai);
            this.Controls.Add(this.btn_all_to_left);
            this.Controls.Add(this.btn_to_left);
            this.Controls.Add(this.btn_all_Right);
            this.Controls.Add(this.btn_to_right);
            this.Controls.Add(this.lsb_phai);
            this.Controls.Add(this.lsb_trai);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_trai;
        private System.Windows.Forms.ListBox lsb_phai;
        private System.Windows.Forms.Button btn_to_right;
        private System.Windows.Forms.Button btn_all_Right;
        private System.Windows.Forms.Button btn_all_to_left;
        private System.Windows.Forms.Button btn_to_left;
        private System.Windows.Forms.Button btn_Tao_List_Trai;
        private System.Windows.Forms.Button btn_Tao_list_phai;
        private System.Windows.Forms.Button btn_xoa;
    }
}

