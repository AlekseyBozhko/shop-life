
namespace ShopLife.Api.ShopLife.Registratin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
            public class RegistrationController : Controller
            {
                public IActionResult Index()
                {
                    return View();
                }
        
                public IActionResult Welcome()
                {
                    ViewData["Message"] = "Your welcome message";
        
                    return View();
                }
            }
        }
    
}