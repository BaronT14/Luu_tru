using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8604
#pragma warning disable CS8602
#pragma warning disable CS8600


namespace project
{
    class main_project
    {
        public static int menu(){
            int c = 0;
            Console.WriteLine("\n+---------------MENU---------------+");
            Console.WriteLine("| 1  . ma hoa du lieu              |");
            Console.WriteLine("| 2  . giai ma du lieu             |");
            Console.WriteLine("| 0  . Thoat                       |");
            Console.WriteLine("+----------------------------------+");
            Console.Write("Nhap lua chon: ");
            c = int.Parse(Console.ReadLine());
            return c;
        }
        public static void Main(string[] args)
        {
            int c = 0;
            string plaintext = "", ciphertext = "", key = "";
            do
            {
                c = menu();
                switch(c){
                    case 1:{
                        Console.Write("Nhap chuoi can ma hoa: ");
                        plaintext = Console.ReadLine();
                        Console.Write("Nhap khoa: ");
                        key = Console.ReadLine();
                        if(key.Length*8 != 128){
                            Console.WriteLine("Do dai khoa hien tai: {0}/128", key.Length);
                            break;
                        }
                        AES aes = new AES(plaintext, key, ciphertext);
                        ciphertext = aes.ma_hoa();
                        Console.Write("Chuoi da ma hoa: {0}", ciphertext);
                        Console.ReadKey();
                    } break;
                    
                    case 2:{
                        Console.Write("Nhap chuoi can giai ma: ");
                        ciphertext = Console.ReadLine();
                        Console.Write("Nhap khoa: ");
                        key = Console.ReadLine();
                        if(key.Length*8 != 128){
                            Console.WriteLine("Do dai khoa hien tai: {0}/128", key.Length);
                            break;
                        }
                        AES aes = new AES(plaintext, key, ciphertext);
                        plaintext = aes.giai_ma();
                        Console.Write("Chuoi da giai hoa: {0}", plaintext);
                        Console.ReadKey();
                    } break;
                    default: break;
                }
                Console.Clear();
            } while (c != 0);

            Console.ReadKey();
        }
    }
}