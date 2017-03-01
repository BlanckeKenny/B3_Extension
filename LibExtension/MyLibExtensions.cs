using System.Collections;

namespace LibExtension
{
    public static class MyLibExtensions
    {
        public static bool In(this object o, IEnumerable c)
        {
            foreach (object i in c)
            {
                if (i.Equals(o))
                    return true;
            }
            return false;
        }

        public static bool IsOdd(this int i)
        {
            return i % 2 != 0;
        }

        public static int CountChar(this string s, char c)
        {
            int count = 0;
            foreach(char ch in s)
            {
                if (ch == c) count++;
            }
            return count;
        }

        
    }
}
