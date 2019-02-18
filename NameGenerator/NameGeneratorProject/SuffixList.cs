using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class SuffixList : ISuffixable
    {
        Random rand = new Random();
        void ISuffixable.AddSuffix(ref string str)
        {
            int suffixIndex = rand.Next(0, 18);

            str += Suffixes[suffixIndex];
        }

        public string[] Suffixes { get; set; } =
        {
            " ", " ", "STER","SON",
            "ARD", "IAMS", "S",
            "ES","ING", "SMITH",
            "AN","E", "INS",
            "ELL", "ER","EAUX",
            "BERG", "Y"
        };
    }
}
