namespace FormatExceptionEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input to convert into int");
            var input = Console.ReadLine();
            try
            {
                int output = int.Parse(input);
                Console.WriteLine(output);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }

}
