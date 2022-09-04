using System.ComponentModel.DataAnnotations;

namespace Asp.net_Core_MVC_GestionMag.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public string NomArticle { get; set; }
        public string DescriptionArticle { get; set; }
        public int QtiteArticle { get; set; }

    }
}
