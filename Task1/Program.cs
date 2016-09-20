using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Resources;
using System.Reflection;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int var_first=0;
            int var_second=0;
            ResourceManager rm = new ResourceManager("Resourse1", Assembly.GetExecutingAssembly());
            if (rm.GetString("config").Equals("file")){
                var_first = Int32.Parse(rm.GetString("val1"));
                var_second = Int32.Parse(rm.GetString("val2"));
            }
            if (rm.GetString("config").Equals("user")){
                var_first = Int32.Parse(Console.ReadLine());
                var_second = Int32.Parse(Console.ReadLine());
            }
            if (ConfigurationManager.AppSettings["config"].Equals("console"))
            {
                Console.WriteLine(var_first + var_second);
            }
            if (ConfigurationManager.AppSettings["config"].Equals("class"))
            {
                Library.Class1 sol = new Library.Class1();
                Console.WriteLine(sol.sum(var_first, var_second));
                Console.WriteLine(sol.subtract(var_first, var_second));
                Console.WriteLine(sol.multiplicat(var_first, var_second));
                Console.WriteLine(sol.div(var_first, var_second));
            }
            
        }
    }
}
