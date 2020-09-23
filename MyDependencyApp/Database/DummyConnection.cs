using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDependencyApp.Database
{
    public class DummyConnection
    {
        /*public List<string> Execute(string sql)
        {

        }*/

        public bool VerifyConnection()
        {
            return true;
        }

        public void Disconnect()
        {
            //Console.WriteLine("Dummydatabase-connection is now disconnected");
        }
    }
}
