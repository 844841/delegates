using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        //delegate declaration
        public delegate string Mydel(int x, int y);

        static void Main(string[] args)
        {
           // operationdelegate();

        }

        private static void operationdelegate()
        {
            Mydel delg = new Mydel(Add);
            Console.WriteLine(delg(12, 25));      //37
            delg += new Mydel(Subtract);
            Console.WriteLine(delg(12, 25));      //-13
            delg -= new Mydel(Subtract);
            Console.WriteLine(delg(20, 50));      //70
        }

        public static string Add(int a,int b)
        {
            int c = a + b;
            return Convert.ToString(c);
        }

        public static string Subtract(int a,int b)
        {
            int c = a - b;
            return Convert.ToString(c);
        }



    }

}
