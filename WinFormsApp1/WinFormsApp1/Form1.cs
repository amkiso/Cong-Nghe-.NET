namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Xuly xl = new Xuly();
        public Form1()
        {
            InitializeComponent();
            btn_crawl.Click += Btn_crawl_Click;
            btn_loc.Click += Btn_loc_Click;
            btn_luu.Click += Btn_luu_Click;
            btn_back.Click += Btn_back_Click;
        }

        private void Btn_back_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Btn_luu_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Btn_loc_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void Btn_crawl_Click(object? sender, EventArgs e)
        {
            string url = txt_url.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL.");
                return;
            }

            try
            {
                string html = await xl.GetHtmlCodeAsync(url);
                rtb_Ketqua.Text = html;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi crawl: " + ex.Message);
            }
        }
    }
}
