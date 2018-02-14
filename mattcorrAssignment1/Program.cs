using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mattcorrAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            char edType;
            double salaryData;
            Console.WriteLine("Please enter the level of educaton >");
            edType = Convert.ToChar(Console.ReadLine());
            edType = Char.ToLower(edType);
            while (edType != 'q')
            {
                switch (edType)
                {
                    case 'u':
                        Console.WriteLine("You Selected: University");
                        break;
                    case 'c':
                        Console.WriteLine("You Selected: College");
                        break;
                    case 'h':
                        Console.WriteLine("You Selected: High-School");
                        break;
                }

                Console.WriteLine("Enter Salary Amount");
                salaryData = Convert.ToDouble(Console.ReadLine());

                Console.ReadKey();
            }
            Environment.Exit(0);
        }
    }
}
