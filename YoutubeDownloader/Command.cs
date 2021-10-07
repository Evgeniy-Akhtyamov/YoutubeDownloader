using System.Threading.Tasks;

namespace YoutubeDownloader
{
    /// <summary>
    /// Базовый класс команды
    /// </summary>
    public abstract class Command
    {
        public abstract Task RunAsync(string arg);
    }
}
