using Microsoft.AspNetCore.Mvc;

namespace MyVscMvcApp.Controllers;

public class ImageController : Controller
{
    // GET: /Image/View?name=...
    [HttpGet]
    public new IActionResult View(string name)
    {
        ViewData["NameParam"] = name ?? string.Empty;
        // known images to display on the page
        ViewData["KnownImages"] = new string[] { "cat.jpg", "mountain.jpg", "logo.png" };
        return base.View();
    }
}
