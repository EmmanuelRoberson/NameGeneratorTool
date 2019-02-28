using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class PrependList : IPrependable
    {
        Random rand = new Random();
        void IPrependable.PrependTo(ref string str)
        {
            int index = rand.Next(0, 30);

            // this is so the name wont have a capital letter anywhere but the beginning
            if (index < 18)
                str = str.ToLower();

            if (Prepend[index].EndsWith("a")
                || Prepend[index].EndsWith("e")
                || Prepend[index].EndsWith("i")
                || Prepend[index].EndsWith("o")
                || Prepend[index].EndsWith("u")
                || Prepend[index].EndsWith("y"))
            {
                BaseNameBuilder bridgeVowelToConants = new BaseNameBuilder();
                str = bridgeVowelToConants.RandConsonant + str;
            }

            str = Prepend[index] + str;
        }

        public string[] Prepend { get; set; } =
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
