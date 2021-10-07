using System.Threading.Tasks;

namespace YoutubeDownloader
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    class Sender
    {
        Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        // Выполнение команды
        public async Task RunAsync(string sourceUrl)
        {
            await _command.RunAsync(sourceUrl);
        }
    }
}
