using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static string GetMiddle(string s)
        {
            int mid = s.Length / 2;
            return s.Length % 2 == 1 ? s.Substring(mid, 1) : s.Substring(mid - 1, 2);
        }

        public static string GetMiddle2(string s)
        {
            return s.Substring((s.Length - 1 )/ 2 , (s.Length + 1) % 2 + 1);
        }
    }
}
