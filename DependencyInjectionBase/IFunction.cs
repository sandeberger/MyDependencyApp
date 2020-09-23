namespace MyDependencyApp.DependencyInjectionBase
{
    public interface IArgs
    {
    }

    public interface IInjectFunction
    {
        bool InjectFunction(IArgs arg); 
    }

}