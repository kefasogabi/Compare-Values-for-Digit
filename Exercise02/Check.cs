using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise02
{
    class Check
    {
       

        public void Compare(string input1, string input2)
        {

            if (string.IsNullOrWhiteSpace(input1))
                input1 = @"^[a-z]+$?";
           
            bool containsInt = input2.Any(char.IsDigit);

            if (containsInt)
            {
               Console.WriteLine($"{input2} matches {input1} {containsInt = false}");
            }
            else
            {
                Console.WriteLine($"{input2} matches {input1} {containsInt = true}");
            }
            
        }
    }
}
