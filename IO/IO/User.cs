using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace IO
{
    public partial class User : Form
    {
        private DataTable dt = new DataTable();         //Instancja klasy DataTable przechowująca otrzymane z zapytania dane
        private DataGridView dataGridViewUser;

        public User()
        {
            InitializeComponent();              //Inicjalizacja komponentów
            dataGridViewUser.DataSource = null;
            dataGridViewUser.Rows.Clear();
            dataGridViewUser.Refresh();
            dataGridViewUser.DataSource = UserMethods.DisplayTimetable().Tables[0];
            dataGridViewUser.Refresh();
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
            this.dataGridViewUser.Size = new System.Drawing.Size(672, 299);
            this.dataGridViewUser.TabIndex = 0;
            //
            // User
            //
            this.ClientSize = new System.Drawing.Size(696, 323);
            this.Controls.Add(this.dataGridViewUser);
            this.Name = "User";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
        }
    }
}