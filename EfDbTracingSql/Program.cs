using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDbTracingSql
{
    class Program
    {
        static void Main(string[] args)
        {
            //SQL语句生成结果的观察
            EFDBEntities1 efdb = new EFDBEntities1();

            var stuList = from s in efdb.Students
                          where s.StudentId > 100005
                          select s;

            Console.WriteLine(stuList.Count());


            //观察SQL语句：第二种，查询条件，带着变量（变量将会变成参数）效率提高
            int stuId = 100002;
            var stuList2 = from stu in efdb.Students
                          where stu.StudentId > stuId
                          select stu;

            foreach (var item in stuList2)
            {
                Console.WriteLine(item.StudentId);
            }

            //Console.WriteLine("------------输出当前的对象状态  Entry获取当前模型的状态--------------");

            //StudentClass stuClass = new StudentClass() { ClassId = 12, ClassName = "软件12班" };

            //Console.WriteLine(efdb.Entry(stuClass).State.ToString());//输出当前的对象状态  Entry获取当前模型的状态

            //efdb.StudentClass.Add(stuClass);
            //Console.WriteLine(efdb.Entry(stuClass).State.ToString());

            //efdb.SaveChanges();
            //Console.WriteLine(efdb.Entry(stuClass).State.ToString());

            Console.WriteLine("------------状态跟踪查询的执行--------------");
            var stu1 = (from s in efdb.Students select s).FirstOrDefault();
            Console.WriteLine(efdb.Entry(stu1).State.ToString());

            //无状态的跟踪查询
            var stu2 = efdb.Students.AsNoTracking().Select(s => s).FirstOrDefault();
            Console.WriteLine(efdb.Entry(stu2).State.ToString());

            Console.ReadKey();
        }
    }
}
