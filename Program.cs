namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER 1St NUMBER");
            int a = int.Parse(Console.ReadLine()!);


            Console.WriteLine("ENTER 2Scd NUMBER");

            int s = int.Parse(Console.ReadLine()!);

            for (int j = a; j <= s; j++)
            {
               int i = 1;
             int   sum = 0;
                while (i < j)
                {
                    if (j % i == 0)
                        sum += i;
                    i++;
                }
                if (sum ==j)
                    Console.WriteLine(j+"is perfect number");
            }
        }
    }
}