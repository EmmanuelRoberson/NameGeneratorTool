using System;

namespace IntroToCSharp
{
    class SuffixList : ISuffixable
    {
        Random rand = new Random();
        void ISuffixable.AddSuffix(ref string str)
        {
            int suffixIndex = rand.Next(0, 30);

            str += Suffixes[suffixIndex];
        }

        public string[] Suffixes { get; set; } =
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
