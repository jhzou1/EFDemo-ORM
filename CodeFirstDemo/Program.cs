using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CodeFirstEntity db = new CodeFirstEntity())
            {
                db.Teaches.Add(new Teacher()
                {
                    Id = 1002,
                    Name = "jhzou2"
                });
                int result = db.SaveChanges();
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
