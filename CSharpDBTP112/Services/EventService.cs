using CSharpDBTP112.Models;

namespace CSharpDBTP112.Services;

public class EventService
{
    public event Action<Event>? EventCreated;

    public void CreateEvent(Event newEvent)
    {
        EventCreated?.Invoke(newEvent);
    }

    public void RegisterEvent(Event newEvent)
    {
        Console.WriteLine("Novo evento criado!");
        Console.WriteLine($"Título: {newEvent.Titulo}");
        Console.WriteLine($"Data: {newEvent.Data}");
        Console.WriteLine($"Local: {newEvent.Local}");
    }
}