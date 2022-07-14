using LetsSpeak.Abstractions;

namespace LetsSpeak.Logic
{
    public class SelectedOptionsValidator : ISelectedOptionsValidator
    {
        private readonly ITermSearcher _termSearcher;
        private readonly ITermRegistrator _termRegistrator;
        public SelectedOptionsValidator(ITermSearcher termSearcher, ITermRegistrator termRegistrator)
        {
            _termSearcher = termSearcher;
            _termRegistrator = termRegistrator;
        }

        public void ValidateSelectedOption(string dbPath, Dictionary<string, string> dict, string? selectedOption)
        {
            switch (selectedOption)
            {
                case "1":
                    _termSearcher.SearchTerm(dbPath, dict);
                    break;
                case "2":
                    _termRegistrator.RegisterTerm(dict, dbPath);
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
