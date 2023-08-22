namespace oneYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            var result = (OneYear)number;
            Console.WriteLine(result);
        }
    }
}