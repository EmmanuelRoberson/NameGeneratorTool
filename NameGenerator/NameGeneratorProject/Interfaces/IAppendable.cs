using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    public interface IAppendable
    {
        void AppendTo(ref string str);

        string[] Append{ get; set; }
    }

}
