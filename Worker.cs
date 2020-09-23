using MyDependencyApp.DependencyInjectionBase;
using MyDependencyApp.FunctionInjection;

namespace MyDependencyApp.Base
{
    // Worker är en klass som är helt utan beroenden
    class Worker
    {
        public void Run()
        {
            var functionInjector = new FunctionInject();

#if true
            IArgs args = new ConsoleLogArgs { text = "?SYNTAX  ERROR" };
            var logger = new ConcreteFunctionFactory().Create("consolelog");
#else
            IArgs args = new FileLogArgs { text = "?SYNTAX  ERROR", filename = "logg.txt" };
            var logger = new ConcreteFunctionFactory().Create("filelog");
#endif

            functionInjector.SetFunction(logger.InjectFunction);
            functionInjector.Invoke(args);
        }
    }
}
