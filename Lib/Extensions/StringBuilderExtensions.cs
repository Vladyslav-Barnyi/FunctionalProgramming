using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming.Lib.Extensions
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder AppendWhen(this StringBuilder sb, string value, Func<bool> condition) =>
            condition.Invoke() ? sb.Append(value) : sb;
    }
}
