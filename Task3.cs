namespace ConsoleApp6
{
    public static class DivisionCalculator
    {
        public static void Run()
        {
            Console.WriteLine("Enter the dividend (integer):");
            int dividend;
            while (!int.TryParse(Console.ReadLine(), out dividend))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the dividend:");
            }

            Console.WriteLine("Enter the divisor (integer):");
            int divisor;
            while (!int.TryParse(Console.ReadLine(), out divisor))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the divisor:");
            }

            try
            {
                int result = DivideNumbers(dividend, divisor);
                Console.WriteLine($"Result: {dividend} ÷ {divisor} = {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static int DivideNumbers(int dividend, int divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return dividend / divisor;
        }
    }
}
