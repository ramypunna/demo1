using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using RivicSystems_WcfServiceDemo;

namespace WcfStudentHostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(StudentService)))
            {
                host.Open();
                Console.WriteLine("Student service started");
                Console.ReadLine();
            }

        }
    }
}
