using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace NameGeneratorProject.Honorifics
{
    public class HonorificList
    {
        private List<string> honorificList;
        private string honorificType;

        public HonorificList(string fileName, string typeOfHonorific)
        {
            honorificList = new List<string>();
            honorificType = typeOfHonorific;
            InitializeHonorificList(fileName);
        }

        public void InitializeHonorificList(string fileName)
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            TextFieldParser cvsParser = new TextFieldParser(filepath);

            cvsParser.SetDelimiters(",");

            while (!cvsParser.EndOfData)
            {
                // reads the line, assigns the fields, then moves it to th next line
                string[] lineFields = cvsParser.ReadFields();

                //cvs file must be formatted like:: [index 0],name,[index 2],name2
                honorificList.Add(lineFields[1]);
            }
        }

        public string GetHonorificType => honorificType;
        public List<string> GetHonorificList => honorificList;
    }
}
