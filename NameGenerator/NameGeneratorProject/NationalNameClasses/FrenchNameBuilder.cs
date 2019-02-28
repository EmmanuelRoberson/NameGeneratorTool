using System;
using System.Collections.Generic;

namespace NameGeneratorProject
{
    public class FrenchNameBuilder : BasePresetName
    {
        public FrenchNameBuilder(string fileName)
        {
            maleFirstNames = new List<string>(100);
            femaleFirstNames = new List<string>(100);
            lastNames = new List<string>(100);

            rand = new Random(DateTime.Now.Millisecond);

            InitializeNames(fileName);
        }
    }
}