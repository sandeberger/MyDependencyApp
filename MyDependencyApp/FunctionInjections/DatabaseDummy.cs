using MyDependencyApp.Database;
using MyDependencyApp.DependencyInjectionBase;
using MyDependencyApp.FunctionInjection;

namespace MyDependencyApp.FunctionInjections
{
    public class DatabaseDummyArgs : IArgs
    {
        // IN
        public string connectionstring;
        public DummyConnection conn=null;

        //OUT
        public DummyConnection returncode;
    }
    class DatabaseDummy : IInjectFunction
    {
        public bool InjectFunction(IArgs args)
        {
            var myDbArgs = (DatabaseDummyArgs)args;
            if (myDbArgs.conn == null)
            {
                var db=new DummyDatabase();
                myDbArgs.returncode = db.Connect(myDbArgs.connectionstring);
            }
            else
            {
                if (!myDbArgs.conn.VerifyConnection())
                {
                    var db = new DummyDatabase();
                    myDbArgs.returncode = db.Connect(myDbArgs.connectionstring);
                }
                else
                {
                    myDbArgs.returncode = myDbArgs.conn;
                }
            }

            var consolelog = new FunctionInject();
            IArgs myConsoleArgs = new ConsoleLogArgs { text = $"Connection to database: {myDbArgs.connectionstring}" };
            consolelog.SetFunction(new ConcreteFunctionFactory().Create("consolelog").InjectFunction);
            consolelog.Invoke(myConsoleArgs);

            return true;
        }
    }
}
