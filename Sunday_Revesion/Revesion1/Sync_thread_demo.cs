using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Revesion1
{
    class E
    {
            public  void Demo1()
            {
            lock (this)
            {

                for (int i = 0; i < 5; i++)
                    Console.WriteLine(Thread.CurrentThread.Name + " :" + i);
            }
        }
    }
    class Sync_thread_demo
    {
        public static void Main(string[] args)
        {
            E e = new E();
            Thread t1 = new Thread(e.Demo1);
            Thread t2 = new Thread(e.Demo1);
            t1.Name = "thread1 ";
            t2.Name = "thread2 ";
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    }
}
