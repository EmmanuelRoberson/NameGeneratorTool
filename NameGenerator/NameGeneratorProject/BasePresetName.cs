using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace NameGeneratorProject
{
    public class BasePresetName
    {
        protected List<string> maleFirstNames;
        protected List<string> femaleFirstNames;
        protected List<string> lastNames;
        protected List<string> honorifics;

        protected Random rand;

        public BasePresetName(string fileName)
        {
            maleFirstNames = new List<string>();
            femaleFirstNames = new List<string>();
            lastNames = new List<string>();

            rand = new Random(DateTime.Now.Millisecond);

            InitializeFirstNames(fileName);
        }

        protected void InitializeFirstNames(string fileName)
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            TextFieldParser cvsParser = new TextFieldParser(filepath);

            cvsParser.SetDelimiters(",");

            while (!cvsParser.EndOfData)
            {
                // reads the line, assigns the fields, then moves it to th next line
                string[] lineFields = cvsParser.ReadFields();

                //cvs file must be formatted like:: [index 0],name,[index 2],name2
                maleFirstNames.Add(lineFields[1]);
                femaleFirstNames.Add(lineFields[3]);
            }
        }

        protected void InitializeLastNames(string fileName)
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            TextFieldParser cvsParser = new TextFieldParser(filepath);

            cvsParser.SetDelimiters(",");

            while (!cvsParser.EndOfData)
            {
                // reads the line, assigns the fields, then moves it to th next line
                string[] lineFields = cvsParser.ReadFields();

                //cvs file must be formatted like:: [index 0],name,[index 2],name2
                lastNames.Add(lineFields[1]);
            }
        }

        protected void InitializeHonorifics(string fileName)
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            TextFieldParser cvsParser = new TextFieldParser(filepath);

            cvsParser.SetDelimiters(",");

            while (!cvsParser.EndOfData)
            {
                // reads the line, assigns the fields, then moves it to th next line
                string[] lineFields = cvsParser.ReadFields();

                //cvs file must be formatted like:: [index 0],name,[index 2],name2
                honorifics.Add(lineFields[1]);
            }
        }

        //returns a random male name
        public string MaleName => maleFirstNames[rand.Next(0, maleFirstNames.Count)];

        // returns a random female name
        public string FemaleName => femaleFirstNames[rand.Next(0, femaleFirstNames.Count)];

        //keeps track of the type of each name
        public string NameType { get; set; }
    }
}