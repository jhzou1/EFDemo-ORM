using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationPropDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------导航属性的使用1--------------------");

            EFDBEntities eFDBEntities = new EFDBEntities();

            //var stu = new Students()
            //{
            //    StudentAddress = "北京001号",
            //    StudentName = "王某某",
            //    StudentIdNo = 130223198910121232,
            //    Gender = "男",
            //    Birthday = Convert.ToDateTime("1990-10-12"),
            //    Age = 25,
            //    PhoneNumber = "010-88996655",
            //    ClassId=(from c in eFDBEntities.StudentClass where c.ClassName=="软件1班" select c.ClassId).SingleOrDefault()
            //};

            //Console.WriteLine($"要插入的学生信息是:{stu.StudentName} classId:{stu.ClassId}");

            //eFDBEntities.Students.Add(stu);
            //Console.WriteLine(eFDBEntities.SaveChanges());

            Console.WriteLine("------------------导航属性的使用2--------------------");
            var stu2 = new Students()
            {
                StudentAddress = "北京001号",
                StudentName = "王某某",
                StudentIdNo = 130223198910121233,
                Gender = "男",
                Birthday = Convert.ToDateTime("1990-10-12"),
                Age = 25,
                PhoneNumber = "010-88996655",
                //ClassId = (from c in eFDBEntities.StudentClass where c.ClassName == "软件1班" select c.ClassId).SingleOrDefault()
            };
            //班级里面加同学
            (from c in eFDBEntities.StudentClass where c.ClassName == "软件2班" select c).SingleOrDefault().Students.Add(stu2);

            Console.WriteLine(eFDBEntities.SaveChanges());

            Console.Read();
        }
    }
}
