using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks.Basic
{
    public class Client
    {
        public static void Main(string[] args)
        {
            #region Basic
            ////Using task factory
            //TaskFactory tf = new TaskFactory();
            //Task t1 = tf.StartNew(TaskMethod);

            ////using task factory via a task
            //Task t2 = Task.Factory.StartNew(TaskMethod);

            ////using Task constructor
            //Task t3 = new Task(TaskMethod);
            //t3.Start();

            #endregion

            #region Sequential
            //Task t1 = new Task(DoOnFirst);
            //Task t2 = t1.ContinueWith(DoOnSecond);
            //Task t3 = t1.ContinueWith(DoOnSecond);
            //t1.Start();
            #endregion

            #region Hierachy
            ParentAndChild();
            #endregion

            Console.Read();
        }

        public static void TaskMethod()
        {
            Console.WriteLine("running in a task");
            Console.WriteLine("Task id: {0}", Task.CurrentId);
        }

        public static void DoOnFirst()
        {
            Console.WriteLine("doing some task {0}", Task.CurrentId);
            Thread.Sleep(1000);
        }

        public static void DoOnSecond(Task t)
        {
            Console.WriteLine("Task {0} finished", t.Id);
            Console.WriteLine("this task id {0}", Task.CurrentId);
            Console.WriteLine("do some cleanup");
            Thread.Sleep(3000);
        }

        public static void ParentAndChild()
        {
            var parent = new Task(ParentTask);
            parent.Start();
            Thread.Sleep(2000);
            Console.WriteLine(parent.Status);
            Thread.Sleep(4000);
            Console.WriteLine(parent.Status);
        }

        public static void ParentTask()
        {
            Console.WriteLine("task id {0}", Task.CurrentId);
            var child = new Task(ChildTask);
            child.Start();
            Thread.Sleep(1000);
            Console.WriteLine("parent started child");
        }

        public static void ChildTask()
        {
            Console.WriteLine("child");
            Thread.Sleep(5000);
            Console.WriteLine("child finished");
        }
    }
}
