namespace Buoi3_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên của bạn là:" + txt_Name.Text + "\n" + "Tuổi:" + (2025 - int.Parse(txt_NamSinh.Text)).ToString());
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            txt_NamSinh.Clear();
            txt_Name.Clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txt_Name_Leave(object sender, EventArgs e)
        {
            if (txt_Name.Text.Length == 0)
            {
                errorProvider1.SetError(txt_Name, "Bạn cần nhập họ và tên!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_NamSinh_TextChanged(object sender, EventArgs e)
        {
            if (txt_NamSinh.Text.Length > 0 && !char.IsDigit(txt_NamSinh.Text[txt_NamSinh.Text.Length - 1]))
            {
                errorProvider1.SetError(txt_NamSinh, "Năm sinh phải là số !");
            }
            else
            {
                errorProvider1.Clear();
            }
            
        }
    }
}
