using System;

namespace server
{
class Program
{
    static void Main(string[] args)
    {
        int counter = 0;

        while (true)
        {
            Console.WriteLine(counter++);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
}
