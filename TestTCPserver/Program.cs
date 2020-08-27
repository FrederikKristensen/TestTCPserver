using System;

namespace TestTCPserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Serverworker worker = new Serverworker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
