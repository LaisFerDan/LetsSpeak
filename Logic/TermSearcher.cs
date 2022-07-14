using LetsSpeak.Abstractions;

namespace LetsSpeak.Logic
{
    public class TermSearcher : ITermSearcher
    {
        private readonly ILoader _loader;
        public TermSearcher(ILoader loader)
        {
            _loader = loader;
        }

        public void SearchTerm(string dbPath, Dictionary<string, string> dict)
        {
            Console.Clear();

            int cont = 0;

            Console.Write("Digite o termo que deseja buscar: ");
            var term = Console.ReadLine().ToLower();
            if (term.Contains("*") || term.Contains("?"))
            {
                Console.WriteLine("Wildcards (* e ?) não são aceitas. Tente novamente.");
                Console.ReadKey();
                SearchTerm(dbPath, dict);
            }

            foreach (var savedTerm in dict)
            {
                if (savedTerm.Key.Contains(term, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"{savedTerm.Key} - {savedTerm.Value}");
                    cont++;
                }
            }
            
            Console.ReadKey();

            if (cont == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Nenhum termo encontrado.");
                Console.Write("Deseja buscar outro termo? ");
                var answer = Console.ReadLine();
                if (answer.Equals("sim", StringComparison.InvariantCultureIgnoreCase))
                {
                    SearchTerm(dbPath, dict);
                }
            }
        }
    }
}
