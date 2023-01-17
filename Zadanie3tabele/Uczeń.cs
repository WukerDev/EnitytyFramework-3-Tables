using System.ComponentModel.DataAnnotations;

namespace Zadanie3tabele.Properties
{
    public class Uczeń
    {
        [Key]
        public int IDUczeń { get; set; }
        public string UImie { get; set; }
        public string UNazwisko { get; set; }
        public int FK_Klasa { get; set; }
        public int FK_Wychowawca { get; set; }
    }
}