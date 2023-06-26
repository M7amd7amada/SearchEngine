using Microsoft.AspNetCore.Mvc;

namespace SearchEngine.UI.Controllers;

[Controller]
public class ProductController : Controller
{
    [HttpGet]
    public ViewResult Index()
    {
        return View();
    }
}