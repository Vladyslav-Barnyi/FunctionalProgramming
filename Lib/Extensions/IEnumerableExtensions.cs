using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming.Lib.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<int> GreaterThanNonFunc(int[] array, int gt)
        {
            List<int> result = new(); 
            foreach (int item in array)
            {
                if (item > gt)
                {
                    result.Add(item); // state changed
                }
            }
            return result;
        }
        public static IEnumerable<int> GreaterThanFunc(int[] array, int gt)
        {
            foreach (int item in array)
            {
                if (item > gt)
                {
                    yield return item;
                }
            }
        }
    }
}
