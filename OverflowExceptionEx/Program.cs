namespace OverflowExceptionEx
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter larger integer value");

            try
            {

                int input = int.Parse(Console.ReadLine());


            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

        }
    }
}
