using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadBasic.BasicInvokeByThread
{
    public struct Data
    {
        public string Message;
    }
    public class Client
    {
        public static void Main(string[] args)
        {
            //var t = new Thread(ThreadMain);
            //var t = new Thread(() => Console.WriteLine("Another thread"));
            var data = new Data() { Message = "Hello" };
            var t = new Thread(ThreadMain) { Name="Test", IsBackground = true};
            t.Start(data);

            Console.WriteLine("This is the main thread");
            //Console.ReadKey();
        }

        public static void ThreadMain(object o)
        {
            Data d = (Data)o;
            Console.WriteLine("Received Message:{0}", d.Message);
            Thread.Sleep(3000);
            Console.WriteLine("Running in a thread");
        }
    }
}
