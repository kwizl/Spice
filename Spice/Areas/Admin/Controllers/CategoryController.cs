using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;

namespace Spice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET Action Method
        public async Task<IActionResult> Index()
        {
            var category = await _db.Category.ToListAsync();
            return View(category);
        }

        ///  GET - CREATE
        public IActionResult Create()
        {
            return View();
        }
    }
}
