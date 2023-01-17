using System.ComponentModel.DataAnnotations;

namespace Zadanie3tabele.Properties
{
    public class Nauczyciel
    {
        [Key]
        public int IDNauczyciel { get; set; }
        public string NauczycielNazwa { get; set; }
    }
}