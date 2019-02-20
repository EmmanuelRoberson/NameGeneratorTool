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
        private static bool hasntQuit;
        static public void Print(string str)
        {
            Console.WriteLine(str);
        }

        [STAThread]
        static void Main(string[] args)
        {



            hasntQuit = true;

            RandomNameGenetator namer = new RandomNameGenetator();
            namer.nameBuilder = new BaseNameBuilder();
            namer.prefixes = new PrefixList();
            namer.suffixes = new SuffixList();

            string[] nameList = new string[10];

            Form1 nameGeneratorForm = new Form1();

            void GenerateTenNames()
            {
                for (int i = 0; i < 10; i++)
                {
                    nameList[i] = namer.GenerateName();
                }

                nameGeneratorForm.SetTextBox(nameList, 10);
            }

            Application.EnableVisualStyles();
            Application.Run(nameGeneratorForm);

            GenerateTenNames();
        }
    }
}
