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
    public partial class AddStop : Form
    {
        public AddStop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DB.ManagerMethods.AddRecord('p', new string[] { textBox1.Text, textBox2.Text, textBox3.Text }))
                MessageBox.Show("Sukces");
            else
                MessageBox.Show("Nie udało się dodać rekordu");
        }

        private void textBoxTextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) &&
                !String.IsNullOrEmpty(textBox3.Text))
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
    }
}