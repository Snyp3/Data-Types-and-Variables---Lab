namespace P05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int countDigit = 0;

            for (int i = 1; i <= numbers; i++)
            {
                countDigit = 0;
                int forNum = i;

                while (forNum > 0)
                {
                countDigit += forNum % 10;
                forNum /= 10;

                }

                if (countDigit == 5 || countDigit == 7 || countDigit == 11 ) 
                {
                    Console.WriteLine($"{i} -> True");
                    continue;
                }
                else
                {
                   Console.WriteLine($"{i} -> False");
                    

                }

            }
        }
    }
}