/* 
PROGRAM (2): Based on what you have learned from the Iterative Statements example, write a C# Program Console Program with Iterative Statements, that does the following: 
1. Choose to write your program with only 1 of the 3 choices of Iterative Statements: While, For, or Do While (Just choose 1)
2. Ask the user to enter an integer value between 1 and 100.
3. Ask the user to specify a series of integer numbers. There are two options: even numbers and odd numbers.
4. Then, have the program display the following message: "You have selected the *series name* series. The numbers between 0 and *user’s input* are:”
5. Finally, have the program display all the numbers from the series between 0 and the user’s input. 

NOTE: Use a try/catch block to validate the user's entry.

EXAMPLE:
INTEGER INPUT: 5
STRING INPUT: Odd
OUTPUT: 
You have selected the odd series. The numbers between 0 and 5 are:
1
3
5

Once you complete this program, upload it to GitHub. Then, paste your GitHub Link to GitHub here.*/

namespace Deliverable3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer number");
                int input = int.Parse(Console.ReadLine());

                if ((input > 0) && (input <= 100))
                {
                    Console.WriteLine("Enter a series name (even, odd) ");
                    string series_name = Console.ReadLine();

                    if (series_name == "even")
                    {
                        int i = 1;
                        int even = 0;

                        while (even <= input)
                        {
                            Console.WriteLine(even.ToString() + " is an even number");
                            even = 2 * i;
                            i++;
                        }
                    }


                    else if (series_name == "odd")
                    {
                        int j = 1;
                        int odd = 1;

                        while (odd <= input)
                        {
                            Console.WriteLine(odd.ToString() + "is an odd number");
                            odd = 2 * j + 1;
                            j++;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Select an option between even and odd");
                    }

                    Console.ReadKey(true);
                }

                else
                {
                    Console.WriteLine("Enter an integer between 1 and 100");
                }


            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try again");
                Console.ReadKey(false);
            }
        }
    }
}
