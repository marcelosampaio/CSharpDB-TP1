using CSharpDBTP112.Models;
using CSharpDBTP112.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpDBTP112.Pages;

public class CreateEventModel : PageModel
{
    private readonly EventService _eventService;

    [BindProperty]
    public Event Event { get; set; } = new();

    public CreateEventModel()
    {
        _eventService = new EventService();

        _eventService.EventCreated += _eventService.RegisterEvent;
    }

    public void OnPost()
    {
        _eventService.CreateEvent(Event);
    }
}