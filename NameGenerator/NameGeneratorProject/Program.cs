using System;
using System.Windows.Forms;
using NameGeneratorProject;

namespace IntroToCSharp
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {

            nameGeneratorForm nameGeneratorForm = new nameGeneratorForm();

            Application.EnableVisualStyles();
            Application.Run(nameGeneratorForm);
        }
    }
}
