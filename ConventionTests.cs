using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace ProxifyCodilityTest
{
    public static class ConventionTests
    {
        public static IList<string> CheckForMissingCommandSuffix()
        {
            return Assembly.GetExecutingAssembly()
                .GetTypes().Where(x => x.FullName.StartsWith("MyApp.Commands.") && !x.FullName.EndsWith("Command"))
                .Select(x => x.FullName)
                .ToList();
        }

        public static IList<string> CheckForCommandsOutsideNamespace()
        {
            return Assembly.GetExecutingAssembly()
                .GetTypes().Where(x => !x.FullName.StartsWith("MyApp.Commands.") && x.FullName.EndsWith("Command"))
                .Select(x => x.FullName)
                .ToList();
        }

    }

}
