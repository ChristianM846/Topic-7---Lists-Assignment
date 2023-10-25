namespace Topic_7___Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           bool done = false;
            string choice;
     
            while (!done) 
            {
                Console.WriteLine("Which program do you want to run:");
                Console.WriteLine("1 - Integer List");
                Console.WriteLine("2 - Veggies");
                Console.WriteLine("Q - quit");
                choice = Console.ReadLine().ToUpper().Trim();
                if (choice == "1")
                    IntegerList();
                else if (choice == "2")
                    Veggies();
                else if (choice == "Q")
                {
                    Console.WriteLine("Okay, goodbye.");
                    done = true;
                }
                else
                {
                    Console.WriteLine("That is an invalid choice, please try again");
                }

            }            
        }

        public static void IntegerList()
        {
            int numberGen, numberChoice, numberCount, largestNumber, smallestNumber, currentCount, largestCount;
            double sum;
            bool done = false;
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

            Console.WriteLine();
            Console.WriteLine("Here is a list of numbers between 10 and 20, inclusive:");
            Console.WriteLine();

            foreach (int number in numbers)
            {
                Console.Write(number + ", ");
            }

            while (!done)
            {
                largestCount = 0;
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
                Console.WriteLine("Q - Quit");
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

                    numbers.Add(numberChoice);
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

                    Console.WriteLine($"The sum of the numbers in the list is {sum}, and the average is {sum / numbers.Count}");
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
                        }

                        if (currentCount > largestCount)
                        {
                            largestCount = currentCount;
                            largest.Clear();
                            largest.Add(i);
                        }
                        else if (currentCount == largestCount)
                        {
                            largest.Add(i);
                        }
                    }

                    Console.WriteLine("The most frequently occuring number(s) are:");

                    foreach (int amount in largest)
                    {
                        Console.Write(amount + ", ");
                    }

                    Console.ReadLine();
                    Console.Clear();

                    foreach (int number in numbers)
                    {
                        Console.Write(number + ", ");
                    }
                }
                else if (choice == "Q")
                {
                    Console.WriteLine("Okay, goodbye.");
                    Console.WriteLine();
                    Console.Clear();
                    done = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }

            }
        }

        public static void Veggies()
        {
            int chosenIndex;
            bool done = false;
            bool match = false;
            string choice, chosenVeggie;

            List<string> veggies = new List<string>() { "CARROT", "BEET", "CELERY", "RADISH", "CABBAGE" };

            Console.WriteLine();
            Console.WriteLine("Here is a list of veggies:");
            Console.WriteLine();

            for (int i = 0; i < veggies.Count; i++)
            {
                Console.WriteLine($"{i+1}-{veggies[i]}");
            }
                

            while (!done)
            {
                match = false;
                Console.WriteLine("What operation would you like to perform to the list:");
                Console.WriteLine();
                Console.WriteLine("1 - Remove a veggie by index");
                Console.WriteLine("2 - Remove a veggie by name");
                Console.WriteLine("3 - Search for a veggie by name");
                Console.WriteLine("4 - Add a veggie to the list");
                Console.WriteLine("5 - Sort list alphabetically");
                Console.WriteLine("6 - Clear the list");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToUpper().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.WriteLine("Which index spot would you like me to clear (according to the numbering on screen)");

                    while (!Int32.TryParse(Console.ReadLine(),out chosenIndex))
                    {
                        Console.WriteLine("That is not a valid input, please try again.");
                    }

                    if (chosenIndex > veggies.Count || chosenIndex - 1 < 0)
                    {
                        Console.WriteLine("I'm sorry, that index is inavlid or does not exist");
                        Console.WriteLine();
                    }
                    else
                    {
                        veggies.RemoveAt(chosenIndex - 1);
                        Console.Clear();
                        Console.WriteLine("Here is the new list:");
                        Console.WriteLine();

                        for (int i = 0; i < veggies.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}-{veggies[i]}");
                        }
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Which veggie would you like me to remove:");
                    chosenVeggie = Console.ReadLine().ToUpper().Trim();

                    if (veggies.Contains(chosenVeggie))
                    {
                        veggies.Remove(chosenVeggie);
                        Console.Clear();
                        Console.WriteLine($"Here is the new list with {chosenVeggie} removed:");

                        for (int i = 0; i < veggies.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}-{veggies[i]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, that veggie is not on the list");
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("What veggie do you want me to search for:");
                    chosenVeggie = Console.ReadLine().ToUpper().Trim();

                    if (veggies.Contains(chosenVeggie)) 
                    {
                        Console.WriteLine($"{chosenVeggie} has been found in the list at index {veggies.IndexOf(chosenVeggie)} ({veggies.IndexOf(chosenVeggie) + 1} on screen)");
                        Console.ReadLine();

                        Console.Clear();

                        for (int i = 0; i < veggies.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}-{veggies[i]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{chosenVeggie} was not found in the list.");
                        Console.ReadLine();
                        Console.Clear();

                        for (int i = 0; i < veggies.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}-{veggies[i]}");
                        }
                    }

                }
                else if (choice == "4")
                {
                    Console.WriteLine("What is the name of the veggie you would like to add");
                    chosenVeggie = Console.ReadLine().ToUpper().Trim();

                    foreach (string veggie in veggies)
                    {
                        if (chosenVeggie == veggie)
                        {
                            match = true;
                        }
                    }

                    if (match == true)
                    {
                        Console.WriteLine($"I'm sorry, {chosenVeggie} already exists in the list");
                        Console.ReadLine();
                        Console.Clear();

                        for (int i = 0; i < veggies.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}-{veggies[i]}");
                        }

                    }
                    else
                    {
                        veggies.Add(chosenVeggie);
                        Console.WriteLine($"{chosenVeggie} has been added to the list");
                        Console.ReadLine();
                        Console.Clear();

                        for (int i = 0; i < veggies.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}-{veggies[i]}");
                        }
                    }
                }
                else if (choice == "5")
                {
                    veggies.Sort();
                    Console.Clear();
                    Console.WriteLine("Here is the sorted list:");
                    Console.WriteLine();

                    for (int i = 0; i < veggies.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}-{veggies[i]}");
                    }
                }
                else if (choice == "6")
                {
                    Console.WriteLine("Okay, the list has been cleared");
                    veggies.Clear();
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    for (int i = 0; i < veggies.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}-{veggies[i]}");
                    }
                }
                else if (choice == "Q")
                {
                    Console.WriteLine("Okay, goodbye.");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    done = true;
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