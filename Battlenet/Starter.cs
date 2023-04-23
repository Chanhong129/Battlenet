using Battlenet.Properties;
using System;

namespace Battlenet
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App()
                .AddModule<DirectModules>()
                .WireViewModel()
                .Run();
        }
    }
}
