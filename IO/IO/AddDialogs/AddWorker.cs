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
    public partial class AddWorker : Form
    {
        public AddWorker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DB.ManagerMethods.AddRecord('w', new string[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text }))
                MessageBox.Show("Sukces");
            else
                MessageBox.Show("Nie udało się dodać rekordu");
        }

        private void textBoxTextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) &&
                !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text) &&
                !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text))
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
    }
}