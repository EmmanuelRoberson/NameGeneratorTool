using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    public interface IPrependable
    {
        void PrependTo(ref string str);

        string[] PrependStrings { get; set; }
    }
}
