namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();

            clock.Tick += (sender, e) =>
            {
                Console.Write("Ticking...");
            };
            clock.Alarm += (sender, e) =>
            {
                Console.WriteLine("Alarming...");
            };

            clock.start();
            Console.WriteLine("end!");
        }
    }
}