using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace NameGeneratorProject
{
    public class JapaneseNameBuilder : BasePresetName
    {
        private List<string> syllables;

        public JapaneseNameBuilder(string fileName)
        {
            maleFirstNames = new List<string>(100);
            femaleFirstNames = new List<string>(100);
            lastNames = new List<string>(100);

            syllables = new List<string>(46);

            rand = new Random(DateTime.Now.Millisecond);

            initializeNames(fileName);
        }

        public void SetSyllables(string fileName)
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            TextFieldParser cvsParser = new TextFieldParser(filepath);

            cvsParser.SetDelimiters(",");

            while (!cvsParser.EndOfData)
            {
                // reads the line, assigns the fields, then moves it to th next line
                string[] lineFields = cvsParser.ReadFields();

                syllables.Add(lineFields[0]);
            }
        }

        public string GenerateName
        {
            get
            {
                string name = syllables[rand.Next(0, 46)];

                //this right here makes the first letter capitalized
                name = char.ToUpper(name[0]) + name.Substring(1);

                for (int i = 0; i <= rand.Next(0, 3); i++)
                {
                    name += syllables[rand.Next(0, 46)];
                }

                return name;
            }
        }
    }
}