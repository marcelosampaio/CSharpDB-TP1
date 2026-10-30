namespace CSharpDBTP105.Services;

public class DownloadNotificationService
{
    public void OnDownloadCompleted(object? sender, EventArgs e)
    {
        Console.WriteLine("Notificação: Download concluído com sucesso!");
    }
}