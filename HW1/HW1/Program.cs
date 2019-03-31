using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please isert your document list. There must be a passport.");
            String Docs = Console.ReadLine();

            if (Docs == "Passport")
            {

                Console.WriteLine("Please input your age, years only");
                int Age = Convert.ToInt32(Console.ReadLine());

                if (Age >= 18)
                {
                    Console.WriteLine("Do you have a photo? True\\False");
                    String isPhoto = Console.ReadLine();
                    if (isPhoto == "True")
                    {
                        Console.WriteLine("Thanks for your patience, you can proceed to payment now.");
                        Console.ReadLine();
                    }

                    if (isPhoto == "False")
                    {
                        Console.WriteLine("Please, proceed to a photo room to make a photo and then reapply for a visa.");
                        Console.ReadLine();
                    }
                }

                else
                {
                    Console.WriteLine("Do you have a permission from your parents? y\\n.");
                    char answerYN = Convert.ToChar(Console.ReadLine());
                    if (answerYN == 'y')
                    {
                        Console.WriteLine("Do you have a photo? True\\False");
                        String isPhoto = Console.ReadLine();
                        if (isPhoto == "True")
                        {
                            Console.WriteLine("Thanks for your patience, you can proceed to payment now.");
                            Console.ReadLine();
                        }

                        if (isPhoto == "False")
                        {
                            Console.WriteLine("Please, proceed to a photo room to make a photo and then reapply for a visa.");
                            Console.ReadLine();
                        }
                    }

                    if (answerYN == 'n')
                    {
                        Console.WriteLine("Please, ask your parents for a permission, and then reapply for a visa.");
                        Console.ReadLine();
                    }
                }
            }

            else
            {
                Console.WriteLine("Unfortunatley i cannot let you proceed. Please get your passport and reapply for a visa.");
                Console.ReadLine();
            }
        }
    }
}