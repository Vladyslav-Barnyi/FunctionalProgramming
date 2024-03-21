using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming.Lib.NonFuncStyle
{
    public class Rectangle
    {
        public int Length { get; set; }
        public int Height { get; set; }
        public void Grow(int length, int height)
        {
            Length += length;
            Height += height;
        }
    }
}
