using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OracleGUI;
using DB;

namespace IO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Program.users.Add(new Tuple<string, string, string, string>("Heindrick", "Hackford", "1", "worker"));
            Program.users.Add(new Tuple<string, string, string, string>("Felix", "Drew-Clifton", "2", "worker"));
            Program.users.Add(new Tuple<string, string, string, string>("Andriette", "Challenger", "3", "worker"));
            Program.users.Add(new Tuple<string, string, string, string>("Katya", "Pierpoint", "4", "manager"));
            Program.users.Add(new Tuple<string, string, string, string>("Adelle", "Dominighi", "5", "manager"));
        }

        private void buttonPassenger_Click(object sender, EventArgs e)
        {
            DBConnector.SetLogin("pas");
            DBConnector.SetPass("pasazer1");
            User user = new User();
            this.Hide();
            user.ShowDialog();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //DBConnector.SetLogin(textBoxLogin.Text);
            //DBConnector.SetPass(textBoxPass.Text);
            foreach (var item in Program.users)
            {
                if (item.Item1 == textBoxLogin.Text && item.Item2 == textBoxPass.Text)
                {
                    if (item.Item4 == "worker")
                    {
                        DBConnector.SetLogin("prac");
                        DBConnector.SetPass("pracownik1");
                        DBConnector.CurrentUser = item.Item1;
                        DBConnector.CurrentPass = item.Item2;
                        Worker worker = new Worker();
                        this.Hide();
                        worker.ShowDialog();
                    }
                    else
                    {
                        DBConnector.SetLogin("kiero");
                        DBConnector.SetPass("kierownik1");
                        DBConnector.CurrentUser = item.Item1;
                        DBConnector.CurrentPass = item.Item2;
                        Manager manager = new Manager();
                        this.Hide();
                        manager.ShowDialog();
                    }
                    //if (!DBConnector.Open())
                    //{
                    //    MessageBox.Show("Niepoprawne dane");
                    //}
                    break;
                }
            }
            this.Close();
            //else
            //{
            //jakaś query żeby ustalić czy to pracownik czy kierownik
            //var result = DBConnector.Query(String.Format("SELECT * FROM {0}_ROLE_PRIVS", textBoxLogin.Text));
            //odpowiednio sprawdzić result
            //if (true)
            //{
            //}
            //else
            //{
            //}
            //}
        }

        private void textBoxTextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxLogin.Text) && !String.IsNullOrEmpty(textBoxPass.Text))
                buttonLogin.Enabled = true;
            else
                buttonLogin.Enabled = false;
        }
    }
}