using System;
using System.Collections.Generic;

namespace ProxifyCodilityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> {"MyApp.FirstCommand",
                            "MyApp.Command.WrongNs01Command",
                            "MyApp.Namespace.Commands.SecondCommand",
                            "MyApp.Commands.ThirdCommand",
                            "MyApp.Commands.SomeClass",
                            "MyApp.Commands.Namespace.TestClass" };

            Console.WriteLine(string.Join("CheckForMissingCommandSuffix:\n", ConventionTests.CheckForMissingCommandSuffix()) + "\n\n");
            Console.WriteLine(string.Join("CheckForCommandsOutsideNamespace:\n", ConventionTests.CheckForCommandsOutsideNamespace()) + "\n\n");
            Console.ReadKey();
        }
    }

}
