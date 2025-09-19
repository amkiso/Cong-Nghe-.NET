using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Buoi05
{
    public partial class Cbx_DanToc : Form
    {
        public Cbx_DanToc()
        {
            InitializeComponent();
            btn_load.Click += Btn_load_Click;
            btn_hienthi.Click += Btn_hienthi_Click;
        }

        private void Btn_hienthi_Click(object sender, EventArgs e)
        {
            lbl_Text_ketqua.Text = "Dân tộc " + cbxDantoc.Text;
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            string[] Dantoc = { "Kinh", "Tày", "Thái", "Mường", "Khơ me", "H'Mông", "Nùng", "Dao", "Gia rai", "Ngái", "Ê đê", "Ba na", "Xơ đăng", "Sán chay", "Cơ ho", "Chăm", "Sán dìu", "Hrê", "Ra glai", "Mnông", "Thổ", "Giáy", "Cơ tu", "Gié triêng", "Mạ", "Kháng", "Xtiêng", "Bru - Vân kiều", "Thách sơn lâm", "Phù lá", "La hủ", "La chi", "Chơ ro", "Khơ mú", "Co", "Tà ôi", "Rơ măm", "Ơ đu", "Mảng", "Cống", "Bố y", "Si La", "Pu péo", "Lự", "La ha", "Chứt", "Lô lô", "Mảng" };
            foreach (var item in Dantoc)
            {
                cbxDantoc.Items.Add(item);
            }
        }
    }
}
