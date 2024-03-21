using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming.Lib.NonFuncStyle
{
    public static class ImperativeStyle
    {
        public static string GetSalutation(int hour)
        {
            string salutation;
            if (hour > 12)
            {
                salutation = "Good morning";
            }
            else
            {
                salutation = "Good afternoon";
            }
            return salutation; //mutated variable
        }
        public static void NonFunctionalExample(string text)
        {
            using (StringReader rdr = new StringReader(text))
            {
                string contents = rdr.ReadToEnd();
                string[] words = contents.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].Trim();
                }

                Dictionary<string, int> d = new Dictionary<string, int>();

                foreach (string word in words)
                {
                    if (d.ContainsKey(word))
                    {
                        d[word]++;
                    }
                    else
                    {
                        d.Add(word, 1);
                    }
                }

                foreach (KeyValuePair<string, int> kvp in d)
                {
                    Console.WriteLine(string.Format("({0}, {1})", kvp.Key, kvp.Value.ToString()));
                }
            }
        }
        public static int Factorial(int number)
        {
            var result = 1;
            for (int i = number; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
