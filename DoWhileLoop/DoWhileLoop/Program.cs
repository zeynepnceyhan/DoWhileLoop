namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
            Console.ReadLine();
        }
    }
}