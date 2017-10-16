using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winCOnsoleApp
{
  

   public static class StringFunctions
    {
        public static string Sujit(this string value)
        {
            char[] ch = value.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                sb.Append(ch[i]);
            }
            return sb.ToString();
        }
    }
}
