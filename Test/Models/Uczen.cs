using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Uczen
    {
        [Required]
        [RegularExpression(@"^\d{4}$", ErrorMessage ="Id wymaga 4 znaków")]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Required]
        public int Ocena { get; set; }

        public static readonly string[] TypyOcen = new string[] { "2", "3", "4", "5" };
       
       
    }
}
