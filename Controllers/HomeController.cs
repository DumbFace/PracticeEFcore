using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ConventionPractice.Models;
using ConventionPractice.Data;
using ConventionPractice.Core;

namespace ConventionPractice.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ApplicationDbContext _context;
    public HomeController(ILogger<HomeController> logger,
        ApplicationDbContext context
    )
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        Student student = new Student{
            Name = "Khang",
            DateBirth = DateTime.Now,
            Age = 18,
        };
        

        return View();
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
