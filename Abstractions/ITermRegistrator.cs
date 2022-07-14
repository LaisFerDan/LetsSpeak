namespace LetsSpeak.Abstractions
{
    public interface ITermRegistrator
    {
        void RegisterTerm(Dictionary<string, string> dict, string dbPath);
    }
}
