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

            if (PrependStrings[index].EndsWith("a")
                || PrependStrings[index].EndsWith("e")
                || PrependStrings[index].EndsWith("i")
                || PrependStrings[index].EndsWith("o")
                || PrependStrings[index].EndsWith("u")
                || PrependStrings[index].EndsWith("y"))
            {
                AlternatingNameBuilder bridgeVowelToConants = new AlternatingNameBuilder();
                str = bridgeVowelToConants.RandConsonant + str;
            }

            str = PrependStrings[index] + str;
        }

        public string[] PrependStrings { get; set; } =
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
