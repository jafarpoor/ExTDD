using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDD.Services
{
    public class Sum
    {

        public int Execute(string Numbers)
        {
            int Sum = 0;
            if (string.IsNullOrEmpty(Numbers))
                return 0;

            if (Numbers.EndsWith(','))
                Numbers = Numbers.Substring(0, Numbers.Length - 1);
            string[] StringNumber = Numbers.Split(',');
            int[] IntNumers = Array.ConvertAll(StringNumber, s => int.Parse(s));
            return IntNumers.Sum();

        }
    }
}
