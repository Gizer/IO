using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO.AddDialogs
{
    public partial class AddNumber : Form
    {
        public AddNumber()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (DB.ManagerMethods.AddRecord('n', new string[] { textBox1.Text, textBox2.Text }))
                MessageBox.Show("Sukces");
            else
                MessageBox.Show("Nie udało się dodać rekordu");
        }

        private void textBoxTextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
                buttonAdd.Enabled = true;
            else
                buttonAdd.Enabled = false;
        }
    }
}