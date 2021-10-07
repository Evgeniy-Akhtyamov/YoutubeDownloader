using System;
using YoutubeExplode;
using YoutubeExplode.Converter;
using System.Threading.Tasks;

namespace YoutubeDownloader
{
    /// <summary>
    /// Команда на скачивание
    /// </summary>
    class DownloadCommand : Command
    {
        // получатель
        YoutubeClient _client;

        public DownloadCommand(YoutubeClient client)
        {
            _client = client;
        }

        // Выполнить  
        public override async Task RunAsync(string url)
        {
            Console.WriteLine();
            Console.WriteLine("Загрузка видео");

            //  Путь к папке программы
            string Directory = Environment.CurrentDirectory;
            
            // Запуск загрузки
            await _client.Videos.DownloadAsync(url, $"{Directory}.mp4",
                builder => builder.SetPreset(ConversionPreset.UltraFast) // Конфигурация для макимально бысстрой загрузки
            );

            Console.WriteLine("Видео загружено");
            Console.WriteLine();
        }
    }
}
