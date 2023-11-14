using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month;
            tryagain:
            {
                Console.Write("Enter month : ");
                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                }catch(FormatException e)
                {
                    Console.WriteLine("An error occured. Pls check your input again.\n"  + e);
                    goto tryagain;
                }catch(OverflowException e)
                {
                    Console.WriteLine("An error occured. Pls enter smaller values.\n" + e);
                    goto tryagain;
                }
            }
            switch(month)
            {
                case 12:
                case 1:
                case 2: Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5: Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8: Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11: Console.WriteLine("Autmn");
                    break;
                default: Console.WriteLine("Please enter a valid value !(1-12)");
                    goto tryagain;
            }
            Console.ReadKey();
        }
    }
}
