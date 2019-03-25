using System;
using System.Collections.Generic;
using IntroToCSharp;

namespace NameGeneratorProject.Interface_Implementations
{
    public class AlternatingBaseNameBuilder: IBaseNameBuildable
    {
        private List<string> vowelList;
        private List<string> consonantList;

        private Random rand;

        public AlternatingBaseNameBuilder()
        {
            vowelList = new List<string>();
            consonantList = new List<string>();
            Utilities.ReadCSV("LetterClassifications.csv", consonantList, vowelList);
            rand = new Random(DateTime.Now.Millisecond);
        }
       
        public string GenerateBaseName(int length)
        {
            if (length == 0)
            {
                length = rand.Next(1, 9);
            }

            Word baseName = new Word();

            var consonantIndex = rand.Next(0, consonantList.Count);
            var vowelIndex = rand.Next(0, vowelList.Count);

            //j is initialized as well as i so we can name the name alternate between vowel and consonant
            for (int i = rand.Next(0, 2), j = i; i < length + j; i++)
            {
                if (baseName.IsEmpty())
                {
                    var firstLetter = (j % 2 == 0) ? consonantList[consonantIndex].ToUpper() : vowelList[vowelIndex].ToUpper();
                    baseName.AddAtBeginning(firstLetter);
                    continue;
                }
                consonantIndex = rand.Next(0, consonantList.Count);
                vowelIndex = rand.Next(0, vowelList.Count);

                string letter = (i % 2 == 0) ? consonantList[consonantIndex] : vowelList[vowelIndex];

                baseName.AddAtEnd(letter);
            }

            return baseName.Value;
        }
    }
}