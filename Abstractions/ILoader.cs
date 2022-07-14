namespace LetsSpeak.Abstractions
{
    public interface ILoader
    {
        Dictionary<string, string>? Load(string dbPath);
    }
}
