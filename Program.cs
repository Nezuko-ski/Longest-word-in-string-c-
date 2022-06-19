using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nezuko
{
    public class Program
    {

        public static string LocateShort(string str)
        {
            return string.Concat(str.Split().OrderByDescending(v => v.Length).First());

        }
        public static void Main()
        {
            Console.WriteLine(LocateShort("She told me to call her cousin but Í'm not feeling like it."));
        }
    }
}
