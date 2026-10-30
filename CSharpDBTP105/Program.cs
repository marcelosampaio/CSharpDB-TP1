using CSharpDBTP105.Services;

namespace CSharpDBTP105;

internal class Program
{
    private static void Main(string[] args)
    {
        DownloadManager downloadManager = new();
        DownloadNotificationService notificationService = new();

        downloadManager.DownloadCompleted += notificationService.OnDownloadCompleted;

        downloadManager.StartDownload();

        downloadManager.DownloadCompleted -= notificationService.OnDownloadCompleted;
    }
}