﻿using LetsSpeak.Abstractions;

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

            var content = _loader.Load(dbPath);
            var validTerm = false;

            Console.Write("Digite o termo que deseja buscar: ");
            var term = Console.ReadLine().ToLower();
            if (term.Contains("*") || term.Contains("?"))
            {
                Console.WriteLine("Wildcards (* e ?) não são aceitas. Tente novamente.");
                SearchTerm(dbPath, dict);
            }
            foreach (var item in dict)
            {
                if (item.Key.Contains(term, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"{item.Key} : {item.Value}");
                }
                validTerm = true;
            }
            Console.ReadKey();

            if (!content.ContainsKey(term) && validTerm == false)
            {
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