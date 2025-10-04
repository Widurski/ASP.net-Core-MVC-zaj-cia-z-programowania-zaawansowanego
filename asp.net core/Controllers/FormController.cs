using Microsoft.AspNetCore.Mvc;

namespace MyVscMvcApp.Controllers;

public class FormController : Controller
{
        // GET: /Form/
        [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    // POST: /Form/Submit
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Submit(string field1, string field2, string field3)
    {
        ViewData["Submitted"] = true;
        ViewData["Field1"] = field1 ?? string.Empty;
        ViewData["Field2"] = field2 ?? string.Empty;
        ViewData["Field3"] = field3 ?? string.Empty;
        return View("Index");
    }
}
