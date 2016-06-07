using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public void TestOut(out int x, out int y)
        {
            x = 1;
            y = 2;
        }


        static void Main(string[] args)
        {
            int x;
            int y;
            Program p1 = new Program();
            p1.TestOut(out x, out y);
            Console.WriteLine("x={0},y={1}",x,y);
            Console.ReadLine();
        }
    }
}
