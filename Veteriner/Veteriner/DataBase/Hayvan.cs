using System.ComponentModel.DataAnnotations;

namespace Veteriner.DataBase
{
    public class Hayvan
    {
        [Key]
        public int id { get; set; }

        public int KisiId { get; set; }
        public int KategoriId { get; set; }

        public DateTime KayitTarihi { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string KimlikNo { get; set; }
        public string Cinsi { get; set; }

        public string Adi { get; set; }
        public string NotBilgisi { get; set; }
    }
}
