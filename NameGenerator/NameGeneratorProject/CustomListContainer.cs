using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;


namespace NameGeneratorProject
{    
    class CustomListContainer : IConvertToListable
    {
        private List<List<string>> list;

        CustomListContainer()
        {
            list = new List<List<string>>();
        }

        public void InitializeList(string fileName)
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            TextFieldParser cvsParser = new TextFieldParser(filepath);

            cvsParser.SetDelimiters(",");

            while (!cvsParser.EndOfData)
            {
                int lineInTheFile = 0;

                {
                    //reads each line in the file
                    string[] arrayOfFieldsInLine = cvsParser.ReadFields();

                    //assignment of data
                    for (int fieldInTheLine = 0; fieldInTheLine < arrayOfFieldsInLine.Length; fieldInTheLine++)
                    {
                        list[lineInTheFile][fieldInTheLine] = arrayOfFieldsInLine[fieldInTheLine];
                    }
                }

                lineInTheFile++;
            }

        }
        public List<List<string>> BaseList => list;
    }
}
