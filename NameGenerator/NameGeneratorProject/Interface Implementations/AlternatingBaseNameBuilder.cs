using System;
using System.Collections.Generic;
using IntroToCSharp;

namespace NameGeneratorProject.Interface_Implementations
{
    public class AlternatingBaseNameBuilder: IBaseNameBuildable
    {

        protected List<string> vowelList;
        protected List<string> consonantList;

        private Random rand;
        public string GenerateBaseName(int length)
        {
            string baseName = null;

            int consonant = rand.Next(0, consonantList.Count);

            int vowel = rand.Next(0, vowelList.Count);

            //j is initialized as well as i so we can name the name alternate between vowel and consonant
            for (int i = rand.Next(0, 2), j = i; i < length + j; i++)
            {
                if (baseName == null)
                {
                    baseName = (j % 2 == 0) ? consonantList[consonant].ToUpper() : vowelList[vowel].ToUpper();
                    continue;
                }
                consonant = rand.Next(0, consonantList.Count);
                vowel = rand.Next(0, vowelList.Count);

                baseName += (i % 2 == 0) ? consonantList[consonant] : vowelList[vowel];
            }

            return baseName;
        }
    }
}