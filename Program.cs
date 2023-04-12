namespace Gangetabell
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Bredden på skjermen er{Console.WindowWidth}");
                Console.WriteLine("Skriv et tall");
                var input = Console.ReadLine();
                var isNumber = int.TryParse(input, out int number);

                if (!isNumber) continue;
                int width = number * 7;
                Console.WindowWidth = width;
                var numberList = new Row(number, width);

                numberList.GenerateMatrix();
                Console.WriteLine("Trykk enter for nytt tall");
                Console.ReadLine();
            }
        }
    }
}