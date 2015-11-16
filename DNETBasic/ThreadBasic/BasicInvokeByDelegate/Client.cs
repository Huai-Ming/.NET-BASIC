using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadBasic.BasicInvoke
{
    public delegate int TakesAWhileDelegate(int data, int ms);
    public class Client
    {
        public static void Main1(string[] args)
        {
            TakesAWhileDelegate de = TakesAWhile;
            
            ////We will invoke the delgate asynchronous
            //IAsyncResult ar = de.BeginInvoke(1, 30000, null, null);
            //while(!ar.IsCompleted)
            //{
            //    Console.Write(".");
            //    Thread.Sleep(50);
            //}

            //int result = de.EndInvoke(ar);
            //Console.WriteLine("Result: {0}", result);
            de.BeginInvoke(1, 3000, TakesAWhileCompleted, de);
            for (int i = 0; i < 100; i++ )
            {
                Console.WriteLine(".");
                Thread.Sleep(50);

            }
                Console.ReadKey();

        }

        public static int TakesAWhile(int data, int ms)
        {
            Console.WriteLine("TakesAWhile started");
            Thread.Sleep(ms);
            Console.WriteLine("TakesAWhile completed");
            return ++data;
        }

        public static void TakesAWhileCompleted(IAsyncResult ar)
        {
            if(ar == null)
            {
                throw new ArgumentNullException("AR");
            }

            TakesAWhileDelegate dl = ar.AsyncState as TakesAWhileDelegate;
            Trace.Assert(dl != null, "Invalid object type");

            int result = dl.EndInvoke(ar);
            Console.WriteLine("Result:{0}", result);
        }
    }
}
