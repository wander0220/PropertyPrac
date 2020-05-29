using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            //int width = 0;
            //int height = 0;
            Box box = new Box(10, 10);
            Console.WriteLine(box.Area());
            box = new Box(-5, 10);
            Console.WriteLine(box.Area());
        }
    }
}
