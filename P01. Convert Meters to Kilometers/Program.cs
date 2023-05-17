namespace P01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meter = double.Parse(Console.ReadLine());

            double meterToKm = meter / 1000;

            Console.WriteLine($"{meterToKm:f2}");

        }
    }
}