using Asp.net_Core_MVC_GestionMag.Data;
using Asp.net_Core_MVC_GestionMag.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp.net_Core_MVC_GestionMag.Controllers
{
    public class ArticleController : Controller
    {
        private readonly DbContextMag _db;
        public ArticleController(DbContextMag db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Article> obtArt = _db.Articles;
            return View(obtArt);
        }
    }
}
