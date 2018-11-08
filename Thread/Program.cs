using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadTest
{
    class Program
    {
    
        static void Main(string[] args)
        {
            #region 实例线程调用
            ////创建ThreadTest类的的一个实例
            //Threadtest test = new Threadtest();
            ////调用实例中的MyThread的方法
            //Thread thread1 = new Thread(test.MyThread) { IsBackground =true};
            ////
            //thread1.Start();
            //Console.ReadKey();
            #endregion

            #region 无参方法线程调用
            //Thread thread1 = new Thread(new ThreadStart(Thread1));
            //thread1.Start();
            //Console.ReadKey();
            #endregion

            #region 实例线程调用
            ////通过ParameterizedThreadstart创建线程
            //Thread thread = new Thread(new ParameterizedThreadStart(Thread2));

            ////给方法传值
            //thread.Start("这是一个有参数的委托");
            //Console.ReadKey();


            #endregion

            #region 线程的常用属性
            //获取正在运行的线程
            Thread thread3 =Thread.CurrentThread;
            //设置线程的名字
            thread3.Name = "主线程";
            //获取当前的线程的唯一标识符
            int id = thread3.ManagedThreadId;
            //获取当前线程的状态
            ThreadState state = thread3.ThreadState;
            //获取当前线程的优先级
            ThreadPriority priority = thread3.Priority;
             string strMsg = string.Format("Thread ID:{0}\n" + "Thread Name:{1}\n" +
                 "Thread State:{2}\n" + "Thread Priority:{3}\n", id, thread3.Name,
                 state, priority);

             Console.WriteLine(strMsg);
             Console.ReadKey();
            #endregion



        }
        /// <summary>
        /// 创建无参的方法
        /// </summary>
        static void Thread1()
        {
            Console.WriteLine("这是无参的方法");
        }
        /// <summary>
        /// 创建有参的方法
        /// 注意：方法里面的参数类型必须是Object类型
        /// </summary>
       /// <param name="obj"></param>
        static void Thread2(object obj)
         {
             Console.WriteLine(obj);
         }
    }

    class Threadtest
    {
        public void MyThread()
        {
            Console.WriteLine("这是个实例方法");
        }
    }
}
