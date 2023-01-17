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

namespace Zadanie3tabele
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            GridLoad();
        }

        public void GridLoad()
        {
            dataGridViewTabele.Rows.Clear();
            dataGridViewTabele.Columns.Clear();
            using (var db = new Obsluga())
            {

                var query = from u in db.Uczeń
                            join k in db.Klasa on u.FK_Klasa equals k.IDKlasa
                            join n in db.Nauczyciel on u.FK_Wychowawca equals n.IDNauczyciel
                            select new
                            {
                                u.UImie,
                                u.UNazwisko,
                                k.NumerKlasy,
                                n.NauczycielNazwa
                            };
                
                dataGridViewTabele.DataSource = query.ToList();
                dataGridViewTabele.Columns[0].HeaderText = "Imię";
                dataGridViewTabele.Columns[1].HeaderText = "Nazwisko";
                dataGridViewTabele.Columns[2].HeaderText = "Klasa";
                dataGridViewTabele.Columns[3].HeaderText = "Nauczyciel";






            }
        }
    }
}