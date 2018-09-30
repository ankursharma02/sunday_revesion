using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Revesion1
{
    class C
    {
        public static void demo()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("its going to sleep 4 sec : " + i);
                Thread.Sleep(4000);
            }
        }
    }
    class Thread_Sleep
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(C.demo);
            t1.Start();
            Console.ReadLine();
        }
    }
}
