using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DBManager manager1 =  DBManager.CreateDbManager("connection");
            manager1.StateMessage = "Message1";

            DBManager manager2 = DBManager.CreateDbManager("connection2");
            Console.WriteLine(manager2.StateMessage);

            Console.ReadKey();

        }
    }
}
