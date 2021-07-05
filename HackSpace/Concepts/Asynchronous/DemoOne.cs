using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Concepts.Asynchronous
{
    public class DemoOne
    {
        public void DemoOneMain()
        {
            TaskOne();
        }

        public void TaskOne()
        {
            Task<string> myTask = Task.Run(() =>
            {
                //Thread.Sleep(5000);
                return "my One";
            });
            
            myTask.ContinueWith((t1) =>
            {
                try
                {
                    Console.WriteLine(t1.Result);
                }
                catch (Exception ex)
                {

                }
                
            });
            
        }

        //public async string GetStateAsync()
        //{
        //    return "ns,f";
        //}

        //public  Task<string> GetStateAsync2()
        //{
        //    return "ns,f";
        //}
    }
}
