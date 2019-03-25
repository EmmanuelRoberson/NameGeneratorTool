namespace IntroToCSharp
{
    public interface ISuffixable
    {
        void AddSuffix(ref string str);

        string[] Suffixes{ get; set; }
    }

}
