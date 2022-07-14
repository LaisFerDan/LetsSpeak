using LetsSpeak.Abstractions;
using Newtonsoft.Json;

namespace LetsSpeak.Logic
{
    internal class Loader : ILoader
    {
        public Dictionary<string, string>? Load(string dbPath)
        {
            Dictionary<string, string>? dict;
            if (!File.Exists(dbPath))
                File.Create(dbPath);

            var content = File.ReadAllText(dbPath);
            dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
            return dict;
        }
    }
}
