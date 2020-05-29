using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPrac
{
    class Box
    {
        int width;
        int height;

        public Box(int width,int height)
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("매개변수 is 양수... no 음수...");
            }
        }
        public int Area()
        {
            return this.width * this.height;
        }
    }
}
