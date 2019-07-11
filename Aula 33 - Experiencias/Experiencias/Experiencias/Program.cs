using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiencias
{
    class Program
    {
        private static Random _random = new Random();
        private static string Alfabeto = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890";
        private static string capcha = "";

        [STAThread]
        static void Main(string[] args)
        {
            
            for(int i = 0; i < 5; i++)
            {
                capcha += Alfabeto.Substring(_random.Next(1, Alfabeto.Length), 1);
            }

            foreach(var item in capcha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(capcha);
            Console.ReadLine();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Capcha());
        }
    }
}
