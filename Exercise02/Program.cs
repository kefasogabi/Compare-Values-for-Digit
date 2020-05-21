using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2;
            string more = "yes";

            

           
            try
            {

                var check = new Check();
                while (more == "yes")
                {
                    Console.Write("Enter a Regular expression ( or press Enter to  the default): ");
                    input1 = Convert.ToString(Console.ReadLine());
                    Console.Write("Enter some input: ");
                    input2 = Convert.ToString(Console.ReadLine());
                    check.Compare(input1, input2);

                    Console.Write("do you want to check again (Yes/No): ");
                    more = Convert.ToString(Console.ReadLine()).ToLower();
                }
                
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
