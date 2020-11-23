using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssemblies
{
    public class Box : Container
    {
        private int length;
        private int width;
        private int height;
        public string contents;

        public Box(bool isEmpty, int length, int width, int height, string contents) : base(isEmpty)
        {
            this.length = length;
            this.width = width;
            this.height = height;
            this.contents = contents;
        }

        public int Length { get; set; }
        public int Windth { get; set; }
        public int Height { get; set; }
    }
}
