using IO;
using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OracleGUI
{
    public partial class Manager : Form
    {
        private DataTable dt = new DataTable();
        private OracleDataReader dr;
        private bool displayed = false;
        private bool worker = false;	//Zmienne determinujące co zostało wciśnięte
        private bool crash = false;
        private bool tams = false;
        private bool rozklad = false;
        private bool przystanki = false;
        private bool zajezdnie = false;
        private bool grafik = false;

        public Manager()
        {
            InitializeComponent();
            this.Name = "Manager Panel";
            //if (DBConnector.Open())
            //{
            //    dr = DBConnector.Query("SELECT * FROM pracownicy"); 	//Domyślny widok
            //    dt.Load(dr);
            //    dataGridViewManager.DataSource = dt;
            //    worker = true;
            //}
            //DBConnector.Close();
            displayed = true;
        }

        private void btn_change_Click(object sender, EventArgs e)	//Przycisk "Zamień"
        {
            if (dataGridViewManager.SelectedCells == null || crash)	//Nie można edytować kiedy nie ma wybranej komórki oraz kiedy wybierzemy tabelę wypadki
                return;
            else
            {
                var currentRadioButton = this.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
                string dpn = dataGridViewManager.Columns[dataGridViewManager.CurrentCell.ColumnIndex].DataPropertyName;	//Zmienne służące do przechowania informacji dotyczących zmiany konkretnego rekordu
                string change = tb_change.Text;
                string id = dataGridViewManager.Rows[dataGridViewManager.CurrentCell.RowIndex].Cells[0].Value.ToString();
                if (worker)	//Sprawdzanie która tabela jest aktualnie wybrana
                {
                    if (DBConnector.Open())
                    {
                        dataGridViewManager.DataSource = null;	//Resetowanie DGV
                        dataGridViewManager.Rows.Clear();	//Resetowanie DGV
                        dataGridViewManager.Refresh();		//Resetowanie DGV
                        dr = null;
                        DataTable dt = new DataTable();
                        dr = DBConnector.Query("UPDATE pracownicy SET " + dpn + " = '" + change + "' WHERE id_pracownika = '" + id + "'"); //Modyfikacja rekordu
                        dr = DBConnector.Query("SELECT * FROM pracownicy"); 	//Odświeżenie widoku, analogicznie pozostałe if'y
                        dt.Load(dr);
                        dataGridViewManager.DataSource = dt;
                    }
                    DBConnector.Close();
                }
                else if (tams)
                {
                    if (DBConnector.Open())
                    {
                        dataGridViewManager.DataSource = null;
                        dataGridViewManager.Rows.Clear();
                        dataGridViewManager.Refresh();
                        dr = null;
                        DataTable dt = new DataTable();
                        dr = DBConnector.Query("UPDATE pojazdy SET " + dpn + " = '" + change + "' WHERE id_pojazdu = '" + id + "'");
                        dr = DBConnector.Query("SELECT * FROM pojazdy");
                        dt.Load(dr);
                        dataGridViewManager.DataSource = dt;
                    }
                    DBConnector.Close();
                }
                else if (rozklad)
                {
                    if (DBConnector.Open())
                    {
                        dataGridViewManager.DataSource = null;
                        dataGridViewManager.Rows.Clear();
                        dataGridViewManager.Refresh();
                        dr = null;
                        DataTable dt = new DataTable();
                        dr = DBConnector.Query("UPDATE rozklad SET " + dpn + " = '" + change + "' WHERE id_wpisu = '" + id + "'");
                        dr = DBConnector.Query("SELECT * FROM rozklad");
                        dt.Load(dr);
                        dataGridViewManager.DataSource = dt;
                    }
                    DBConnector.Close();
                }
                else if (przystanki)
                {
                    if (DBConnector.Open())
                    {
                        dataGridViewManager.DataSource = null;
                        dataGridViewManager.Rows.Clear();
                        dataGridViewManager.Refresh();
                        dr = null;
                        DataTable dt = new DataTable();
                        dr = DBConnector.Query("UPDATE przystanki SET " + dpn + " = '" + change + "' WHERE id_przystanku = '" + id + "'");
                        dr = DBConnector.Query("SELECT * FROM przystanki");
                        dt.Load(dr);
                        dataGridViewManager.DataSource = dt;
                    }
                    DBConnector.Close();
                }
                else if (zajezdnie)
                {
                    if (DBConnector.Open())
                    {
                        dataGridViewManager.DataSource = null;
                        dataGridViewManager.Rows.Clear();
                        dataGridViewManager.Refresh();
                        dr = null;
                        DataTable dt = new DataTable();
                        dr = DBConnector.Query("UPDATE zajezdnie SET " + dpn + " = '" + change + "' WHERE id_zajezdni = '" + id + "'");
                        dr = DBConnector.Query("SELECT * FROM zajezdnie");
                        dt.Load(dr);
                        dataGridViewManager.DataSource = dt;
                    }
                    DBConnector.Close();
                }
                else if (grafik)
                {
                    if (DBConnector.Open())
                    {
                        dataGridViewManager.DataSource = null;
                        dataGridViewManager.Rows.Clear();
                        dataGridViewManager.Refresh();
                        dr = null;
                        DataTable dt = new DataTable();
                        dr = DBConnector.Query("UPDATE grafik SET " + dpn + " = '" + change + "' WHERE id_grafik = '" + id + "'");
                        dr = DBConnector.Query("SELECT * FROM grafik");
                        dt.Load(dr);
                        dataGridViewManager.DataSource = dt;
                    }
                    DBConnector.Close();
                }
            }
        }

        private void btn_own_Click(object sender, EventArgs e)	//Przycisk "Wykonaj"
        {
            if (DBConnector.Open())
            {
                dr = null;
                try
                {
                    dr = DBConnector.Query(tb_own.Text);	//Próba wykonania własnej komendy
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            DBConnector.Close();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!displayed)
                return;
            if (((RadioButton)sender).Checked)
            {
                string name = ((RadioButton)sender).Text;
                if (name.Equals("Pracownicy"))
                {
                    dataGridViewManager.DataSource = null;
                    dataGridViewManager.Rows.Clear();
                    dataGridViewManager.Refresh();
                    dataGridViewManager.DataSource = ManagerMethods.WyswietlPracownikow();
                }
                else if (name.Equals("Wypadki"))
                {
                    dataGridViewManager.DataSource = null;
                    dataGridViewManager.Rows.Clear();
                    dataGridViewManager.Refresh();
                    dataGridViewManager.DataSource = ManagerMethods.WyswietlWypadki();
                }
                else if (name.Equals("Pojazdy"))
                {
                    dataGridViewManager.DataSource = null;
                    dataGridViewManager.Rows.Clear();
                    dataGridViewManager.Refresh();
                    dataGridViewManager.DataSource = ManagerMethods.WyswietlPojazdy();
                }
                else if (name.Equals("Rozkład"))
                {
                    dataGridViewManager.DataSource = null;
                    dataGridViewManager.Rows.Clear();
                    dataGridViewManager.Refresh();
                    dataGridViewManager.DataSource = ManagerMethods.WyswietlRozklad();
                }
                else if (name.Equals("Zajezdnie"))
                {
                    dataGridViewManager.DataSource = null;
                    dataGridViewManager.Rows.Clear();
                    dataGridViewManager.Refresh();
                    dataGridViewManager.DataSource = ManagerMethods.WyswietlZajezdnie();
                }
                else if (name.Equals("Przystaniki"))
                {
                    dataGridViewManager.DataSource = null;
                    dataGridViewManager.Rows.Clear();
                    dataGridViewManager.Refresh();
                    dataGridViewManager.DataSource = ManagerMethods.WyswietlPrzystanki();
                }
                else if (name.Equals("Grafik"))
                {
                    dataGridViewManager.DataSource = null;
                    dataGridViewManager.Rows.Clear();
                    dataGridViewManager.Refresh();
                    dataGridViewManager.DataSource = ManagerMethods.WyswietlGrafik();
                }
            }
        }
    }
}