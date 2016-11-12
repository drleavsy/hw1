using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
        internal class Program
        {
            private static void Main(string[] args)
            {
                int numb = 0;
                int diiv = 0;
                Console.Write("Please enter your number: ");
                string inp = Console.ReadLine();
                Console.Write("Please enter your divider: ");
                string divd = Console.ReadLine();
                bool flag = int.TryParse(inp, out numb) && numb >= -2147483648 && numb <= 2147483647 && int.TryParse(divd, out diiv) && diiv >= -2147483648 && diiv <= 2147483647;
                if (flag)
                {
                    bool flag2 = numb % diiv == 0;
                    if (flag2)
                    {
                        Console.WriteLine("Number {0}  can be divided by number {1} without reminder", numb, diiv);
                    }
                    else
                    {
                        Console.WriteLine("Number {0}  can not be divided by number {1} without reminder", numb, diiv);
                    }
                }
                else
                {
                    Console.WriteLine("The input is not a number, or not an integer.");
                }
                Console.WriteLine("Press ENTER to quit");
                Console.ReadLine();
            }
        }
    }

