using MyDependencyApp.DependencyInjectionBase;
using MyDependencyApp.FunctionInjections;
using System;

namespace MyDependencyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new FunctionInject();

            var myargs = new WorkerArgs();            
            worker.SetFunction(new ConcreteFunctionFactory().Create("worker").InjectFunction);
            worker.Invoke((IArgs)myargs);

            Environment.ExitCode=myargs.returncode;
        }
    }
}
