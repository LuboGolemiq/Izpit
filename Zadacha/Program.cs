namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <=5; i++)
            {
                if (n < 255)
                {

                    Console.WriteLine("incufficient capacity");
                    int answer = 255 - n;
                    Console.WriteLine($"{answer}");
                    sum = 0;

                    sum = n + sum;
                }
            }



        }
    }
}
