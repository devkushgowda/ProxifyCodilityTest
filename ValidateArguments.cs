using System;

namespace ProxifyCodilityTest
{
    public class ValidateArguments
    {
        //static readonly HashSet<string> supportedCommands = new HashSet<string> { "--help", "--name", "--count" };

        public int Validate(string[] args)
        {
            if (args == null || args.Length == 0)
                return -1;
            Console.WriteLine(string.Join(", ", args));
            var isHelp = false;
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i].ToLower())
                {
                    case "--help":
                        isHelp = true;
                        break;
                    case "--name":
                        {
                            if (i == args.Length - 1 || !ValidName(args[i + 1]))
                                return -1;
                            i++;
                            break;
                        }
                    case "--count":
                        {
                            if (i == args.Length - 1 || !ValidCount(args[i + 1]))
                                return -1;
                            i++;
                            break;
                        }
                    default:
                        return -1;
                }
            }
            return isHelp ? 1 : 0;
        }

        private bool ValidCount(string v)
        {
            return int.TryParse(v, out int number) && number >= 10 && number <= 100;
        }

        private bool ValidName(string v)
        {
            return v.Length >= 3 && v.Length <= 100;
        }
    }

}
