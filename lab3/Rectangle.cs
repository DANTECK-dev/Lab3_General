using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Rectangle
    {
        private int width, height;
        public Rectangle()
        {
            Random random = new Random();
            this.width = random.Next(0,100);
            this.height = random.Next(0,100);
        }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public void Deconstruct(out int width, out int height)
        {
            width = this.width;
            height = this.height;
        }
        public int Square()
        {
            return width * height;
        }
        public int Perimeter()
        {
            return (width + height) * 2;
        }
    }
}
