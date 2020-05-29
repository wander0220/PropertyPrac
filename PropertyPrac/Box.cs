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
        const int SIZE_DEFAULT = 1;
        private int width;
        private int height;

        public int HEight
        {
            get { return height; }
            set
            {
                this.height = IsPositive(height);
            }
        }

        public Box(int width, int height)
        {
            this.width = IsPositive(width);
            this.height = IsPositive(height);
        }
     
        public int GetWidth()
        {
            return this.width;
        }
        public int GetHeight()
        {
            return this.height;
        }
        public void SetWidth(int width)
        {
            this.width = IsPositive(width);
        }
        public void SetHeight(int height)
        {
            this.height = IsPositive(height);
        }

        private int IsPositive(int value)
        {
            if (value > 0)
            {
                return value;
            }
            else
            {
                Console.WriteLine("매개변수 is 양수... no 음수...");
                Console.WriteLine("기본 값인 ",SIZE_DEFAULT,"인 객체로 수정합니다.");
                return SIZE_DEFAULT;
            }
        }

        public int Area()
        {
            return this.width * this.height;
        }

    }
}
