using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Transform
    {
        //6.29
        public static string Convert(string s, bool kirillFlag, bool maxFlag)
        {
            StringBuilder SB = new StringBuilder();
            for (int idx = 0; idx < s.Length; idx++)
            {
                if (kirillFlag && maxFlag && s[idx] >= 'А' && s[idx] <= 'Я')
                    SB.Append((char)(s[idx] + ('а' - 'А')));
                else if (kirillFlag && !maxFlag && s[idx] >= 'а' && s[idx] <= 'я')
                    SB.Append((char)(s[idx] + ('А' - 'а')));
                else if (!kirillFlag && maxFlag && s[idx] >= 'A' && s[idx] <= 'Z')
                    SB.Append((char)(s[idx] + ('a' - 'A')));
                else if (!kirillFlag && !maxFlag && s[idx] >= 'a' && s[idx] <= 'z')
                    SB.Append((char)(s[idx] + ('A' - 'a')));
                else SB.Append(s[idx]);
            }
            return SB.ToString();
        }
    }
}
