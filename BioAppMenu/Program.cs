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
                Console.WriteLine("Type 0 to exit");
                Console.WriteLine("Type 1 to enter your personal Details");

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
                        //ExitFromMenu();
                        return;
                    case 1:
                        //NumberOfPersons();
                        break;
                    default:
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        break;
                }
            }
        }

       
    }
}




