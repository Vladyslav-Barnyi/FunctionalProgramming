using FunctionalProgramming.Lib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming.Lib.FuncStyle
{
    public static class DeclarativeStyle
    {
        public static string GetSalutation(int hour) =>
            hour > 12 ? "Good morning" : "Good afternoon";
        public static void FunctionalExample(string text)
            => new StringReader(text).Use(stream => stream
                .ReadToEnd()
                .Split(' ')
                .Select(str => str.Trim())
                .GroupBy(str => str)
                .Select(group => Tuple.Create(group.Key, group.Count()))
                .ForEach(Console.WriteLine));

        public static int Factorial(int number) =>
            number == 0 ? 1 : number * Factorial(number - 1);

    }
}
