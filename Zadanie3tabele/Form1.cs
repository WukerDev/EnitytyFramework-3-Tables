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
            GridLoad();
            
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
            //dataGridViewTabele.Rows.Clear();
            //dataGridViewTabele.Columns.Clear();
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
            }
            comboBoxWychowca.Items.Clear();
            comboBoxKlasa.Items.Clear();
            string[] comboNames1 = { "122C", "012", "5", "576" };
            string[] comboNames2 = { "P. Kamiński", "A. Dymek", "J. Zalewski", "W. Kozakowski" };
            comboBoxWychowca.Items.AddRange(comboNames1);
            comboBoxKlasa.Items.AddRange(comboNames2);
            dataGridViewTabele.Columns[0].HeaderText = "Imię";
            dataGridViewTabele.Columns[1].HeaderText = "Nazwisko";
            dataGridViewTabele.Columns[2].HeaderText = "Klasa";
            dataGridViewTabele.Columns[3].HeaderText = "Nauczyciel";
            
        }

        private void buttonZapis_Click(object sender, EventArgs e)
        {
            string Imie = textBoxImie.Text;
            string Nazwisko = textBoxNazwisko.Text;

            using (var db = new Obsluga())
            {
                Uczeń uczen = new Uczeń
                {
                    UImie = Imie,
                    UNazwisko = Nazwisko,
                    FK_Klasa = selectedKlasa,
                    FK_Wychowawca = selectedWychowawca
                };
                db.Uczeń.Add(uczen);
                db.SaveChanges();
            }

            GridLoad();

        }

        private void comboBoxWychowca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxWychowca.SelectedIndex == 0) { selectedWychowawca = 1; };
            if (comboBoxWychowca.SelectedIndex == 1) { selectedWychowawca = 2; };
            if (comboBoxWychowca.SelectedIndex == 2) { selectedWychowawca = 3; };
            if (comboBoxWychowca.SelectedIndex == 3) { selectedWychowawca = 4; };
        }

        private void comboBoxKlasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKlasa.SelectedIndex == 0) { selectedKlasa = 1; };
            if (comboBoxKlasa.SelectedIndex == 1) { selectedKlasa = 2; };
            if (comboBoxKlasa.SelectedIndex == 2) { selectedKlasa = 3; };
            if (comboBoxKlasa.SelectedIndex == 3) { selectedKlasa = 4; };
        }
    }
    }
