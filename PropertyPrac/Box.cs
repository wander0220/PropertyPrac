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
        const int WIDTH_DEFAULT = 1;
        const int HEIGHT_DEFAULT = 1;
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
                this.width = 1;
                this.height = 1;
                Console.WriteLine("매개변수 is 양수... no 음수...");
            }
        }
        public int Area()
        {
            return this.width * this.height;
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
            if (width > 0)
            {
                this.width = width;
            }
            else
            {
                this.width = WIDTH_DEFAULT;
                Console.WriteLine("매개변수 is 양수... no 음수...");
                Console.WriteLine("width",WIDTH_DEFAULT,"height",HEIGHT_DEFAULT," 1인 객체로 수정합니다.");
            }
        }
        public void SetHeight(int height)
        {
            if (height > 0)
            {
                this.height = height;
            }
            else
            {
                this.height = HEIGHT_DEFAULT;
                Console.WriteLine("매개변수 is 양수... no 음수...");
                Console.WriteLine("width", WIDTH_DEFAULT, "height", HEIGHT_DEFAULT, " 1인 객체가 수정합니다.");
            }
        }
    }
