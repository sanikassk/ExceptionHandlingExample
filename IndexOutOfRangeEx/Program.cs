namespace IndexOutOfRangeEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine("enter the index");
            int index = int.Parse(Console.ReadLine());


            try
            {
                Console.WriteLine(arr[index]);
                if (arr[index] > arr.Length)
                {

                }

            }

            catch (IndexOutOfRangeException ex)
            {


                Console.WriteLine(ex.Message);


            }


        }
    }

}
