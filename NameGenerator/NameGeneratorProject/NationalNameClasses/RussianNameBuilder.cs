using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGeneratorProject.NationalNameClasses
{
    class RussianNameBuilder : BasePresetName
    {
        public RussianNameBuilder(string fileName)
        {
            maleFirstNames = new List<string>(100);
            femaleFirstNames = new List<string>(100);
            lastNames = new List<string>(100);

            rand = new Random(0);

            initializeNames(fileName);
        }
    }
}
