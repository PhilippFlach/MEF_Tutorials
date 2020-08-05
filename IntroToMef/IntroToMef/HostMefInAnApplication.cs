using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace IntroToMef
{
    internal class HostMefInAnApplication
    {
        public HostMefInAnApplication()
        {
        }

        [Import]
        protected ILogger Logger { get; private set; }

        internal void Run()
        {
            Compose();
            Logger.Write("My message");
        }

        private void Compose()
        {
            var container = new CompositionContainer();
            container.ComposeParts(this, new ConsoleLogger());
        }
    }
}