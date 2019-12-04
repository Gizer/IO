using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace IO
{
    public partial class Worker : Form
    {
        private DataTable dt = new DataTable();
        private OracleDataReader dr;

        public Worker()
        {
            InitializeComponent();
            if (DBConnector.Open())
            {
                dataGridViewWorker.Rows.Clear();
                dataGridViewWorker.Refresh();
                dr = DBConnector.Query("SELECT * FROM pracownicy WHERE id_pracownika = 'AAAAE'");  //Domyślny widok
                dt.Load(dr);
                dataGridViewWorker.DataSource = dt;
            }
            DBConnector.Close();
        }

        private void btn_info_Click(object sender, EventArgs e)                         //Przycisk "O mnie"
        {
            if (DBConnector.Open())
            {
                dataGridViewWorker.DataSource = null;
                dataGridViewWorker.Rows.Clear();
                dataGridViewWorker.Refresh();
                dr = null;
                DataTable dt = new DataTable();
                dr = DBConnector.Query("SELECT * FROM pracownicy WHERE id_pracownika = 'AAAAE'");  //Zwraca

                //informacje o zalogowanym pracowniku
                dt.Load(dr);
                dataGridViewWorker.DataSource = dt;
            }
            DBConnector.Close();
        }

        private void btn_sch_Click(object sender, EventArgs e)                          //Przycisk "Grafik"
        {
            if (DBConnector.Open())
            {
                dataGridViewWorker.DataSource = null;
                dataGridViewWorker.Rows.Clear();
                dataGridViewWorker.Refresh();
                dr = null;
                DataTable dt = new DataTable();
                dr = DBConnector.Query("SELECT * FROM grafiki_zajzdnie WHERE id_pracownika = 'AAAAE'"); //Zwraca informacje o grafiku danego pracownika
                dt.Load(dr);
                dataGridViewWorker.DataSource = dt;
            }
            DBConnector.Close();
        }
    }
}