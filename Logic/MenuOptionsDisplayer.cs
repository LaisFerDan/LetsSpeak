using LetsSpeak.Abstractions;

namespace LetsSpeak.Logic
{
    public class MenuOptionsDisplayer : IMenuOptionsDisplayer
    {
        private readonly ISelectedOptionsValidator _selectedOptionsValidator;
        public MenuOptionsDisplayer(ISelectedOptionsValidator selectedOptionsValidator)
        {
            _selectedOptionsValidator = selectedOptionsValidator;
        }

        public string? DisplayMenuOptions(string dbPath, Dictionary<string, string> dict)
        {
            string? selectedOption;
            Console.WriteLine(" « Let's Speak »");
            Console.WriteLine();
            Console.WriteLine("Selecione um número: ");
            Console.WriteLine("(1) Buscar termo em inglês");
            Console.WriteLine("(2) Cadastrar novo termo");
            Console.WriteLine("(3) Sair");
            selectedOption = Console.ReadLine();
            _selectedOptionsValidator.ValidateSelectedOption(dbPath, dict, selectedOption);
            return selectedOption;
        }
    }
}
