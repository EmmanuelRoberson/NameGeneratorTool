﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    public interface IPrefixable
    {
        void AddPrefix(ref string str);

        string[] Prefixes { get; set; }
    }
}
