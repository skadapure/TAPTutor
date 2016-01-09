using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace TAPTutor
{
    public class Class1
    {
        public static void Main()
        {
            Console.WriteLine("Calling Main");
            SubMain();
            Console.WriteLine("Main Completed");
            Console.ReadLine();
        }
        public static void SubMain()
        {
            Stopwatch sp = new Stopwatch();
            sp.Start();
            Console.WriteLine("Calling Run");
            var i = Run();
            sp.Stop();
            Console.WriteLine("Run completed - " + sp.ElapsedMilliseconds.ToString());
            i.ForEach(x => Console.WriteLine(x.ToString()));
            
            //var tasknew = task.ContinueWith(x => x);
            Console.WriteLine("Game Over");
            

        }

        public static List<int> Run()
        {
            var t1 = Task<int>.Run(async () =>
            {
                Stopwatch sp = new Stopwatch();
                sp.Start();
                Console.WriteLine("Task1 : " + sp.ElapsedMilliseconds);
                await Task.Delay(5000);
                sp.Stop();
                Console.WriteLine("Task1 : " + sp.ElapsedMilliseconds);
                return 10;
            });

            var t2 = Task<int>.Run(async () =>
            {
                Stopwatch sp = new Stopwatch();
                sp.Start();
                Console.WriteLine("Task2 : " + sp.ElapsedMilliseconds);
                await Task.Delay(5000);
                sp.Stop();
                Console.WriteLine("Task2 : " + sp.ElapsedMilliseconds);
                return 11;
            });

            
            return new List<int> { t1.Result, t2.Result };


            
        }
    }


}
