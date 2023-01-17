using System.ComponentModel.DataAnnotations;

namespace Zadanie3tabele.Properties
{
    public class Klasa
    {
        [Key]
        public int IDKlasa { get; set; }
        public string NumerKlasy { get; set; }
    }
}