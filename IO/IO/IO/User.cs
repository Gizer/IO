using System.Data;
using System.IO;
using System.Windows.Forms;
using DB;

namespace IO
{
    public partial class User : Form
    {
        private DataTable dt = new DataTable();         //Instancja klasy DataTable przechowująca otrzymane z zapytania dane
        private DataGridView dataGridViewUser;

        public User()
        {
            InitializeComponent();              //Inicjalizacja komponentów
            this.Text = "User";
            dataGridViewUser.DataSource = null;
            dataGridViewUser.Rows.Clear();
            dataGridViewUser.Refresh();
            var output = UserMethods.DisplayTimetable().Tables[0];
            dataGridViewUser.DataSource = output;
            dataGridViewUser.Refresh();
            //StreamWriter sw = new StreamWriter("AutoITTest\\UserTest.xml", false);
            //output.WriteXml(sw);
            //sw.Close();
            //sw.Dispose();
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