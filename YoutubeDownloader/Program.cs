using System;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode.Converter;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace YoutubeDownloader
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Ссылка на видео в YouTube
            var videoUrl = "https://www.youtube.com/watch?v=MfG8ZdBT4f8";

            // создадим отправителя
            var sender = new Sender();

            // создадим получателя
            var receiver = new YoutubeClient();

            // создадим команду на загрузку видео
            var downloadCommand = new DownloadCommand(receiver);
            sender.SetCommand(downloadCommand);
            await sender.RunAsync(videoUrl);
            
            // создадим команду на получение информации о видео
            var getInfoCommand = new GetInfoCommand(receiver);
            sender.SetCommand(getInfoCommand);
            await sender.RunAsync(videoUrl);
        }        
    }
}
