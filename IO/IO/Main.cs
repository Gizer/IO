using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace IO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonPassenger_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DBConnector.SetLogin(textBoxLogin.Text);
            DBConnector.SetPass(textBoxPass.Text);
            if(!DBConnector.Open())
            {
                MessageBox.Show("Niepoprawne dane");
            }
            else
            {
                //jakaś query żeby ustalić czy to pracownik czy kierownik
                var result = DBConnector.Query(String.Format("SELECT * FROM {0}_ROLE_PRIVS", textBoxLogin.Text));
                //odpowiednio sprawdzić result
                if(true)
                {

                }
                else
                {

                }
            }
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
