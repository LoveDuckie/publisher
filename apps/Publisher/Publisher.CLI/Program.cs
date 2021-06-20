using System;

namespace Publisher.CLI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PublisherCLIFramework framework = new PublisherCLIFramework(args);
            if (!framework.Execute())
            {

            }


        }
    }
}
