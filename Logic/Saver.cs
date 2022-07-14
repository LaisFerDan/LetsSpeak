using LetsSpeak.Abstractions;
using Newtonsoft.Json;

namespace LetsSpeak.Logic
{
    internal class Saver : ISaver
    {
        public void Save(Dictionary<string, string> dict, string dbPath)
        {
            var content = JsonConvert.SerializeObject(dict, Formatting.Indented);
            File.WriteAllText(dbPath, content);
        }
    }
}
