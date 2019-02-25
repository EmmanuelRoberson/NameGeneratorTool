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
            int prefixIndex = rand.Next(0, 30);

            // this is so the name wont have a capital letter anywhere but the beginning
            if (prefixIndex < 18)
                str = str.ToLower();

            if (Prefixes[prefixIndex].EndsWith("a")
                || Prefixes[prefixIndex].EndsWith("e")
                || Prefixes[prefixIndex].EndsWith("i")
                || Prefixes[prefixIndex].EndsWith("o")
                || Prefixes[prefixIndex].EndsWith("u")
                || Prefixes[prefixIndex].EndsWith("y"))
            {
                BaseNameBuilder bridgeVowelToConants = new BaseNameBuilder();
                str = bridgeVowelToConants.RandConsonant + str;
            }

            str = Prefixes[prefixIndex] + str;
        }

        public string[] Prefixes { get; set; } =
        {
            "Wes", "Ka", "Yu", "Mc",
            "Ta", "Jam", "Con",
            "Ay", "Har", "Dar",
            "El", "Si", "Fran", "Mon",
            "Aram", "Oli", "Gat", "Lo",
            "","","","","","",
            "","","","","",""
        };
    }
}
