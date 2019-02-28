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
        private List<List<object>>[] list;

        CustomListContainer(string[] fileNames, object type)
        {
            list = new List<List<object>>[fileNames.Length];
        }

        public void InitializeLists(string[] fileNames)
        {
            //each element(i) in fileNames will represent a different file
            for (int fileIndex = 0; fileIndex < fileNames.Length; fileIndex++)
            {
                var filepath = Path.Combine(Directory.GetCurrentDirectory(), fileNames[fileIndex]);
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
        }

        public List<List<object>>[] BaseList => list;
    }
}
