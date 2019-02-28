using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace NameGeneratorProject
{
    public abstract class BasePresetName
    {

        public string NameType { get; set; }

        protected List<string> maleFirstNames;
        protected List<string> femaleFirstNames;
        protected List<string> lastNames;

        protected Random rand = new Random(DateTime.Now.Millisecond);

        protected void InitializeNames(string fileName)
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            TextFieldParser cvsParser = new TextFieldParser(filepath);

            cvsParser.SetDelimiters(",");

            while (!cvsParser.EndOfData)
            {
                // reads the line, assigns the fields, then moves it to th next line
                string[] lineFields = cvsParser.ReadFields();

                maleFirstNames.Add(lineFields[1]);
                femaleFirstNames.Add(lineFields[3]);
            }
        }

        //returns a random male name
        public string MaleName => maleFirstNames[rand.Next(0, 100)];

        // returns a random female name
        public string FemaleName => femaleFirstNames[rand.Next(0, 100)];

    }
}