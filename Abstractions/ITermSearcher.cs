namespace LetsSpeak.Abstractions
{
    public interface ITermSearcher
    {
        void SearchTerm(string dbPath, Dictionary<string, string> dict);
    }
}
