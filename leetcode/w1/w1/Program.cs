using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using w1;

namespace w1
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            List<char> result = new List<char>();
            string str;
            int n = strs.Length, minLen = strs[0].Length;
            foreach(string i in strs)
            {
                if (minLen > i.Length) minLen = i.Length;
            }
            for (int i = 0; i < minLen; i++)
            {
                char temp = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != temp)
                    {
                        str = new string(result.ToArray());
                        return str;
                    }
                }
                result.Add(strs[0][i]);
            }
            str = new string(result.ToArray());
            return str;
        }
        public bool IsValid(string s)
        {
            if (s.Length == 0) return true;
            Stack<char> open = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('(') || s[i].Equals('[') || s[i].Equals('{'))
                    open.Push(s[i]);
                else
                {
                    if (open.Count != 0)
                    {
                        char temp = open.Pop();
                        if ((temp != '(' && s[i] == ')') || (temp != '[' && s[i] == ']') || (temp != '{' && s[i] == '}'))
                            return false;
                    }
                    else return false;
                }
            }
            if (open.Count != 0) return false;
            return true;
        }
        
    }
}
