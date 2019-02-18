using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class PrefixList : IPrefixable
    {
        Random rand = new Random();
        void IPrefixable.AddPrefix(ref string str)
        {
            int prefixIndex = rand.Next(0, 18);

            if (Prefixes[prefixIndex].EndsWith("A")
                || Prefixes[prefixIndex].EndsWith("E")
                || Prefixes[prefixIndex].EndsWith("I")
                || Prefixes[prefixIndex].EndsWith("O")
                || Prefixes[prefixIndex].EndsWith("U")
                || Prefixes[prefixIndex].EndsWith("Y"))
            {
                BaseNameBuilder thisIsToGeTConsonants = new BaseNameBuilder();
                str = thisIsToGeTConsonants.RandConsonant + str;
            }

            str = Prefixes[prefixIndex] + str;
        }

        public string[] Prefixes { get; set; } =
        {
            "", "", "", "Mc",
            "MAC", "JAM", "CON",
            "AY", "HAR", "DAR",
            "EL", "SI", "FRAN", "MON",
            "", "", "", "LO"
        };
    }
}
