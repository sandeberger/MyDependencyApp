using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDependencyApp.Database
{
    public class DummyDatabase
    {
        public DummyConnection Connect(string conn)
        {
            //Console.WriteLine("Dummydatabase-connection is now connected");
            return new DummyConnection();
        }
    }
}
