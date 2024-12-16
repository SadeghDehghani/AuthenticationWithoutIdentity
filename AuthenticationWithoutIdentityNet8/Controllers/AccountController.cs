using Microsoft.AspNetCore.Mvc;

namespace AuthenticationWithoutIdentityNet8.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
