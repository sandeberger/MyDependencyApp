using MyDependencyApp.DependencyInjectionBase;
using System;

namespace MyDependencyApp.FunctionInjection
{
    public class ConsoleLogArgs : IArgs
    {
        public string text;
    }
    class ConsoleLog : IInjectFunction
    {
        public bool InjectFunction(IArgs args)
        {
            var myargs = (ConsoleLogArgs)args;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Console:{myargs.text}");
            Console.ForegroundColor = ConsoleColor.White;
            return true;
        }
    }
}
