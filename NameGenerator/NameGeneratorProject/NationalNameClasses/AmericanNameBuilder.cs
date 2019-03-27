using System;
using System.Collections.Generic;

namespace NameGeneratorProject
{
    public class AmericanNameBuilder : BasePresetName
    {
        public AmericanNameBuilder(string fileName)
        {
            maleFirstNames = new List<string>(100);
            femaleFirstNames = new List<string>(100);
            lastNames = new List<string>(100);

            rand = new Random(0);

            initializeNames(fileName);
        }
    }
}
