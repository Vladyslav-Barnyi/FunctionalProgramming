// using FunctionalProgramming.Lib.Extensions;
// using FunctionalProgramming.Lib.FuncStyle;
// using FunctionalProgramming.Lib.NonFuncStyle;
// using System.Collections.Immutable;
// using System.ComponentModel;
// using System.Text;
//
// public static class Program
// {
//     public static void Main()
//     {
//         //#region Chaining Functions
//         //Func<int, int> addOne = x => x + 1;
//         //Func<int, int, int> addNums = (x, y) => x + y;
//         //Func<int, bool> isZero = x => x == 0;
//         //Console.WriteLine(addOne(5));
//         //Console.WriteLine(isZero(5));
//         //Console.WriteLine(isZero(addOne(-1)));
//         //int[] array = { 0, 2, 0, 5 };
//
//         //Console.WriteLine(isZero(array.Count()));
//         //Console.WriteLine(array.Count(isZero));
//         //#endregion
//
//         //#region Immutable types
//         //var irect = new ImmutableRectangle(10, 5);
//         //Console.WriteLine(irect.GetHashCode());
//         //var irect2 = irect.Grow(2, 4);
//         //Console.WriteLine(irect2.GetHashCode());
//
//         //var irect3 = new ImmutableRectangleNew(20, 30);
//         //var irect4 = irect3.Grow(2, 4);
//         //var rect = new Rectangle
//         //{
//         //    Height = 10,
//         //    Length = 5,
//         //};
//         //Console.WriteLine(rect.GetHashCode());
//         //rect.Grow(2, 4);
//         //Console.WriteLine(rect.GetHashCode());
//
//         //Console.WriteLine("Immutable persons");
//         //var immutPerson1 = new ImmutablePerson("Juan", 19, ImmutableArray.Create<string>("43434-3434", "4234-2343"));
//         //var immutPerson2 = immutPerson1.CopyTo();
//         //var immutPerson3 = new ImmutablePerson("Juan", 19, ImmutableArray.Create<string>("43434-3434", "4234-2343"));
//         //Console.WriteLine("Immutable persons end");
//         //#endregion
//
//         //#region Pipelines
//         //var sb = new StringBuilder();
//         //sb.AppendLine("John Stevens");
//         //sb.AppendWhen(" of legal age", () => immutPerson1.Age > 18);
//         //Console.WriteLine(sb.ToString());
//         //#endregion
//
//         //#region Imperative vs Declarative style
//         //DeclarativeStyle.FunctionalExample("En un lugar de la mancha de cuyo nombre no puedo acordarme");
//         //ImperativeStyle.NonFunctionalExample("En un lugar de la mancha de cuyo nombre no puedo acordarme");
//         //Console.WriteLine(DeclarativeStyle.Factorial(4));
//         //Console.WriteLine(ImperativeStyle.Factorial(4));
//         //#endregion
//
//         //#region Adding and substracting functions
//         //Action<string> test = (x) => Console.WriteLine($"hello {x}");
//         //test += (y) => Console.WriteLine($"now time for {y}");
//         //test.Invoke("Pedro");
//
//         //Action<string> test2 = (x) => Console.WriteLine($"hello {x}");
//         //test2 += (y) => Console.WriteLine($"now time for {y}");
//         //test2 -= (y) => Console.WriteLine($"now time for {y}");
//         //test2.Invoke("Juan");
//
//         //Action<string> addSubsFunction = x => Console.WriteLine($"now time for {x}");
//         //Action<string> test3 = (x) => Console.WriteLine($"hello {x}");
//         //test3 += addSubsFunction;
//         //test3 -= addSubsFunction;
//         //test3.Invoke("Manolo");
//
//
//         //#endregion
//
//         #region Yield examples
//         var list = Enumerable.Range(1, 10)
//             .ToList();
//         var list2 = list.Filter(x => x % 2 == 0)
//             .Map(x => x % 3 == 0 ? x / 0 : x)
//             .CatchExceptions(ex => Console.WriteLine($"hey you {ex.Message}"))
//             .ToList();
//         list2.ForEach(x => Console.WriteLine(x));
//         //_ = list.HandleException(
//         //        items => items.Filter(x => x % 2 == 0).Map(x => x % 3 == 0 ? x / 0 : x).ToList(),
//         //        (ex, items) => Console.WriteLine($"Something happened: {ex.Message}."),
//         //        items => Console.WriteLine("finished"));
//         #endregion
//     }
// }
