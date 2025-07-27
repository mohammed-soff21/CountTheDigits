namespace CountTheDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declaring variables
            char cUserChoice = ' ';
            int nGivenNumber = 0;
            while (true)
            {
                // Welcome message
                WelcomeApp("count the digits of a +ve integer number given by the user");
                // ReadNumber label
                ReadNumber:
                {
                    // ask the user to enter an integer number and validate the input
                    if (!IsNumber("a positive number", out nGivenNumber))
                        goto ReadNumber;
                }
                // To check if the number is less than or equal to zero
                if (!IsLessThanOrEqualToZero(nGivenNumber))
                    goto ContinuePrompt;
                // To count the digits of the given number and print the result
                Print($"The number of digits is: {CountDigits(nGivenNumber)}");

                // Continue prompt label
                ContinuePrompt:
                {
                    // To read user choice to continue in the app again and validate the user input
                    if (!IsChar("y to continue in the application else enter n", out cUserChoice))
                        return;
                    // Convert the character to lower 
                    cUserChoice = Char.ToLower(cUserChoice);
                    // To check the user input in the right format (y,n)
                    if (!IsInRightFormat(cUserChoice))
                        return;
                    // To check if the user want to continue or not
                    if (!WantToContinue(cUserChoice))
                        return;
                }

            }

        }


        #region Methods 

        // This region contains the main methods used in the application
        #region main-methods

        // 1) this method to welcome user in the beginning of the application
        static void WelcomeApp(String welcomeMessage)
        {
            Console.Clear();
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine($"  Welcome to {welcomeMessage} Application!");
            Console.WriteLine("  This app is designed to make your life easier.");
            Console.WriteLine("  Let's get started!");
            Console.WriteLine("  Developed by: Mohammed Salem");
            Console.WriteLine("*********************************************************************************");
        }

        // 2) this method to print message in a beatiful form
        static void Print(String message)
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine(message);
            Console.WriteLine("---------------------------------------------------------------------------------");
        }

        // 3) this method to read and validate character from the user
        static bool IsChar(string field, out char cInput)
        {
            Console.Write($"Please, enter {field}: ");
            if (!char.TryParse(Console.ReadLine(), out cInput))
            {
                Print("Please, enter a valid character");
                return false;
            }
            return true;
        }

        // 4) this method to check that the user entered (y,n) only
        static bool IsInRightFormat(char input)
        {
            if (input == 'y' || input == 'n')
                return true;
            Print("Please, enter (y) to continue in the application again else enter (n)");
            return false;
        }

        // 5) this method to check the user choice if he wants to continue in the app or not
        static bool WantToContinue(char input)
        {
            if (input == 'y')
                return true;
            Print("The program ended : see you soon again");
            return false;
        }

        // 6) this method to read and validate int number from the user
        static bool IsNumber(string field, out int nValue)
        {
            Console.Write($"Please, enter {field}: ");
            if (!int.TryParse(Console.ReadLine(), out nValue))
            {
                Print("Please, enter a valid number : try again");
                return false;
            }
            return true;
        }

        // 7) this method to check the number is less than or equal to zero
        static bool IsLessThanOrEqualToZero(int number)
        {
            if (number <= 0)
            {
                Print("Please, enter a number greater than zero");
                return false;
            }
            return true;
        }

        // 8) this method to count the digits of the given number
        static byte CountDigits(int number)
        {
            byte nCount = 0;
            while (true)
            {
                number = number / 10;
                if (number == 0)
                {
                    nCount++;
                    break;
                }
                else
                    nCount++;
            }
            return nCount;
        }
        #endregion


        #endregion

    }
}
