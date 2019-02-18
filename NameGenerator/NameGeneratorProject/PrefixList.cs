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

            str = Prefixes[prefixIndex] + str;
        }

        public string[] Prefixes { get; set; } =
        {
            "", "", "", "Mc",
            "MAC", "CYN", "CON",
            "AY", "WIN", "DAR",
            "EL", "SI", "", "",
            "", "", "", "LO"
        };
    }
}
