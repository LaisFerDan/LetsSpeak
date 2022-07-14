namespace LetsSpeak.Abstractions
{
    public interface IMenuOptionsDisplayer
    {
        string? DisplayMenuOptions(string dbPath, Dictionary<string, string> dict);
    }
}
