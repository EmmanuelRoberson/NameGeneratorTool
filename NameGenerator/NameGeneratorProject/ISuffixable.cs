using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    public interface ISuffixable
    {
        void AddSuffix(ref string str);

        string[] Suffixes{ get; set; }
    }

}
