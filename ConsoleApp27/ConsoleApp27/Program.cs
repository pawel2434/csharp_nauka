using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static string[] Calculation(string[] arr)
        {
            {
                while (true)
                {
                    Console.WriteLine("Write an expression with two numbers and an operator with space in-between, for example, 4 + 2");
                    string expression;
                    string[] array;
                    string[] array1;
                    expression = Console.ReadLine();
                    array = expression.Split();
                    array1 = Calculation(array);
                    Console.WriteLine("Press ENTER to write a new expression.");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
            
            {
                double numLeft = 0.0;
                double numRight = 0.0;
                string sign = "";
                double result = 0.0;
                int index = 1;

                while (true)
                {
                    numLeft = Convert.ToDouble(arr[0]);
                    sign = Convert.ToString(arr[index]);
                    numRight = Convert.ToDouble(arr[index + 1]);
                    index = index + 2;
                    if (sign == "+")
                    {
                        Console.Clear();
                        Console.WriteLine();
                        result = result + numLeft;
                    }
                    else if (sign == "-")
                    {
                        Console.Clear();
                        result = result + numLeft;
                        numLeft = 0 - numRight;
                    }
                    else if (sign == "*")
                    {
                        Console.Clear();
                        numLeft = numLeft * numRight;
                    }
                    else if (sign == "/")
                    {
                        Console.Clear();
                        numLeft = numLeft / numRight;
                    }
                    else
                    {
                        break;
                    }
                    result = result + numLeft;
                    Console.WriteLine("Answer: {0}", result);
                    return arr;
                }
                return arr;
            }
        }
    }
}
