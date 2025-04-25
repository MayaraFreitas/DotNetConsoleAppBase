namespace BasicConsoleApp
{
    public class Startup
    {
        public void Run()
        {
            // This is where the application starts running
            Console.WriteLine("Type in your text:");

            var lines = new List<string>();
            var line = Console.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                lines.Add(line);
                line = Console.ReadLine();
            }

            foreach(var text in lines)
            {
                Console.WriteLine(text);
            }
        }
    }
}
