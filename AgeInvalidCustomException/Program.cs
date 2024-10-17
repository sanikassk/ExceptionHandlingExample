namespace AgeInvalidCustomException
{
    public class AgeInvalidException : Exception
    {
        public AgeInvalidException(string message) : base(message)
        {

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter age");
            int age = int.Parse(Console.ReadLine());
            try
            {
                if (age < 18)
                {
                    throw new AgeInvalidException("age must be greater than 18");
                }
                else
                {
                    Console.WriteLine("you are eligible");
                }
            }
            catch (AgeInvalidException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
