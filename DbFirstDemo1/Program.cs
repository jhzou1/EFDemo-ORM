using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //[1]新建一个efdb的实例
            using (EFDBEntities efdb = new EFDBEntities())
            {
                var stuList = efdb.Students.Where(s=> s.Age>18);

                foreach (var stu in stuList)
                {
                    Console.WriteLine($"学生信息:{stu.StudentName} Phone:{stu.PhoneNumber}");
                }
            }

            Console.Read();
        }
    }
}
