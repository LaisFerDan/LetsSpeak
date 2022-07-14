namespace LetsSpeak.Abstractions
{
    public interface ISaver
    {
        void Save(Dictionary<string, string> dict, string dbPath);
    }
}
