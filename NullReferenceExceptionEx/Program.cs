namespace NullReferenceExceptionEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name = null;
                int length = name.Length;
                Console.WriteLine(length);

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
