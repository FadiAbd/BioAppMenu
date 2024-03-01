namespace BioAppMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Display welcome message
            Console.WriteLine("Welcome to the main menu!");

            while (true)
            {
                // Display menu options
                Console.WriteLine();
                Console.WriteLine("Type 0 to exit");
                Console.WriteLine("Type 1 to enter your personal Details");
                Console.WriteLine("Type 2 to enter a word.");
                Console.WriteLine("Type 3 to enter a sentense with minimum of 3 words.");

                // Get user input to just enter an integer
                int userChoice;
                if (!int.TryParse(Console.ReadLine(), out userChoice))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue; // Restart the loop
                }

                // Perform action based on user input
                switch (userChoice)
                {
                    case 0:
                        ExitFromMenu();
                        return;
                    case 1:
                        NumberOfPersons();
                        break;
                    case 2:
                        PrintAString();
                        break;
                    case 3:
                        ManupilateAString();
                        break;
                    default:
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        break;
                }
            }
        }

        private static void ManupilateAString()
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();

            string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write($"{i + 1}.{words[i]}");
                if (i < words.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
            if (words.Length >= 3)
            {
                Console.WriteLine($"The third word is: {words[2]}");
            }
            else
            {
                Console.WriteLine("The sentense does not have enough words!");
            }
            Console.WriteLine();

        }

        // Iteration over user input
        private static void PrintAString()
        {
            Console.WriteLine("word: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{userInput} ");

            }
        }


        // Method to exit from the menu
        private static void ExitFromMenu()
        {
            Console.WriteLine("Exiting the menu. Goodbye!");
        }

        /* Get the number of persons  and age entered
         * by the user and validate it and calculate 
            Total cost while calling other methods */
        private static void NumberOfPersons()
        {
            Console.WriteLine("How many persons in total?");
            int totalPersons;
            while (!int.TryParse(Console.ReadLine(), out totalPersons) || totalPersons <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a valid number greater than 0:");
            }

            int ungdom = 0;
            int pensionar = 0;
            int standard = 0;

            // Collect age information for each person
            for (int i = 0; i < totalPersons; i++)
            {
                Console.WriteLine($"Person {i + 1}:");
                Console.WriteLine("Age?");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number for your age:");
                }

                string personType = GetPersonType(age);
                Console.WriteLine($"{personType} price: {GetPrice(personType)} Kr");

                // Count persons based on type
                switch (personType)
                {
                    case "Ungdom":
                        ungdom++;
                        break;
                    case "Pensionär":
                        pensionar++;
                        break;
                    case "Standard":
                        standard++;
                        break;
                }
            }

            // Calculate total cost based on GetPrice method
            int totalCost = (ungdom * GetPrice("Ungdom")) +
                (pensionar * GetPrice("Pensionär")) +
                (standard * GetPrice("Standard"));

            // Display results
            Console.WriteLine($"Total persons: {totalPersons}");
            Console.WriteLine($"Ungdom persons: {ungdom}");
            Console.WriteLine($"Pensionär persons: {pensionar}");
            Console.WriteLine($"Standard persons: {standard}");
            Console.WriteLine($"Total price for all: {totalCost} Kr");
        }

        // Method to get price based on person type
        private static int GetPrice(string personType)
        {
            switch (personType)
            {
                case "Ungdom":
                    return 80;
                case "Pensionär":
                    return 90;
                case "Standard":
                    return 120;
                default:
                    return 0;
            }
        }

        private static string GetPersonType(int age)
        {
            if (age < 20)
                return "Ungdom";
            else if (age > 64)
                return "Pensionär";
            else
                return "Standard";
        }
    }
}




