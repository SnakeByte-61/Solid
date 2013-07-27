using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Wrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Height = 4;
            rectangle.Width = 5;
            AssertTheArea(rectangle);

            Rectangle square = new Square();
            square.Height = 5;
            AssertTheArea(square);

        }

        public class Rectangle
        {
            public virtual int Height { get; set; }
            public virtual int Width { get; set; }

            public int Area()
            {
                return Height * Width;
            }
        }

        public class Square : Rectangle
        {
            public override int Height
            {
                get { return base.Height; }
                set
                {
                    base.Height = value;
                    base.Width = value;
                }
            }
            public override int Width
            {
                get { return base.Width; }
                set
                {
                    base.Width = value;
                    base.Height = value;
                }
            }
        }

        private static void AssertTheArea(Rectangle rectangle)
        {
            int expectedArea = 20;
            int actualArea = rectangle.Area();
            Debug.Assert(expectedArea == actualArea);
        }


    }
}
