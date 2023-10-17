namespace Topic_7___Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberGen, numberChoice;
            bool done1 = false, done2 = false;
            string choice;
            choice = "";
            Random genrator = new Random();

            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                numberGen = genrator.Next(10, 21);
                numbers.Add(numberGen);
            }

            Console.WriteLine("Here is a list of numbers between 10 and 20, inclusive:");
            Console.WriteLine();

            foreach (int number in numbers)
            {
                Console.Write(number + ", ");
            }

            while (done1 == false)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("What operation would you like to perform on the list:");
                Console.WriteLine("1 - Sort the list");
                Console.WriteLine("2 - Re-roll a new list");
                Console.WriteLine("3 - Remove a number (By value)");
                Console.WriteLine("4 - Add a value");
                Console.WriteLine("5 - Count the number of occurences of a number");
                Console.WriteLine("6 - Print the largest value");
                Console.WriteLine("7 - Print the smallest value");
                Console.WriteLine("8 - Print the sum and average of the values");
                Console.WriteLine("9 - Determine the most frequently occuring value(s)");
                Console.WriteLine("Q - Quit and continue to second list");
                Console.WriteLine();
                choice = Console.ReadLine().ToUpper().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    numbers.Sort();
                    Console.Clear();
                    Console.WriteLine("Here is the sorted list:");
                    Console.WriteLine();
                    foreach (int number in numbers)
                    {
                        Console.Write(number + ", ");
                    }
                }
                else if (choice == "2")
                {
                    numbers.Clear();
                    Console.Clear();
                    Console.WriteLine("Here is the new list");
                    Console.WriteLine();

                    for (int i = 0; i < 25; i++)
                    {
                        numberGen = genrator.Next(10, 21);
                        numbers.Add(numberGen);
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Choose which value you wish to remove from the list");

                    while (Int32.TryParse(Console.ReadLine(), out numberChoice) || numberChoice > 20 || numberChoice < 10)
                    {
                        Console.WriteLine("I'm sorry, that's not a valid input. Please input a whole integer value between 10-20:");
                    }

                }
                else if (choice == "4")
                {
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "5")
                {
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "6")
                {
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "7")
                {
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "8")
                {
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "9")
                {
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "Q")
                {
                    Console.WriteLine("Okay, let's move on.");
                    done1 = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }

            }
        }
    }
}