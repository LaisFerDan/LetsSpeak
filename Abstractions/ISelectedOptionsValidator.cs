namespace LetsSpeak.Abstractions
{
    public interface ISelectedOptionsValidator
    {
        void ValidateSelectedOption(string dbPath, Dictionary<string, string> dict, string? selectedOption);
    }
}
