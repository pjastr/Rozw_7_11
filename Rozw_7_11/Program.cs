using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rozw_7_11
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists("ABC"))
            {
                Directory.CreateDirectory("ABC");
            }
            

            using (StreamWriter sw = new StreamWriter("ABC\\123.txt"))
            {
                sw.Write("s98565");
            }             

        }
    }
}
