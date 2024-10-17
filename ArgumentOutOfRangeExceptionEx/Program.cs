namespace ArgumentOutOfRangeExceptionEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name = "sanika";
                string subname = name.Substring(0, 8);
                Console.WriteLine(subname);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

}
