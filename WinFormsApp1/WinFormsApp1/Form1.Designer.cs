namespace WinFormsApp1
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
            label1 = new Label();
            txt_url = new TextBox();
            txt_item = new TextBox();
            label2 = new Label();
            btn_crawl = new Button();
            btn_loc = new Button();
            btn_back = new Button();
            btn_luu = new Button();
            rtb_Ketqua = new RichTextBox();
            label3 = new Label();
            lbl_trangthai = new Label();
            groupBox1 = new GroupBox();
            txt_class = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 62);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 0;
            label1.Text = "Nhập url:";
            // 
            // txt_url
            // 
            txt_url.Location = new Point(178, 62);
            txt_url.Name = "txt_url";
            txt_url.Size = new Size(316, 39);
            txt_url.TabIndex = 1;
            // 
            // txt_item
            // 
            txt_item.Location = new Point(280, 125);
            txt_item.Name = "txt_item";
            txt_item.Size = new Size(214, 39);
            txt_item.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 125);
            label2.Name = "label2";
            label2.Size = new Size(201, 32);
            label2.TabIndex = 2;
            label2.Text = "Nhập thẻ cần lọc:";
            // 
            // btn_crawl
            // 
            btn_crawl.Location = new Point(60, 251);
            btn_crawl.Name = "btn_crawl";
            btn_crawl.Size = new Size(150, 46);
            btn_crawl.TabIndex = 4;
            btn_crawl.Text = "Crawl !";
            btn_crawl.UseVisualStyleBackColor = true;
            // 
            // btn_loc
            // 
            btn_loc.Location = new Point(344, 251);
            btn_loc.Name = "btn_loc";
            btn_loc.Size = new Size(150, 46);
            btn_loc.TabIndex = 5;
            btn_loc.Text = "Lọc";
            btn_loc.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(216, 251);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(122, 46);
            btn_back.TabIndex = 6;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            btn_luu.Location = new Point(60, 321);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(434, 46);
            btn_luu.TabIndex = 7;
            btn_luu.Text = "Lưu";
            btn_luu.UseVisualStyleBackColor = true;
            // 
            // rtb_Ketqua
            // 
            rtb_Ketqua.Location = new Point(26, 41);
            rtb_Ketqua.Name = "rtb_Ketqua";
            rtb_Ketqua.Size = new Size(590, 626);
            rtb_Ketqua.TabIndex = 8;
            rtb_Ketqua.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 414);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 9;
            label3.Text = "Trạng thái:";
            // 
            // lbl_trangthai
            // 
            lbl_trangthai.AutoSize = true;
            lbl_trangthai.Location = new Point(244, 463);
            lbl_trangthai.Name = "lbl_trangthai";
            lbl_trangthai.Size = new Size(29, 32);
            lbl_trangthai.TabIndex = 10;
            lbl_trangthai.Text = "...";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtb_Ketqua);
            groupBox1.Location = new Point(508, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(641, 673);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết quả:";
            // 
            // txt_class
            // 
            txt_class.Location = new Point(285, 188);
            txt_class.Name = "txt_class";
            txt_class.Size = new Size(214, 39);
            txt_class.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 188);
            label4.Name = "label4";
            label4.Size = new Size(219, 32);
            label4.TabIndex = 12;
            label4.Text = "Nhập class của thẻ:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 708);
            Controls.Add(txt_class);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(lbl_trangthai);
            Controls.Add(label3);
            Controls.Add(btn_luu);
            Controls.Add(btn_back);
            Controls.Add(btn_loc);
            Controls.Add(btn_crawl);
            Controls.Add(txt_item);
            Controls.Add(label2);
            Controls.Add(txt_url);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tool box";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_url;
        private TextBox txt_item;
        private Label label2;
        private Button btn_crawl;
        private Button btn_loc;
        private Button btn_back;
        private Button btn_luu;
        private RichTextBox rtb_Ketqua;
        private Label label3;
        private Label lbl_trangthai;
        private GroupBox groupBox1;
        private TextBox txt_class;
        private Label label4;
    }
}
