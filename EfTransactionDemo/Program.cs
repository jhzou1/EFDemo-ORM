using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfTransactionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestTransaction1();
            TestTransaction2();

            Console.Read();
        }

        static void TestTransaction1()
        {
            using (EfDb db = new EfDb())
            {
                //这里是一个action委托，我们绑定这个Console.WriteLine 现实中我们也可以用一个日志方法绑定
                db.Database.Log = Console.WriteLine;

                db.StudentClass.Add(new StudentClass { ClassId = 30, ClassName = ".NET高级学习班1" });
                db.StudentClass.Add(new StudentClass { ClassId = 31, ClassName = ".NET高级学习班2" });

                db.SaveChanges();
            }
        }


        //【2】在查询中是没有事务的
        private static void TestTransaction2()
        {
            using (EfDb db = new EfDb())
            {
                //我们可以通过log接口来随时查看日志信息，它在DataBase里面
                db.Database.Log = Console.WriteLine;

                db.StudentClass.FirstOrDefault();

                db.SaveChanges();
                Console.Read();
            }
        }
    }
}
