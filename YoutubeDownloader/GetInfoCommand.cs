using System;
using YoutubeExplode;
using System.Threading.Tasks;

namespace YoutubeDownloader
{
    /// <summary>
    /// Команда на получение иинформации
    /// </summary>
    public class GetInfoCommand : Command
    {
        // получатель
        // получатель
        YoutubeClient _client;
        public GetInfoCommand(YoutubeClient client)
        {
            _client = client;
        }

        public override async Task RunAsync(string url)
        {
            Console.WriteLine();
            Console.WriteLine("Загружаем данные");

            // Получаем и выводим данные о видео
            var info = await _client.Videos.GetAsync(url);
            Console.WriteLine(info.Title);
            Console.WriteLine(info.Description);

            Console.WriteLine();
        }
    }
}
