namespace IntroToCSharp
{
    public interface IPrefixable
    {
        void AddPrefix(ref string str);

        string[] Prefixes { get; set; }
    }
}
