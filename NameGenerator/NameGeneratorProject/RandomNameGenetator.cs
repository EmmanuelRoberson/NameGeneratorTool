using System;

namespace IntroToCSharp
{
    public class RandomNameGenetator
    {
        private string _name;

        public IPrependable prefixes;
        public IAppendable suffixes;
        public IBaseNameBuildable nameBuilder;

        public int nameLength;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string GenerateName()
        {
            Random rand = new Random();

            nameLength = rand.Next(1, 3);

            //generates the base name
            Name = nameBuilder.GenerateBaseName(nameLength);

            //adds the prefix
            prefixes.PrependTo(ref _name);

            //adds the suffix
            suffixes.AppendTo(ref _name);

            return Name;
        }
    }
}
