using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("123");
           
            var app = new System.Windows.Application();


            var window = new WpfApp1.MainWindow();


            app.Run(window);
            Console.ReadKey();
        }
    }
}
