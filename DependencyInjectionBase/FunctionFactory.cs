using MyDependencyApp.FunctionInjection;
using System;

namespace MyDependencyApp.DependencyInjectionBase
{
    abstract class FunctionFactory
    {
        public abstract IInjectFunction Create(string type);
    }

    class ConcreteFunctionFactory : FunctionFactory
    {
        public override IInjectFunction Create(string type)
        {
            switch (type)
            {
                case "consolelog": return new ConsoleLog();
                case "filelog": return new FileLog();
                default: throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
