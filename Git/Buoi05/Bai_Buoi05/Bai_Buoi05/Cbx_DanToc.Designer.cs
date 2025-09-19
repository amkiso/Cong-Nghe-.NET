namespace Bai_Buoi05
{
    partial class Cbx_DanToc
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
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.lbl_DanToc = new System.Windows.Forms.Label();
            this.lbl_KetQua = new System.Windows.Forms.Label();
            this.lbl_Text_ketqua = new System.Windows.Forms.Label();
            this.cbxDantoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(53, 12);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(129, 23);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load dữ liệu dân tộc";
            this.btn_load.UseVisualStyleBackColor = true;
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.Location = new System.Drawing.Point(117, 83);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(75, 23);
            this.btn_hienthi.TabIndex = 2;
            this.btn_hienthi.Text = "Hiển thị";
            this.btn_hienthi.UseVisualStyleBackColor = true;
            // 
            // lbl_DanToc
            // 
            this.lbl_DanToc.AutoSize = true;
            this.lbl_DanToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanToc.Location = new System.Drawing.Point(25, 49);
            this.lbl_DanToc.Name = "lbl_DanToc";
            this.lbl_DanToc.Size = new System.Drawing.Size(52, 13);
            this.lbl_DanToc.TabIndex = 3;
            this.lbl_DanToc.Text = "Dân tộc";
            // 
            // lbl_KetQua
            // 
            this.lbl_KetQua.AutoSize = true;
            this.lbl_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KetQua.ForeColor = System.Drawing.Color.Red;
            this.lbl_KetQua.Location = new System.Drawing.Point(50, 117);
            this.lbl_KetQua.Name = "lbl_KetQua";
            this.lbl_KetQua.Size = new System.Drawing.Size(55, 13);
            this.lbl_KetQua.TabIndex = 4;
            this.lbl_KetQua.Text = "Kết quả:";
            // 
            // lbl_Text_ketqua
            // 
            this.lbl_Text_ketqua.AutoSize = true;
            this.lbl_Text_ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Text_ketqua.ForeColor = System.Drawing.Color.Red;
            this.lbl_Text_ketqua.Location = new System.Drawing.Point(114, 117);
            this.lbl_Text_ketqua.Name = "lbl_Text_ketqua";
            this.lbl_Text_ketqua.Size = new System.Drawing.Size(11, 13);
            this.lbl_Text_ketqua.TabIndex = 5;
            this.lbl_Text_ketqua.Text = " ";
            // 
            // cbxDantoc
            // 
            this.cbxDantoc.FormattingEnabled = true;
            this.cbxDantoc.Location = new System.Drawing.Point(83, 46);
            this.cbxDantoc.Name = "cbxDantoc";
            this.cbxDantoc.Size = new System.Drawing.Size(170, 21);
            this.cbxDantoc.TabIndex = 6;
            // 
            // Cbx_DanToc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 164);
            this.Controls.Add(this.cbxDantoc);
            this.Controls.Add(this.lbl_Text_ketqua);
            this.Controls.Add(this.lbl_KetQua);
            this.Controls.Add(this.lbl_DanToc);
            this.Controls.Add(this.btn_hienthi);
            this.Controls.Add(this.btn_load);
            this.Name = "Cbx_DanToc";
            this.Text = "Cbx_DanToc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.Label lbl_DanToc;
        private System.Windows.Forms.Label lbl_KetQua;
        private System.Windows.Forms.Label lbl_Text_ketqua;
        private System.Windows.Forms.ComboBox cbxDantoc;
    }
}