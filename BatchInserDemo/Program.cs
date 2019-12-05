using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchInserDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EFDBEntities eFDBEntities = new EFDBEntities();

            eFDBEntities.Configuration.AutoDetectChangesEnabled = false;//禁止跟踪

            //观察时间的损耗
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            for (int i = 11; i < 2011; i++)
            {
                StudentClass stuClass = new StudentClass() { ClassId = i, ClassName = $"软件{i}班" };
                eFDBEntities.StudentClass.Add(stuClass);
            }
            Console.WriteLine(eFDBEntities.SaveChanges());

            //展示一下时间
            sw.Stop();
            TimeSpan timeSpan = sw.Elapsed;
            Console.WriteLine($"第一次执行总耗时：{timeSpan.TotalMilliseconds}");

            eFDBEntities.Configuration.AutoDetectChangesEnabled = true;//开启跟踪
            sw.Start();
            for (int i = 2011; i < 4011; i++)
            {
                StudentClass stuClass = new StudentClass() { ClassId = i, ClassName = $"软件{i}班" };
                eFDBEntities.StudentClass.Add(stuClass);
            }
            Console.WriteLine(eFDBEntities.SaveChanges());

            //展示一下时间
            sw.Stop();
            timeSpan = sw.Elapsed;
            Console.WriteLine($"第二次执行总耗时：{timeSpan.TotalMilliseconds}");


            Console.ReadKey();
        }
    }
}
