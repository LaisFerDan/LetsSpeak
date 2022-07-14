using LetsSpeak.Abstractions;

namespace LetsSpeak.Logic
{
    public class TermRegistrator : ITermRegistrator
    {
        private readonly ISaver _saver;
        public TermRegistrator(ISaver saver)
        {
            _saver = saver;
        }
        public void RegisterTerm(Dictionary<string, string> dict, string dbPath)
        {
            Console.Clear();
            Console.Write("Digite o termo que deseja cadastrar: ");
            var term = Console.ReadLine();
            if (term.Contains("*") || term.Contains("?"))
            {
                Console.WriteLine("Wildcards (* e ?) não são aceitas. Tente novamente.");
                Console.ReadKey();
                RegisterTerm(dict, dbPath);
            }
            Console.Write("Digite o significado do termo: ");
            var meaning = Console.ReadLine();
            dict.Add(term, meaning);
            Console.Write("Deseja salvar? ");
            var answer = Console.ReadLine();
            if (answer.Equals("sim", StringComparison.InvariantCultureIgnoreCase))
            {
                _saver.Save(dict, dbPath);
                Console.WriteLine("Novo termo salvo com sucesso.");
                Console.ReadKey();
            }
        }
    }
}
