using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    public class XuLyMang
    {
        private int[] mangHienTai; 
        public int[] MangHienTai { get { return mangHienTai; } private set { mangHienTai = value; } }
        public XuLyMang() { }
        public int[] TaoMangNgauNhien()
        {
            Random rand = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 101);
            }
            mangHienTai =arr;
            return arr;
        }
        public int [] SapXepTang()
        {
            return mangHienTai.OrderBy(t => t).ToArray();
        }
        public int[] SapXepGiam()
        {
            
            return mangHienTai.OrderByDescending(t => t).ToArray();
        }
        public bool LaSoNguyen(string input)
        {
            return int.TryParse(input, out _);
        }
        public int TimGiaTri(int a)
        {
            
            return Array.IndexOf(mangHienTai, a); 
        }
        public string TimXoaGT(string input)
        {
            int vl = int.Parse(input);
            return vl.ToString();
        }
        public string TongMang()
        {
            return mangHienTai.Sum().ToString();
        }
        public string TongChan()
        {
            return mangHienTai.Where(x => x %2== 0).Sum().ToString();
        }
        public string TongLe()
        {
            return mangHienTai.Where(x => x % 2 != 0).Sum().ToString();
        }
        public string SoLonNhat()
        {
            return mangHienTai.Max().ToString();
        }
        public string SoNhoNhat()
        {
            return mangHienTai.Min().ToString();
        }
        public int VtGTCanTim(int vt)
        {
            return mangHienTai[vt];
        }
        public bool XoaGiaTri(int a)
        {
            if (!mangHienTai.Contains(a))
                return false;

            mangHienTai = mangHienTai
                .Where(x => x != a)
                .ToArray();

            return true;
        }
        public bool XoaViTri(int index)
        {
            if (index < 0 || index >= mangHienTai.Length)
                return false;

            mangHienTai = mangHienTai
                .Where((x, i) => i != index)
                .ToArray();

            return true;
        }
        
        public int [] Themtaivt(int value, int index)
        {
            Array.Resize(ref mangHienTai, mangHienTai.Length +1);
            for(int i = mangHienTai.Length-1;i> index;i--)
            {
                mangHienTai[i] = mangHienTai[i-1];
            }
            mangHienTai[index] = value;
            return mangHienTai;
        }
        public bool ThayTheGt(int taget, int value)
        {
            if (TimGiaTri(taget) == -1) return false;
            for (int i =0; i< mangHienTai.Length; i++)
            {
                if (mangHienTai[i]==taget)
                { mangHienTai [i] = value; }    
            }
            return true;
        }
        public bool ThayTheViTri(int vt, int value)
        {
            if(vt < 0 || vt > mangHienTai.Length) return false;
            mangHienTai[vt] = value;
            return true;
        }
    }
}
