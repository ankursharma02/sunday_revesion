using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Revesion1
{
    public class MyThread
    {
        public void Thread1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }
    public class Thread_join
    {
        public static void Main()
        {
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}