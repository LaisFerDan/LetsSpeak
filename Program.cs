using LetsSpeak.Logic;
using LetsSpeak.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace LetsSpeak
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection()
                .AddScoped<ILoader, Loader>()
                .AddScoped<IMenuExecuter, MenuExecuter>()
                .AddScoped<IMenuOptionsDisplayer, MenuOptionsDisplayer>()
                .AddScoped<ISaver, Saver>()
                .AddScoped<ISelectedOptionsValidator, SelectedOptionsValidator>()
                .AddScoped<ITermRegistrator, TermRegistrator>()
                .AddScoped<ITermSearcher, TermSearcher>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            using (var stream = File.OpenRead("dados.json"))
            {
                var dictionaryProcessor = serviceProvider.GetService<IMenuExecuter>();
                dictionaryProcessor.ExecuteMenu(stream);
            }
        }
    }
}
