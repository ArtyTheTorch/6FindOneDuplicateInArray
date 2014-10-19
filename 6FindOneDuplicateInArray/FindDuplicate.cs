using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6FindOneDuplicateInArray
{
    class FindDuplicate
    {
        string[] str;
        HashSet<string> hs = new HashSet<string>();
        string duplicate = "";

        public FindDuplicate(string p)
        {
            str = p.Split(',');
            foreach(string s in str){
                if (!hs.Add(s))
                {
                    duplicate += s + ", ";
                }
            }
        }

        public string getDuplicates()
        {
            return duplicate;
        }
    }
}
