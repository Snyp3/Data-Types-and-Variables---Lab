namespace P04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            double years = centuries * 100;
            decimal days = Math.Floor((decimal)(years * 365.2422));
            decimal hours = Math.Floor(days * 24);
            decimal minutes = Math.Floor(hours * 60);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days =" +
                $" {hours} hours = {minutes} minutes");
        }
    }
}