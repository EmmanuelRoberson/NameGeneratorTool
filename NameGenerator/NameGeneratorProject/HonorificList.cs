using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGeneratorProject
{
    public class HonorificList
    {
        public int index;
        protected List<string> list;

        public string Honorifics => list[index];
    }
}
