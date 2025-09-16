using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Form
{
    public class XuLy
    {
        public XuLy() { }
        public int Tong(int a, int b)
        {
            return a + b;
        }
        public int Tong(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }
        public int Hieu(int a, int b)
        {
            return a - b;
        }
        public int Hieu(string a, string b)
        {
            return int.Parse(a) - int.Parse(b);
        }
        public double Chia(double a, double b)
        {
            return a / b;
        }
        public double Chia(string a, string b)
        {
            return double.Parse(a) / double.Parse(b);
        }
        public int Tich(int a, int b)
        {
            return a * b;
        }
        public int Tich(string a, string b)
        {
            return int.Parse(a) * int.Parse(b);
        }
        public bool KiemTraSo(string Chuoi)
        {
            if (Chuoi.Length > 0 && !char.IsDigit(Chuoi[Chuoi.Length - 1]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool KT_Email(string mail)
        {
            return mail.Contains("@");
        }
        public  int UocChung(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return Math.Abs(a);
        }

        // BCNN dựa vào UCLN
        public  int BoiChung(int a, int b)
        {
            return Math.Abs(a * b) / UocChung(a, b);
        }

  
       
    }
}
