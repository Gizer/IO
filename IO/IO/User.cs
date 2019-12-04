using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace IO
{
    public partial class User : Form
    {
        private DataTable dt = new DataTable();         //Instancja klasy DataTable przechowująca otrzymane z zapytania dane
        private DataGridView dataGridViewUser;
        private OracleDataReader dr;                    //Reader

        public User()
        {
            InitializeComponent();              //Inicjalizacja komponentów
            if (DBConnector.Open())                   //Jeśli udało się nawiązać połączenie lub jest ono już aktywne
            {
                dr = DBConnector.Query("SELECT nazwa, numer_linii , czas FROM rozklad, przystanki, pojazdy WHERE rozklad.id_przystanku = przystanki.id_przystanku AND pojazdy.id_pojazdu = rozklad.id_pojazdu");   //Komenda SQL
                dt.Load(dr);                    //Wczytanie do DataTable wyniku zapytania
                dataGridViewUser.DataSource = dt;       //Ustawienie źródła DataGridView na DataTable
            }
            DBConnector.Close();                    //Rozłączenie
        }

        private void InitializeComponent()
        {
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            //
            // dataGridViewUser
            //
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.Size = new System.Drawing.Size(594, 237);
            this.dataGridViewUser.TabIndex = 0;
            //
            // User
            //
            this.ClientSize = new System.Drawing.Size(618, 261);
            this.Controls.Add(this.dataGridViewUser);
            this.Name = "User";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
        }
    }
}