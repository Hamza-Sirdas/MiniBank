using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniBank.Infrastructure.Identity;

namespace MiniBank.Web.Controllers;

[Authorize(Roles =Roles.Admin)]
public class AdminController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}