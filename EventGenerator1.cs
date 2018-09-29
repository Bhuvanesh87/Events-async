using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Delegates
{
    public delegate void LinkToEventHandler();
    class Client1
    {
        string name;
        public Client1(string nameArg)
        {
            name = nameArg;
        }
        public void Client1EventHandler()
        {
            Console.WriteLine("EventHandler Called for object {0}", name);
        }
    }
    class EventGenerator1
    {
        public static event LinkToEventHandler Evt;
        public static void Main()
        {
            Client1 c1_o1 = new Client1("Object1 of Client1 class");
            Evt += new LinkToEventHandler(c1_o1.Client1EventHandler);
            DoSomething();
            Console.Read();
        }
        public static void DoSomething()
        {
            Console.WriteLine("Something Happened! We need to send an event.");
            SendEvent();
        }
        public static void SendEvent()
        {
            if (Evt != null)
            {
                Evt();
            }
        }
    }
}
