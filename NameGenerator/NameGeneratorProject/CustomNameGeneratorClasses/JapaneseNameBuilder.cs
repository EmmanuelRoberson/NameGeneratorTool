using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace NameGeneratorProject.CustomNameGeneratorClasses
{
    class JapaneseNameBuilder
    {
        protected List<string> syllables;
        private Random rand;
        public JapaneseNameBuilder(string fileName)
        {
            syllables = new List<string>();

            rand = new Random(DateTime.Now.Millisecond);

            SetSyllables(fileName);
        }

        void SetSyllables(string fileName)
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            TextFieldParser cvsParser = new TextFieldParser(filepath);

            cvsParser.SetDelimiters(",");

            while (!cvsParser.EndOfData)
            {
                // reads the line, assigns the fields, then moves it to th next line
                string[] lineFields = cvsParser.ReadFields();

                syllables.Add(lineFields[1]);
            }
        }

        public string GenerateName
        {
            get
            {
                string name = "";
                for (int i = 0; i < rand.Next(1, 5); i++)
                {
                    name += syllables[rand.Next(0, syllables.Count)];
                }

                //capitalizes the first letter
                name = char.ToUpper(name[0]) + name.Substring(1);
                return name;
            }
        }

    }
}
