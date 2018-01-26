using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOf_ToUpper_ToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            //IndexOf
            string abc = "abcdefghijklmnopqrstuvwxyz";
            string letter = Console.ReadLine();
            Console.WriteLine(abc.IndexOf(letter));


            ////ToUpper/ToLower
            //Console.WriteLine("input in UPPERCASE");
            //string upper = Console.ReadLine();
            //Console.WriteLine("input in lowercase");
            //string lower = Console.ReadLine();
            //upper = upper.ToLower();
            //lower = lower.ToUpper();
            //Console.WriteLine(upper);
            //Console.WriteLine(lower);

        }
    }
}
