using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToMef
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new HostMefInAnApplication();
            host.Run();

            Console.Read();
        }
    }
}
