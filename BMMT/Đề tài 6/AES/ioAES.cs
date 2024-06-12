using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class ioAES
    {
        private string text, ciphertext;
        private string key;
        public string Text { get => text; set => text = value; }
        public string Key { get => key; set => key = value; }
        public string Ciphertext { get => ciphertext; set => ciphertext = value; }

        public ioAES(string text, string key, string ciphertext){
            if(text.Length * 8 == 128)  this.text = TextToHex(text);
            else{
                int n = text.Length;
                List<string> t = new List<string>();
                t.Add(text);
                while(n < 16){
                    t.Add("0");
                    n++;
                }
                this.text = TextToHex(string.Join("", t));
            }
            this.key = TextToHex(key);
            this.ciphertext = ciphertext;
        }

        public string XOR(string b1, string b2){
            string result = "", tmp1 = "", tmp2 = "";
            if ( b1.Length > b2.Length){
                for (int i = 0; i < b1.Length - b2.Length; i++)
                {
                 tmp1 += "0";
                }
                tmp1 += b2;
                tmp2 = b1;
            }
            else{
                for (int i = 0; i < b2.Length - b1.Length; i++)
                {
                 tmp1 += "0";
                }
                tmp1 += b1;
                tmp2 = b2;
            }
            for (int i = 0; i < tmp1.Length; i++)
            {
                if(tmp1[i] != tmp2[i])
                    result += "1";
                else
                    result += "0";
            }
            return result;
        }
        public int HexToDec(string hex){
            int dec = Convert.ToInt32(hex, 16);
            return dec;
        }
        public string DecToHex(int dec){
            string hex = dec.ToString("x2");
            return hex;
        }
        public string DecToBin(int dec)
        {
            if (dec == 0)
            {
                return "0";
            }
            string binary = "";
            while (dec > 0)
            {
                binary = (dec % 2) + binary;
                dec /= 2;
            }
            return binary;
        }

        public string TextToHex(string text)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            StringBuilder hex = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }
        public string HexToText(string hex)
        {
            if (hex.Length % 2 != 0)
            {
                throw new ArgumentException("Loi do dai");
            }

            StringBuilder ascii = new StringBuilder();
            for (int i = 0; i < hex.Length; i += 2)
            {
                string hexByte = hex.Substring(i, 2);
                int decimalValue = Convert.ToInt32(hexByte, 16);
                ascii.Append((char)decimalValue);
            }
            return ascii.ToString();
        }
        public string HexToBin(string hex)
        {
            string binary = "";
            foreach (char c in hex)
            {
                int hexValue = Convert.ToInt32(c.ToString(), 16);
                binary += Convert.ToString(hexValue, 2).PadLeft(4, '0');
            }
            return binary;
        }
        public int BinToDec(string bin)
        {
            int dec = Convert.ToInt32(bin, 2);
            return dec;
        }        
        public string BinToHex(string binary)
        {
            if (binary.Length % 4 != 0)
            {
                throw new ArgumentException("Loi do dai");
            }
            List<string> hex = new List<string>();
            for (int i = 0; i < binary.Length; i += 4)
            {
                string chunk = binary.Substring(i, 4);
                hex.Add(chunk);
            }
            StringBuilder hexBuilder = new StringBuilder();
            foreach (string chunk in hex)
            {
                int decimalValue = Convert.ToInt32(chunk, 2);
                string hexValue = decimalValue.ToString("x");
                hexBuilder.Append(hexValue);
            }
            return hexBuilder.ToString();
        }
        public string[,] chuoiThanhMaTran(string text){
            string[,] mt = new string[4,4];
            int start = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mt[j,i] = text.Substring(start, 2);
                    start+=2;
                }                
            }
            return mt;
        }
        public string maTranThanhChuoi(string[,] matran){
            List<string> result = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    result.Add(matran[j,i]);
                }
            }
            return string.Join("",result);
        }
        public string[,] Sbox()
        {
            string[,] sBox = new string[16, 16];

            string[] sBoxData = {
                "63", "7c", "77", "7b", "f2", "6b", "6f", "c5", "30", "01", "67", "2b", "fe", "d7", "ab", "76",
                "ca", "82", "c9", "7d", "fa", "59", "47", "f0", "ad", "d4", "a2", "af", "9c", "a4", "72", "c0",
                "b7", "fd", "93", "26", "36", "3f", "f7", "cc", "34", "a5", "e5", "f1", "71", "d8", "31", "15",
                "04", "c7", "23", "c3", "18", "96", "05", "9a", "07", "12", "80", "e2", "eb", "27", "b2", "75",
                "09", "83", "2c", "1a", "1b", "6e", "5a", "a0", "52", "3b", "d6", "b3", "29", "e3", "2f", "84",
                "53", "d1", "00", "ed", "20", "fc", "b1", "5b", "6a", "cb", "be", "39", "4a", "4c", "58", "cf",
                "d0", "ef", "aa", "fb", "43", "4d", "33", "85", "45", "f9", "02", "7f", "50", "3c", "9f", "a8",
                "51", "a3", "40", "8f", "92", "9d", "38", "f5", "bc", "b6", "da", "21", "10", "ff", "f3", "d2",
                "cd", "0c", "13", "ec", "5f", "97", "44", "17", "c4", "a7", "7e", "3d", "64", "5d", "19", "73",
                "60", "81", "4f", "dc", "22", "2a", "90", "88", "46", "ee", "b8", "14", "de", "5e", "0b", "db",
                "e0", "32", "3a", "0a", "49", "06", "24", "5c", "c2", "d3", "ac", "62", "91", "95", "e4", "79",
                "e7", "c8", "37", "6d", "8d", "d5", "4e", "a9", "6c", "56", "f4", "ea", "65", "7a", "ae", "08",
                "ba", "78", "25", "2e", "1c", "a6", "b4", "c6", "e8", "dd", "74", "1f", "4b", "bd", "8b", "8a",
                "70", "3e", "b5", "66", "48", "03", "f6", "0e", "61", "35", "57", "b9", "86", "c1", "1d", "9e",
                "e1", "f8", "98", "11", "69", "d9", "8e", "94", "9b", "1e", "87", "e9", "ce", "55", "28", "df",
                "8c", "a1", "89", "0d", "bf", "e6", "42", "68", "41", "99", "2d", "0f", "b0", "54", "bb", "16"
            };
            
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    sBox[i, j] = sBoxData[i * 16 + j];
                }
            }

            return sBox;
        }

        public string[,] InvSbox()
        {
            string[,] invSbox = new string[16, 16];

            string[] invSboxData = {
                "52", "09", "6a", "d5", "30", "36", "a5", "38", "bf", "40", "a3", "9e", "81", "f3", "d7", "fb",
                "7c", "e3", "39", "82", "9b", "2f", "ff", "87", "34", "8e", "43", "44", "c4", "de", "e9", "cb",
                "54", "7b", "94", "32", "a6", "c2", "23", "3d", "ee", "4c", "95", "0b", "42", "fa", "c3", "4e",
                "08", "2e", "a1", "66", "28", "d9", "24", "b2", "76", "5b", "a2", "49", "6d", "8b", "d1", "25",
                "72", "f8", "f6", "64", "86", "68", "98", "16", "d4", "a4", "5c", "cc", "5d", "65", "b6", "92",
                "6c", "70", "48", "50", "fd", "ed", "b9", "da", "5e", "15", "46", "57", "a7", "8d", "9d", "84",
                "90", "d8", "ab", "00", "8c", "bc", "d3", "0a", "f7", "e4", "58", "05", "b8", "b3", "45", "06",
                "d0", "2c", "1e", "8f", "ca", "3f", "0f", "02", "c1", "af", "bd", "03", "01", "13", "8a", "6b",
                "3a", "91", "11", "41", "4f", "67", "dc", "ea", "97", "f2", "cf", "ce", "f0", "b4", "e6", "73",
                "96", "ac", "74", "22", "e7", "ad", "35", "85", "e2", "f9", "37", "e8", "1c", "75", "df", "6e",
                "47", "f1", "1a", "71", "1d", "29", "c5", "89", "6f", "b7", "62", "0e", "aa", "18", "be", "1b",
                "fc", "56", "3e", "4b", "c6", "d2", "79", "20", "9a", "db", "c0", "fe", "78", "cd", "5a", "f4",
                "1f", "dd", "a8", "33", "88", "07", "c7", "31", "b1", "12", "10", "59", "27", "80", "ec", "5f",
                "60", "51", "7f", "a9", "19", "b5", "4a", "0d", "2d", "e5", "7a", "9f", "93", "c9", "9c", "ef",
                "a0", "e0", "3b", "4d", "ae", "2a", "f5", "b0", "c8", "eb", "bb", "3c", "83", "53", "99", "61",
                "17", "2b", "04", "7e", "ba", "77", "d6", "26", "e1", "69", "14", "63", "55", "21", "0c", "7d"
            };

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    invSbox[i, j] = invSboxData[i * 16 + j];
                }
            }
            return invSbox;
        }

        public int Rcon(int j){
            if(j == 1) return 1;
            return NhanGF2_8(2, Rcon(j - 1));
        }
        public int NhanGF2_8(int a, int b)
        {
            int m = 0x11B; // định thức m
            int result = 0;
            while (b != 0)
            {
                if ((b & 1) != 0)
                    result ^= a;

                bool c = (a & 0x80) != 0;
                a <<= 1;
                if (c)
                    a ^= m;

                b >>= 1;
            }
            return result;
        }
    }
}