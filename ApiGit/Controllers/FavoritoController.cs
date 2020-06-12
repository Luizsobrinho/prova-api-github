using ApiGit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGit.Controllers
{
    public class FavoritoController : Controller
    {
        private readonly Context _context;

        public FavoritoController(Context context)
        {
            this._context = context;

        }
        public async Task<IActionResult> Index()
        {
            var list = await _context.Favoritos.ToListAsync();
            return View(list);
        }
    }
}
