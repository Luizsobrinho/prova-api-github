using ApiGit.Extensions;
using ApiGit.Models;
using ApiGit.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGit.Controllers
{
    public class RepositorioController : Controller
    {
        private readonly Context _context;

        public RepositorioController(Context context)
        {
            this._context = context;
        }
        public async Task<IActionResult> Index(string url)
        {

            GitHubApi api = new GitHubApi();
            var result = api.GetRepositorios(url);
            HttpContext.Session.Set("repositorios", result);
            return View("Index", result);
        }

        public async Task<IActionResult> Favoritar(string url)
        {
            GitHubApi api = new GitHubApi();
            var result = api.GetRepositorio(url);

            _context.Add(result);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Favorito");
        }
    }
}
