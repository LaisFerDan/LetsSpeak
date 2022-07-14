using LetsSpeak.Abstractions;
using Newtonsoft.Json;

namespace LetsSpeak.Logic
{
    public class MenuExecuter : IMenuExecuter
    {
        private readonly IMenuOptionsDisplayer _menuOptionsDisplayer;
        private readonly ILoader _loader;

        public MenuExecuter(IMenuOptionsDisplayer menuOptionsDisplayer, ILoader loader)
        {
            _menuOptionsDisplayer = menuOptionsDisplayer;
            _loader = loader;
        }

        public void ExecuteMenu(Stream stream)
        {
            var selectedOption = "";
            do
            {
                Console.Clear();
                var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados.json");
                var dict = _loader.Load(dbPath);
                selectedOption = _menuOptionsDisplayer.DisplayMenuOptions(dbPath, dict);
            } while (selectedOption != "1" || selectedOption != "2");
        }
        public void ExecuteMenu()
        {
            var selectedOption = "";
            do
            {
                Console.Clear();
                var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados.json");
                var dict = _loader.Load(dbPath);
                selectedOption = _menuOptionsDisplayer.DisplayMenuOptions(dbPath, dict);
            } while (selectedOption != "1" || selectedOption != "2");
        }
    }
    
}

