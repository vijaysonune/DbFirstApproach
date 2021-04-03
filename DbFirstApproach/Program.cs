using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoDbContext();

            var result = context.GetCourses();

            foreach (var item in result)
            {
                Console.WriteLine(item.Title);

            }
            Console.ReadLine();
        }
    }
}
