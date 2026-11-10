using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MiniBank.Web.Controllers;

[Authorize]
public class DashboardController : Controller
{
    public IActionResult Index() { return View(); }
}