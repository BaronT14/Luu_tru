using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BMMT
{
    class Caeser
    {
        string str;
        public string Str { get => str; set => str = value; }
        public Caeser()
        {
            str = "";
        }
        public void nhap()
        {
            str = Console.ReadLine();
            str = str.ToLower();
        }
    }

    class Giaima : Caeser
    {
        public new void nhap()
        {
            Console.Write("Nhap chuoi: ");
            base.nhap();
        }
        public void Giai_ma()
        {
            int k = 25;
            for (int i = 1; i <= k; i++)
            {
                char[] temp = Str.ToCharArray();
                Console.Write($"k = {i}:  ");
                for (int j = 0; j < Str.Length; j++)
                {
                    if (Str[j].Equals(' '))
                        continue;
                    if (Str[j] + i > 122)
                    {
                        temp[j] = (char)(temp[j] + i - 26);
                    }
                    else
                    {
                        temp[j] = (char)(temp[j] + i);
                    }
                }
                Console.WriteLine(temp);
            }

        }
        public void Ma_hoa()
        {

        }
    }
}
