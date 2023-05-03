using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SwapiMVC2.Models;

namespace SwapiMVC2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private static Random rand = new Random();


    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string[] names = new[] {"Ben", "Eleanor", "Evelyn"};
        string name = names[rand.Next(0, names.Length)];
        return View(model: name);
        // model:name bc View() looks for name of view as a string. We want it to be a model so we are specifying which parameter were fulfilling
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
