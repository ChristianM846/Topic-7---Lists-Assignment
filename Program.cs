namespace Topic_7___Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberGen, numberChoice, numberCount, largestNumber, smallestNumber, currentCount, largestCount, mostFrequent;
            double sum;
            bool done1 = false, done2 = false;
            string choice;
            choice = "";
            Random genrator = new Random();

            List<int> numbers = new List<int>();
            List<int> largest = new List<int>();

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
                largestCount = 0;
                mostFrequent = 0;
                sum = 0;
                numberCount = 0;
                largestNumber = 10;
                smallestNumber = 20;

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

                    foreach (int number in numbers)
                    {
                        Console.Write(number + ", ");
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Choose which value you wish to remove from the list");

                    while (!Int32.TryParse(Console.ReadLine(), out numberChoice) || numberChoice > 20 || numberChoice < 10)
                    {
                        Console.WriteLine("I'm sorry, that's not a valid input. Please input a whole integer value between 10-20:");
                    }

                    while (numbers.Contains(numberChoice))
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == numberChoice)
                            {
                                numbers.Remove(numbers[i]);
                            }
                        }
                    }
                    Console.Clear();
                    Console.WriteLine($"Here is the new list with all {numberChoice}'s removed:");
                    Console.WriteLine();

                    foreach (int number in numbers)
                    {
                        Console.Write(number + ", ");
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Choose a number you'd like to add to the end of the list:");
                    
                    while (!Int32.TryParse(Console.ReadLine(), out numberChoice) || numberChoice > 20 || numberChoice < 10)
                    {
                        Console.WriteLine("That is not a valid input, please input a whole number between 10-20:");
                    }

                    numbers.Add (numberChoice);
                    Console.Clear();
                    Console.WriteLine("Here is your new list, with the new value;");

                    Console.WriteLine();

                    foreach (int number in numbers)
                    {
                        Console.Write(number + ", ");
                    }

                }
                else if (choice == "5")
                {
                    Console.WriteLine("Choose which value you wish for me to count");

                    while (!Int32.TryParse(Console.ReadLine(), out numberChoice) || numberChoice > 20 || numberChoice < 10)
                    {
                        Console.WriteLine("I'm sorry, that's not a valid input. Please input a whole integer value between 10-20:");
                    }

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == numberChoice)
                            {
                                numberCount++;
                            }
                        }

                    Console.WriteLine($"There are {numberCount} instances of the number {numberChoice} in the list:");
                    Console.ReadLine();
                    Console.Clear();

                    foreach (int number in numbers)
                    {
                        Console.Write(number + ", ");
                    }

                }
                else if (choice == "6")
                {
                    foreach (int number in numbers)
                    {
                        if (number > largestNumber)
                        {
                            largestNumber = number;
                        }
                    }

                    Console.WriteLine($"The largest number in the list is {largestNumber}");
                    Console.ReadLine();
                    Console.Clear();

                    foreach (int number in numbers)
                    {
                        Console.Write(number + ", ");
                    } 

                }
                else if (choice == "7")
                {
                    foreach (int number in numbers)
                    {
                        if (number < smallestNumber)
                        {
                            smallestNumber = number;
                        }
                    }

                    Console.WriteLine($"The smallest number in the list is {smallestNumber}");
                    Console.ReadLine();
                    Console.Clear();

                    foreach (int number in numbers)
                    {
                        Console.Write(number + ", ");
                    }
                }
                else if (choice == "8")
                {
                    foreach (int number in numbers)
                    {
                        sum += number;
                    }

                    Convert.ToDouble(sum);

                    Console.WriteLine($"The sum of the numbers in the list is {sum}, and the average is {sum/numbers.Count}");
                    Console.ReadLine();
                    Console.Clear();

                    foreach (int number in numbers)
                    {
                        Console.Write(number + ", ");
                    }
                }
                else if (choice == "9")
                {
                    for (int i = 10; i < 21; i++)
                    {
                        currentCount = 0;

                        foreach (int number in numbers)
                        {
                            if (i == number)
                            {
                                currentCount++;
                            }

                            if (currentCount > largestCount)
                            {
                                largestCount = currentCount;
                                largest.Clear();
                                largest.Add(i);
                                Console.WriteLine("Cleared and added"); // testing
                            }
                            else if (currentCount == largestCount)
                            {
                                largest.Add(i);
                                Console.WriteLine("Added"); // tesing
                            }
                            else
                            {
                                Console.WriteLine("nothing"); // thesting
                            }
                            
                        }
                    }

                    foreach (int amount in largest)
                    {
                        Console.Write(amount + ", "); // testing
                    }

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