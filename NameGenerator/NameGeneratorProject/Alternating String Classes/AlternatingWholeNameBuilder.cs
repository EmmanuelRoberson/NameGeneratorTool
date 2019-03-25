using IntroToCSharp;
using NameGeneratorProject.Interface_Implementations;

namespace NameGeneratorProject
{
    class AlternatingWholeNameBuilder : AbstractNameBuilder
    {
        public AlternatingWholeNameBuilder()
        {
            baseNameBuilder = new AlternatingBaseNameBuilder();
            prepender = new PrependList();
            appender = new AppendList();
        }
        public override string GenerateWholeName(int baseNameLength)
        {
            return baseNameBuilder.GenerateBaseName(baseNameLength);
        }
    }
}
