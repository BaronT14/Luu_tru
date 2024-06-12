using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class AES : hamAES{
        private List<string> keys;
        
        public AES(string text, string key, string ciphertext): base(text, key, ciphertext){
            keys = new List<string>();
            string temp = Key;
            for (int i = 1; i <= 10; i++)
            {
                temp = KeyExpansion(temp, i);
                keys.Add(temp);
            }
        }
        
        public string ma_hoa(){
            string cipher = AddRoundKey(Text, Key);
            int i = 1;
            while(i <= 9)
            {
                cipher = SubBytes(cipher);
                cipher = ShiftRows(cipher);
                cipher = mixColumns(cipher);
                cipher = AddRoundKey(cipher, keys[i - 1]);
                i++;
            }
            cipher = SubBytes(cipher);
            cipher = ShiftRows(cipher);
            cipher = AddRoundKey(cipher, keys[i - 1]);
            return cipher;
        }

        public string giai_ma(){
            string plaintext = AddRoundKey(Ciphertext, keys[9]);
            int i = 9;
            while(i >= 1)
            {
                plaintext = InvShiftRows(plaintext);
                plaintext = InvSubBytes(plaintext);
                plaintext = AddRoundKey(plaintext, keys[i - 1]);
                plaintext = InvMixColumns(plaintext);
                i--;
            }
            plaintext = InvShiftRows(plaintext);
            plaintext = InvSubBytes(plaintext);
            plaintext = AddRoundKey(plaintext, Key);
            return HexToText(plaintext);
        }
    }
}