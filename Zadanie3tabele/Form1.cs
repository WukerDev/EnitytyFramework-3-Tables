using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadanie3tabele.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zadanie3tabele
{
    public partial class Form1 : Form
    {
        int selectedKlasa;
        int selectedWychowawca;
        public Form1()
        {
            InitializeComponent();
            GridLoad(); //odpalamy metodę ładującą gridView
            
        }
        public void comboBoxUpdateFromBase()
        {
            using (var db = new Obsluga())
            {
                {
                    

                }
            }
        }
            
        public void GridLoad()  
        {
            //dataGridViewTabele.Rows.Clear(); <- tego użylibyśmy z nugetem sqlite, jednak mamy entityframework więc robimy metodą poniżej
            //dataGridViewTabele.Columns.Clear();
            using (var db = new Obsluga()) 
            {

                var query = from u in db.Uczeń //ustalamy zmienną var query która pobiera dane do zmiennej u z tabeli Uczeń 
                            join k in db.Klasa on u.FK_Klasa equals k.IDKlasa //dołączamy do tego tabelę Klasa za pomocą klucza obcego FK_klasa, przypisujemy wartość klyucza obcego na taką samą jak IDKlasa
                            join n in db.Nauczyciel on u.FK_Wychowawca equals n.IDNauczyciel //ponownie łączymy, tym razem tabelę nauczyciel z tabelą uczeń, i przypisujemy do klucza obcego FK_wychowawca wartość IDNauczyciel
                            select new
                            {
                                u.UImie,  //w zależności od tabeli zmieniamy literki zaś po kropce musi być taka sama nazwa jak w bazie danych, tutaj tabela uczeń, pozycja UImie
                                u.UNazwisko,  //tabela uczeń pozycja UNazwisko
                                k.NumerKlasy,  //tabela klasa pozycja NumerKlasy
                                n.NauczycielNazwa  // tabela Nauczyciel pozycja NauczycielNazwa
                            }; 





                dataGridViewTabele.DataSource = query.ToList();  //wywołujemy metodę pokazującą tabelę z argumentem DataSource który umożliwia nam określenie skąd są dane, w tym wypadku zmienna query przetowrzona metodą ToList() (do listy)
            }
            comboBoxWychowca.Items.Clear();  //czyścimy combo boxa by uniknąć dziwnych zachowań
            comboBoxKlasa.Items.Clear();  //jak wyżej ale inny combo box
            string[] comboNames1 = { "122C", "012", "5", "576" };  // ustalamy tabelę comboNames1 a ich dane jako numery klas
            string[] comboNames2 = { "P. Kamiński", "A. Dymek", "J. Zalewski", "W. Kozakowski" };  //jak wyżej ale teraz dopisujemy nazwiska nauczycieli
            comboBoxWychowca.Items.AddRange(comboNames1); //dodajemy "zasięg", wielkość comboboxa na podstawie ilości przedmiotów w tabeli ComboNames1
            comboBoxKlasa.Items.AddRange(comboNames2);  // jak wyżej ale używamy ComboNames2
            dataGridViewTabele.Columns[0].HeaderText = "Imię";  //na sztywno ustalamy nagłówki kolumn, liczymy od 0 bo to programowanie
            dataGridViewTabele.Columns[1].HeaderText = "Nazwisko";  //jw
            dataGridViewTabele.Columns[2].HeaderText = "Klasa";  //jw
            dataGridViewTabele.Columns[3].HeaderText = "Nauczyciel";  //jw
            
        }

        private void buttonZapis_Click(object sender, EventArgs e) //fuinkcja do zapisywania zmian w bazie danych
        {
            string Imie = textBoxImie.Text;  //ustalamy że wartość zmiennej Imie  będzie równa wartośći textboxa Imie 
            string Nazwisko = textBoxNazwisko.Text; //jak wyżej

            using (var db = new Obsluga())  
            {
                Uczeń uczen = new Uczeń  //nowy
                {
                    UImie = Imie,  //przypisujemy wartości z baz danyh (po lewej) do zmiennych ustalonych w programie które zczytujemy z textboxa (po prawej)
                    UNazwisko = Nazwisko,
                    FK_Klasa = selectedKlasa,  //selectedKlasa odnosi się do kodu niżej który obsługuje wybory w ComboBoxach
                    FK_Wychowawca = selectedWychowawca  //jak wyżej
                };
                db.Uczeń.Add(uczen); //do tabeli Uczeń dodajemy wartości z obiektu uczen argumentem .Add 
                db.SaveChanges(); //używamy funkcji do zapisania zmian
            }

            GridLoad();  //ładujemy/odświeżamy gridvbiew 

        }

        private void comboBoxWychowca_SelectedIndexChanged(object sender, EventArgs e)  //tutaj ustalamy dokładnie co czemu odpowiada
        {
            if (comboBoxWychowca.SelectedIndex == 0) { selectedWychowawca = 1; };  //po lewej mamy jaki input może dać użytkownik, od 0 do 3, po prawej zaś konwerujemy to na output jaki idzie do bazy danych.
            if (comboBoxWychowca.SelectedIndex == 1) { selectedWychowawca = 2; };  // Zmieniamy wartość o 1 w górę ponieważ bazy danych liczą od 1 a programy od 0
            if (comboBoxWychowca.SelectedIndex == 2) { selectedWychowawca = 3; };
            if (comboBoxWychowca.SelectedIndex == 3) { selectedWychowawca = 4; };
        }

        private void comboBoxKlasa_SelectedIndexChanged(object sender, EventArgs e) // tutaj sytuacja jak wyżej ale do comboboxa Klasa
        {
            if (comboBoxKlasa.SelectedIndex == 0) { selectedKlasa = 1; };  //oczywiscie ilość dostosowujemy do ilości potrzebnych 
            if (comboBoxKlasa.SelectedIndex == 1) { selectedKlasa = 2; };  //jeśli potrzebowalibyśmy więcej lub mniej dodajemy lub usuwamy linijki wg. uznania
            if (comboBoxKlasa.SelectedIndex == 2) { selectedKlasa = 3; };
            if (comboBoxKlasa.SelectedIndex == 3) { selectedKlasa = 4; };
        }
    }
    }
