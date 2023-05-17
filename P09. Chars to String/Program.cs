namespace P09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());

            string stringOne = one.ToString();
            string stringTwo = two.ToString();
            string stringThree = three.ToString();

            Console.WriteLine(stringOne + stringTwo + stringThree);

        }
    }
}