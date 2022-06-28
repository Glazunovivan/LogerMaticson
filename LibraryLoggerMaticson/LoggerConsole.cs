using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLoggerMaticson
{
    public class LoggerConsole : Logger
    {
        public string Name => _name;

        public LoggerConsole() { }

        public LoggerConsole(string name) : base(name)
        {
        }

        public override void Debug(string message)
        {
            Console.WriteLine($"{ShowName()}DEBUG. {message}");
        }

        public override void Error(string message)
        {
            Console.WriteLine($"{ShowName()}ERROR. {message}");
        }

        public override void Info(string message)
        {
            Console.WriteLine($"{ShowName()}INFO. {message}");
        }

        public override void Warn(string message)
        {
            Console.WriteLine($"{ShowName()}WARN. {message}");
        }
    }
}
