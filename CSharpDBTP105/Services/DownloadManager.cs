namespace CSharpDBTP105.Services;

public class DownloadManager
{
    public event EventHandler? DownloadCompleted;

    public void StartDownload()
    {
        Console.WriteLine("Download iniciado...");

        Thread.Sleep(3000);

        Console.WriteLine("Download finalizado.");

        DownloadCompleted?.Invoke(this, EventArgs.Empty);
    }
}