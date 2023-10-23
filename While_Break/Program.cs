namespace While_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                int nextNum = int.Parse(Console.ReadLine());
                if (nextNum == 0)
                {
                    break;
                }
                sum += nextNum;
                Console.WriteLine("sum: " + sum);
            }
        }
    }
}