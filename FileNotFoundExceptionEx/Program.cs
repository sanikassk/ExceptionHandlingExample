namespace FileNotFoundExceptionEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            string fileName = "sani.txt";
            try
            {
                string content = File.ReadAllText("sani.txt");
                Console.WriteLine("content");

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

    }

}
