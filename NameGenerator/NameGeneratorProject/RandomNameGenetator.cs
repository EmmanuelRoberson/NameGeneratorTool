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
        Random rand = new Random(DateTime.Now.Millisecond);

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

        public string GenerateName(int length)
        {
            if (length == 0)
            {
                nameLength = rand.Next(1, 8);

                //generates the base name
                Name = nameBuilder.GenerateBaseName(nameLength);

                ////adds the prefix
                //prefixes.PrependTo(ref _name);

                ////adds the suffix
                //suffixes.AppendTo(ref _name);

                return Name;
            }
            else
            {
                Name = nameBuilder.GenerateBaseName(length);
                return Name;
            }
        }
    }
}
