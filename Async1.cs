using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Delegates
{
    class Async1
    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main thread starts");
            Console.Read();
        }
        public static async void Method()
        {
            await LongTask();
            //Thread.Sleep(5000);
            Console.WriteLine("new Thread");
        }
        public static async Task<string> LongTask()
        {
            Console.WriteLine("Long task Thread started");
            Thread.Sleep(5000);
            Console.WriteLine("Long task Thread ended");
            return "bhuna";
        }
    }
}
