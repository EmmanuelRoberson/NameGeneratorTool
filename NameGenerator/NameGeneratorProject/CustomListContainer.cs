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

        public void InitializeLists(string fileName)
        {
            //each element(i) in fileName will represent a different file

            var filepath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            TextFieldParser cvsParser = new TextFieldParser(filepath);

            cvsParser.SetDelimiters(",");

            while (!cvsParser.EndOfData)
            {

                int lineInTheFile = 0;

                {
                    //reads each line in the file
                    object[] lineFields = cvsParser.ReadFields();

                    //assignment of data
                    for (int fieldInTheLine = 0; fieldInTheLine < lineFields.Length; fieldInTheLine++)
                    {
                        list[fileIndex][lineInTheFile][fieldInTheLine] = lineFields[fieldInTheLine];
                    }
                }

                lineInTheFile++;
            }

        }

        public List<List<object>>[] BaseList => list;
    }
}
