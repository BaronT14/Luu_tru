using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class hamAES : ioAES
    {
        string[,] sbox, invSbox;

        public hamAES(string text, string key, string ciphertext) : base(text, key, ciphertext){
            sbox = Sbox();
            invSbox = InvSbox();
        }
        public List<string> dichbytesangtrai(List<string> t, int soBytes){
            for (int j = 1; j <= soBytes; j++)
            {
                string tmp = t[0];
                for(int i = 0; i < 3; i++){
                    t[i] = t[i + 1];
                }
                t[3] = tmp;
            }
            return t;
        }
        public List<string> dichbytesangphai(List<string> t, int soBytes)
        {
            for (int j = 1; j <= soBytes; j++)
            {
                string tmp = t[3];
                for(int i = 3; i > 0; i--)
                {
                    t[i] = t[i - 1];
                }
                t[0] = tmp;
            }
            return t;
        }

        // ADDROUNDKEY
        public string AddRoundKey(string p, string key){
            string b1 = HexToBin(p);
            string b2 = HexToBin(key);
            string result = XOR(b1, b2);
            return BinToHex(result);
        }

        // KEYEXPANSION
        public string hamG(string w, int so_vong){
            
            List<string> list_W = new List<string>();
            for (int i = 0; i < w.Length; i+=2)
            {   
                list_W.Add(w.Substring(i,2));
            }
            list_W = dichbytesangtrai(list_W, 1);
            for (int j = 0; j < list_W.Count; j++)
            {
                list_W[j] = SubBytes(list_W[j]);
            }
            list_W[0] = BinToHex(XOR(DecToBin(Rcon(so_vong)), HexToBin(list_W[0])));
            string result = string.Join("", list_W);
            return result;
        }
        public string KeyExpansion(string preKey, int so_vong){
            List<string> arrKey = new List<string>();
            for (int i = 0; i < preKey.Length; i+=8)
            {   
                arrKey.Add(preKey.Substring(i,8));
            }
            string g = hamG(arrKey[3], so_vong);
            arrKey[0] = BinToHex(XOR(HexToBin(arrKey[0]), HexToBin(g)));
            arrKey[1] = BinToHex(XOR(HexToBin(arrKey[0]), HexToBin(arrKey[1])));
            arrKey[2] = BinToHex(XOR(HexToBin(arrKey[2]), HexToBin(arrKey[1])));
            arrKey[3] = BinToHex(XOR(HexToBin(arrKey[3]), HexToBin(arrKey[2])));
            return string.Join("", arrKey);
        }

        // SUBBYTES
        public string SubBytes(string hex){
            List<string> result = new List<string>();
            for (int z = 0; z < hex.Length; z+=2)
            {
                result.Add(sbox[HexToDec(hex.Substring(z,1)), HexToDec(hex.Substring(z + 1, 1))]);
            }
            #pragma warning disable CS8603
            return  string.Join("", result);
        }

        public string InvSubBytes(string hex)
        {
            List<string> result = new List<string>();
            for (int z = 0; z < hex.Length; z += 2)
            {
                result.Add(invSbox[HexToDec(hex.Substring(z, 1)), HexToDec(hex.Substring(z + 1, 1))]);
            }
            return string.Join("", result);
        }

        // SHIFTROWS
        public string ShiftRows(string text){
            string[,] maTranKhoa = chuoiThanhMaTran(text);
            
            for (int i = 0; i < 4; i++)
            {
                List<string> w = new List<string>();
                for (int j = 0; j < 4; j++)
                {
                    w.Add(maTranKhoa[i,j]);
                }
                if(i != 0){
                    dichbytesangtrai(w, i);
                    for (int j = 0; j < 4; j++)
                    {
                        maTranKhoa[i,j] = w[j];
                    }
                }
            }
            return maTranThanhChuoi(maTranKhoa);
        }

        public string InvShiftRows(string text){
            string[,] maTranKhoa = chuoiThanhMaTran(text);
            
            for (int i = 0; i < 4; i++)
            {
                List<string> w = new List<string>();
                for (int j = 0; j < 4; j++)
                {
                    w.Add(maTranKhoa[i,j]);
                }
                if(i != 0){
                    dichbytesangphai(w, i);
                    for (int j = 0; j < 4; j++)
                    {
                        maTranKhoa[i,j] = w[j];
                    }
                }
            }
            return maTranThanhChuoi(maTranKhoa);
        }

        //MIXCOLUMNS
        public string mixColumns(string text){
            string[,] matran_text = chuoiThanhMaTran(text);
            string[,] result = new string[4,4];

            for (int i = 0; i < 4; i++) {
                result[0,i] = DecToHex(NhanGF2_8(HexToDec(matran_text[0,i]), HexToDec("02")) ^ 
                                       NhanGF2_8(HexToDec(matran_text[1, i]), HexToDec("03")) ^ 
                                       NhanGF2_8(HexToDec(matran_text[2,i]), HexToDec("01")) ^ 
                                       NhanGF2_8(HexToDec(matran_text[3,i]), HexToDec("01")));
                result[1,i] = DecToHex(NhanGF2_8(HexToDec(matran_text[0,i]), HexToDec("01")) ^ 
                                       NhanGF2_8(HexToDec(matran_text[1, i]), HexToDec("02")) ^ 
                                       NhanGF2_8(HexToDec(matran_text[2,i]), HexToDec("03")) ^ 
                                       NhanGF2_8(HexToDec(matran_text[3,i]), HexToDec("01")));
                result[2,i] = DecToHex(NhanGF2_8(HexToDec(matran_text[0,i]), HexToDec("01")) ^ 
                                       NhanGF2_8(HexToDec(matran_text[1, i]), HexToDec("01")) ^ 
                                       NhanGF2_8(HexToDec(matran_text[2,i]), HexToDec("02")) ^ 
                                       NhanGF2_8(HexToDec(matran_text[3,i]), HexToDec("03")));
                result[3,i] = DecToHex(NhanGF2_8(HexToDec(matran_text[0,i]), HexToDec("03")) ^ 
                                       NhanGF2_8(HexToDec(matran_text[1, i]), HexToDec("01")) ^ 
                                       NhanGF2_8(HexToDec(matran_text[2,i]), HexToDec("01")) ^ 
                                       NhanGF2_8(HexToDec(matran_text[3,i]), HexToDec("02")));
            }

            return maTranThanhChuoi(result);
        }

        public string InvMixColumns(string text)
        {
            string[,] matranText = chuoiThanhMaTran(text);
            string[,] result = new string[4, 4];

            for (int i = 0; i < 4; i++)
            {
                result[0, i] = DecToHex(NhanGF2_8(HexToDec(matranText[0, i]), HexToDec("0e")) ^ 
                                        NhanGF2_8(HexToDec(matranText[1, i]), HexToDec("0b")) ^ 
                                        NhanGF2_8(HexToDec(matranText[2, i]), HexToDec("0d")) ^ 
                                        NhanGF2_8(HexToDec(matranText[3, i]), HexToDec("09")));
                result[1, i] = DecToHex(NhanGF2_8(HexToDec(matranText[0, i]), HexToDec("09")) ^ 
                                        NhanGF2_8(HexToDec(matranText[1, i]), HexToDec("0e")) ^ 
                                        NhanGF2_8(HexToDec(matranText[2, i]), HexToDec("0b")) ^ 
                                        NhanGF2_8(HexToDec(matranText[3, i]), HexToDec("0d")));
                result[2, i] = DecToHex(NhanGF2_8(HexToDec(matranText[0, i]), HexToDec("0d")) ^ 
                                        NhanGF2_8(HexToDec(matranText[1, i]), HexToDec("09")) ^ 
                                        NhanGF2_8(HexToDec(matranText[2, i]), HexToDec("0e")) ^ 
                                        NhanGF2_8(HexToDec(matranText[3, i]), HexToDec("0b")));
                result[3, i] = DecToHex(NhanGF2_8(HexToDec(matranText[0, i]), HexToDec("0b")) ^ 
                                        NhanGF2_8(HexToDec(matranText[1, i]), HexToDec("0d")) ^ 
                                        NhanGF2_8(HexToDec(matranText[2, i]), HexToDec("09")) ^ 
                                        NhanGF2_8(HexToDec(matranText[3, i]), HexToDec("0e")));
            }

            return maTranThanhChuoi(result);
        }

    }
}