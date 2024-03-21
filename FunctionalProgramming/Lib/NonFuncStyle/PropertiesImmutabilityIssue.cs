using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming.Lib.NonFuncStyle
{
    public class PropertiesImmutabilityIssue
    {
        //// no way to have readonly properties, as the constructor of the property gets called before accessing the current value
        //public readonly int _age;
        //public readonly string _name;
        //public readonly string[] _phoneNumbers;

        ////compile error
        //public int Age { get; private set; }
        //public string Name { get; }
        //public string[] PhoneNumbers { get; }

        //// using a backing field
        //private readonly int _age;
        //public int Age { get => _age; }
        //public PropertiesImmutabilityIssue(int age)
        //{
        //    _age = age;
        //}

        //// with init keyword no way to change the variable through reflection
        public string Name { get; init; }
        public int Age { get; init; }
        public string[] PhoneNumbers { get; init; }

        public PropertiesImmutabilityIssue(string name, int age, string[] phoneNumbers)
        {
            Name = name;
            Age = age;
            PhoneNumbers = phoneNumbers;
        }
    }
}
