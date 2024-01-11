using Microsoft.AspNetCore.Mvc;

namespace LeitorNfe.Controllers;

public class ErrorController: Controller
{
    [ActionName("404")]
    public IActionResult _404()
    {
        return View();
    }
}