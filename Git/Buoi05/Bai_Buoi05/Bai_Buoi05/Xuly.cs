using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Buoi05
{
    public class Xuly
    {
        public List<int> uocSo { get; set; }
        public List<int> ComboBox { get; set; }
        public Xuly()
        {
        }
        //Kiêm tra số nguyên tố
        public bool KiemTraSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public int SLSoNguyenTo()
        {
            int count = 0;
            foreach (var item in uocSo)
            {
                if (KiemTraSoNguyenTo(item))
                {
                    count++;
                }
            }
            return count;
        }
        //Tìm ước số của n
        public List<int> TimUocSo(int n)
        {
            uocSo = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    uocSo.Add(i);
                }
            }
            return uocSo;
        }
        //Số lượng ước số là số chẵn
        public int SoluongUocSoChan()
        {
            int count = 0;
            foreach (var item in uocSo)
            {
                if (item % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        //Kiểm tra trùng lặp
        public bool KT(string s)
        {
            int n = int.Parse(s);
            for(int i = 0;i<ComboBox.Count; i++)
            {
                if (ComboBox[i] == n) return false;
            }
            return true;
        }
        public int TongUocSo()
        {
            int tong = 0;
            foreach (var item in uocSo)
            {
                tong += item;
            }
            return tong;
        }
    }
}
