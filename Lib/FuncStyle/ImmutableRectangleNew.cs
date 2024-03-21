using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming.Lib.FuncStyle
{
    //C# 9.0 style
    public record ImmutableRectangleNew(int Length, int Height)
    {
        public ImmutableRectangleNew Grow(int length, int height) =>
            new (Length + length, Height + height);

        public ImmutableRectangleNew Shrink(int length, int height) =>
                new ImmutableRectangleNew(Length, Height);
    }
}
