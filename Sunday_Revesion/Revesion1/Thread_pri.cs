using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Revesion1
{
    class D
    {
        public static void Task1()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Task1 :" + i);

        }
        public static void Task2()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Task2 :" + i);
        }
        public void Task3()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Task3 :" + i);
        }
        public void Task4()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Task4 :" + i);

        }

    }


    class Thread_pri
    {
        static void Main(string[] args)
        {
            A a = new A();
            Thread t1 = new Thread(A.Task1);
            Thread t2 = new Thread(A.Task2);
            Thread t3 = new Thread(a.Task3);

            Thread t4 = new Thread(a.Task4);
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;
            t3.Priority = ThreadPriority.Normal;
            t4.Priority = ThreadPriority.BelowNormal;
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            Console.ReadLine();

        }
    }
}
