namespace P12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kolkko = int.Parse(Console.ReadLine());
            int obshto = 0;
            for (int ch = 1; ch <= kolkko; ch++)
            {
                int takova = ch;
                obshto = 0;
                while (takova > 0)
                {
                    obshto += takova % 10;
                    takova /= 10;
                }
                bool isSpecialNum = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine($"{ch} -> {isSpecialNum}");

                
            }
        }
    }
}