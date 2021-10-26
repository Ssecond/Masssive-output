using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "vevfeger";

            int[] arrr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int x = 0; x < arrr.Length; x++)
            {
                Console.WriteLine(arrr[x].ToString());    
                
            }
            
            Console.ReadLine();
        }
    }
}
