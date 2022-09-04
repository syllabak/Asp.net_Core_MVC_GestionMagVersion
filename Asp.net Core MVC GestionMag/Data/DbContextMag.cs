using Asp.net_Core_MVC_GestionMag.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.net_Core_MVC_GestionMag.Data
{
    public class DbContextMag:DbContext
    {
        public DbContextMag(DbContextOptions<DbContextMag> options) : base(options)
        {

        }
        public DbSet<Article> Articles { get; set; }
    }
}
