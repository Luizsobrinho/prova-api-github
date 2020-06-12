using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ApiGit.Models;
using ApiGit.Service;
using ApiGit.Extensions;

namespace ApiGit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Buscar(string buscar)
        {
            GitHubApi api = new GitHubApi();
            var result = api.GetUsuarios(buscar);
            HttpContext.Session.Set("usuarios", result);
            return View("Index", result);
        }

        public IActionResult Owner()
        {
            GitHubApi api = new GitHubApi();
            var result = api.GetOwner();
            HttpContext.Session.Set("repositorio", result);
            return View("Owner", result);
        }
    }
}
