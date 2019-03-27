using System;
using System.Collections.Generic;

namespace NameGeneratorProject
{
    public class HispanicNameBuilder : BasePresetName
    {
        public HispanicNameBuilder(string fileName)
        {
            maleFirstNames = new List<string>(100);
            femaleFirstNames = new List<string>(100);
            lastNames = new List<string>(100);

            rand = new Random();

            initializeNames(fileName);
        }

        //returns a random male name
        public string MaleName => maleFirstNames[rand.Next(0, 100)];

        // returns a random female name
        public string FemaleName => femaleFirstNames[rand.Next(0, 100)];
    }
}