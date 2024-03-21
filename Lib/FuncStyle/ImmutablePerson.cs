using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming.Lib.FuncStyle
{
    public record struct ImmutablePerson(string Name, int Age, ImmutableArray<string> PhoneNumbers)
    {
        public ImmutablePerson CopyTo() =>
            //new ImmutablePerson(Name, Age, PhoneNumbers.ToImmutableArray());
            this with { };
    }
}
