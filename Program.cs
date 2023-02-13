namespace CottrellA3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;

            Console.WriteLine($"{now,40:MMMM dd,yyyy}");
            Console.WriteLine($"{now:yyyy.MM.dd}");
            Console.WriteLine($"Day {now:dd} of {now:MMMM,yyyy}");
            Console.WriteLine($"Year:{now:yyyy},Month:{now:MM},Day:{now:dd}");
            Console.WriteLine($"{now,10:dddd}");
            Console.WriteLine($"{now,10:t}{now,10:dddd}");
            Console.WriteLine($"h:{now:hh},m:{now:mm},s:{now:ss}");
            Console.WriteLine($"{now:yyyy.MM.dd}.{now:hh.mm.ss}");

            Console.WriteLine("");

            var pi = Math.PI;

            Console.WriteLine($"{pi:C2}");
            Console.WriteLine($"{pi,15:N3}");



        }
    }
}