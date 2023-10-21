using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dojosurveymvc.Models;

namespace dojosurveymvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet]

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("submit")]
      public IActionResult Create(Survey Surv)
    {
         Survey su = new Survey();
         
           // The if statement triggers if our model passed its validation checks
    if(ModelState.IsValid)    
    {        
        // Do somethng! Maybe insert into a database or log data to the console  
        // Then we will redirect to a new page        
        return View("Result", Surv);    
    }   
    else    
    {        
        // Oh no! We need to return a ViewResponse to preserve the ModelState and the errors it now contains! 
        // Make sure you return the View that contains the form!       
        return View("Index");    
    }
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
