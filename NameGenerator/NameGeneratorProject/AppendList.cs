using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class AppendList : IAppendable
    {
        Random rand = new Random();
        void IAppendable.AppendTo(ref string str)
        {
            int suffixIndex = rand.Next(0, 30);

            str += AppendStrings[suffixIndex];
        }

        public string[] AppendStrings { get; set; } =
        {
            "o", "dule", "ster","son",
            "ard", "iams", "s",
            "es","ing", "smith",
            "an","e", "ins",
            "ell", "er","eaux",
            "berg", "y", "ers",
            "retta","beth","sson","","","","",
            "","","",""
        };
    }
}
