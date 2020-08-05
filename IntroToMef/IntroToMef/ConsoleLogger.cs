using System;
using System.ComponentModel.Composition;

namespace IntroToMef
{
    [Export(typeof(ILogger))]
    internal class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
        }

        public void Write(string myMessage)
        {
            Console.WriteLine(myMessage);
        }
    }
}