using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Basics.Models;

namespace Basics.Controllers;

public class HomeController : Controller
{
    public string Index()
    {
        return "Home/Index";
    }

    public string Contact()
    {
        return "Home/Contact";
    }

 
}
