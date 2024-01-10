using System.ComponentModel.DataAnnotations;

namespace Veteriner.DataBase
{
    public class Kategori
    {
        [Key]
        public int id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
    }
}
