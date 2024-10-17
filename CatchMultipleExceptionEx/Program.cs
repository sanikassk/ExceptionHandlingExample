namespace CatchMultipleExceptionEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number one");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter number two");
            int num2 = int.Parse(Console.ReadLine());

            try
            {

                int div = num1 / num2;
                Console.WriteLine("division is:" + div);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("enter input");
            var input = (Console.ReadLine());
            try
            {

                int output = int.Parse(input);
                Console.WriteLine(output);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

}
