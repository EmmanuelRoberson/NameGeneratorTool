using System.Collections.Generic;
using IntroToCSharp;

namespace NameGeneratorProject
{
    public abstract class AbstractNameBuilder
    {
        protected IBaseNameBuildable baseNameBuilder;
        protected IPrependable prepender;
        protected IAppendable appender;

        public abstract string GenerateWholeName(int baseNameLength);
    }
}