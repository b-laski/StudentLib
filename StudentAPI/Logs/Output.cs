using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Logs
{
    public static class Output
    {
        public static void Log(string message, Enums.LogTypes type = Enums.LogTypes.Normal)
        {
            lock(Console.Out)
            {
                ConsoleColor color = Console.ForegroundColor;
                switch(type)
                {
                    case Enums.LogTypes.Normal:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case Enums.LogTypes.Success:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Enums.LogTypes.Fail:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }

                Console.WriteLine($"#[StudentLib] {message}");
                Console.ForegroundColor = color;
            }
        }
    }
}
