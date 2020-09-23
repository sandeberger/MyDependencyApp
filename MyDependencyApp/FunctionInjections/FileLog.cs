using MyDependencyApp.DependencyInjectionBase;
using System;

namespace MyDependencyApp.FunctionInjection
{
    public class FileLogArgs : IArgs
    {
        // IN
        public string filename;
        public string text;

        //OUT
    }

    class FileLog : IInjectFunction
    {
        public bool InjectFunction(IArgs args)
        {
            var myargs = (FileLogArgs)args;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"File {myargs.filename}: {myargs.text}");
            Console.ForegroundColor = ConsoleColor.White;
            return true;
        }

    }
}
