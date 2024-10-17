namespace DivideByZeroExceptionEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taking two numbers as input
            Console.WriteLine("Enter Number one:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number two:");
            int num2 = int.Parse(Console.ReadLine());

            //Putting doubtable code in try block
            try
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException();

                }
                else if (num2 != 0)
                {
                    int div = num1 / num2;
                    Console.WriteLine("division is:" + div);
                }
            }

            //It will throw Message if exception occurs
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }




        }



    }

}
