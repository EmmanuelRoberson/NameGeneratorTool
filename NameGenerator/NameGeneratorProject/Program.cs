using System;
using System.Windows.Forms;
using NameGeneratorProject;

namespace IntroToCSharp
{
    class Logger
    {
        Logger()
        {
            DoTheThing();
        }
        public void Log(string str)
        {
            Program.Print(str);
        }

        void DoTheThing()
        {
            Log("my logga");

            string exitPhrase = Console.ReadLine();
            while (exitPhrase != "You can't say that")
            {
                exitPhrase = Console.ReadLine();
            }
        }
    }

    class Program
    {
        static public void Print(string str)
        {
            Console.WriteLine(str);
        }

        [STAThread]
        static void Main(string[] args)
        {

            nameGeneratorForm nameGeneratorForm = new nameGeneratorForm();

            Application.EnableVisualStyles();
            Application.Run(nameGeneratorForm);
        }
    }
}
