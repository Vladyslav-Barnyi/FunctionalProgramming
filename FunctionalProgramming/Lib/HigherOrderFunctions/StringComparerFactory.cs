using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming.Lib.HigherOrderFunctions
{
    public static class StringComparerFactory
    {
        private static Func<string, string, bool> caseSensitiveComparer = (s1, s2) => string.Compare(s1, s2, true) == 0;
        private static Func<string, string, bool> caseInsensitiveComparer = (s1, s2) => string.Compare(s1, s2, true) == 0;
        private static Func<string, string, bool> reverseCaseSensitiveComparer = (s1, s2) => string.Compare(s1, s2, true) == 0;
        private static Func<string, string, bool> reverseCaseInsensitiveComparer = (s1, s2) => string.Compare(s1, s2, true) == 0;

        public static Func<string, string, bool> GetComparer(ComparerAlgorithm algorithm) => algorithm switch
        {
            ComparerAlgorithm.CaseInsensitive => (s1, s2) => string.Compare(s1, s2, true) == 0,
            ComparerAlgorithm.CaseSensitive => caseSensitiveComparer,
            ComparerAlgorithm.ReverseCaseSensitive => reverseCaseSensitiveComparer,
            ComparerAlgorithm.ReservseCaseInsensitive => reverseCaseInsensitiveComparer,
            _ => throw new NotImplementedException()
        };
    }
}
