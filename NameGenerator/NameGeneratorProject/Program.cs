using System;

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

        static void Main(string[] args)
        {

            hasntQuit = true;

            NameGenetator namer = new NameGenetator();
            namer.nameBuilder = new BaseNameBuilder();
            namer.prefixes = new PrefixList();
            namer.suffixes = new SuffixList();

            string[] nameList = new string[10];

            void GenerateTenNames()
            {
                for (int i = 0; i < 10; i++)
                {
                    nameList[i] = namer.GenerateName();
                }
            }

            while (hasntQuit)
            {

                GenerateTenNames();

            }



        }
    }
}
