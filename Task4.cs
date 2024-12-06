namespace ConsoleApp6
{
    public static class Task4ValidateAge // Task 4
    {
        public static string ValidateAge(int age)
        {
            if (age < 0 || age > 150)
                throw new InvalidAgeException("Age must be between 0 and 150.");

            return "Age is valid.";
        }

        public static void Run()
        {
            Console.WriteLine("Enter an age to validate:");

            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for age:");
            }

            try
            {
                string result = ValidateAge(age);
                Console.WriteLine(result);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

}
