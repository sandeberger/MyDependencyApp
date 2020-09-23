﻿using MyDependencyApp.DependencyInjectionBase;
using MyDependencyApp.FunctionInjection;

namespace MyDependencyApp.FunctionInjections
{
    public class WorkerArgs : IArgs
    {
        // IN

        // OUT
        public int returncode;
    }

    class Worker : IInjectFunction
    {
        public bool InjectFunction(IArgs args)
        {
#if true
            var consolelog = new FunctionInject();
            IArgs myargs = new ConsoleLogArgs { text = "?SYNTAX  ERROR" };
            consolelog.SetFunction(new ConcreteFunctionFactory().Create("consolelog").InjectFunction);
            consolelog.Invoke(myargs);
#else
            var filelog = new FunctionInject();
            IArgs myargs = new FileLogArgs { text = "?FILE NOT FOUND  ERROR", filename = "logg.txt" };
            filelog.SetFunction(new ConcreteFunctionFactory().Create("filelog").InjectFunction);
            filelog.Invoke(myargs);
#endif


            ((WorkerArgs)args).returncode=0; // Returning value to Main();
            return true;
        }
    }
}