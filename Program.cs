using MyDependencyApp.Base;

namespace MyDependencyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var starter = new Worker();
            starter.Run();

        }
    }
}
