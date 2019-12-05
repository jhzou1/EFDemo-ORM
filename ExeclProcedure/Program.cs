using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeclProcedure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (EFDBEntities mydb = new EFDBEntities())
            {
                //[1]调用存储过程查询学生信息
                Console.WriteLine("[1]调用存储过程查询学生信息");
                var StuList = mydb.usp_selectStu(1).ToList();

                foreach (var item in StuList)
                {
                    Console.WriteLine($"学生名字:{item.StudentName} 年龄:{item.Age}\n\n");
                }

                //[2]调用存储过程更新数据
                Console.WriteLine("[2]调用存储过程更新数据");

                mydb.Database.Log = Console.WriteLine;

                //int result = mydb.usp_updateStu("小明+1", 100014);这样也可以直接调用

                //Students objStu = (from s in mydb.Students where s.StudentId.Equals(100014) select s).FirstOrDefault();

                ////objStu.StudentName = "小明变小红12";
                //objStu.PhoneNumber = "123456";
                //objStu.Gender = "女";


                Students objStu = (from s in mydb.Students where s.StudentIdNo.Equals(130223198908192239) select s).FirstOrDefault();

                objStu.PhoneNumber = "123456";
                objStu.Gender = "女";

                Console.WriteLine(mydb.SaveChanges());
            }
          


            Console.Read();
        }
    }
}
