using IO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DB;
using IO.AddDialogs;
using System.IO;

namespace OracleGUI
{
    public partial class Manager : Form
    {
        private bool displayed = false;

        public Manager()
        {
            InitializeComponent();
            this.Name = "Manager Panel";
            displayed = true;
            dataGridViewManager.AutoGenerateColumns = true;
        }

        private void buttonChange_Click(object sender, EventArgs e)	//Przycisk "Zamień"
        {
            if (!displayed)
                return;
            if (dataGridViewManager.SelectedCells == null)	//Nie można edytować kiedy nie ma wybranej komórki oraz kiedy wybierzemy tabelę wypadki
                return;
            var radioButton = groupBoxManager.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (radioButton != null)
            {
                string name = radioButton.Text;
                if (name.Equals("Wypadki"))
                {
                    MessageBox.Show("Nie można edytować wypadków");
                    return;
                }
                if (name.Equals("Czas_Przyjazdu"))
                {
                    MessageBox.Show("Nie można edytować Czas_Przyjazdu");
                    return;
                }
                string dpn = dataGridViewManager.Columns[dataGridViewManager.CurrentCell.ColumnIndex].DataPropertyName;	//Zmienne służące do przechowania informacji dotyczących zmiany konkretnego rekordu
                string change = tb_change.Text;
                string id = dataGridViewManager.Rows[dataGridViewManager.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string where = dataGridViewManager.Columns[0].DataPropertyName;

                dataGridViewManager.DataSource = null;	//Resetowanie DGV
                dataGridViewManager.Rows.Clear();	//Resetowanie DGV
                dataGridViewManager.Refresh();		//Resetowanie DGV
                ManagerMethods.UpdateTable(name, dpn, change, id, where);
                dataGridViewManager.DataSource = ManagerMethods.DisplayTable(name).Tables[0];
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!displayed)
                return;
            if (((RadioButton)sender).Checked)
            {
                string name = ((RadioButton)sender).Text;
                dataGridViewManager.DataSource = null;
                dataGridViewManager.Rows.Clear();
                dataGridViewManager.Refresh();
                var output = ManagerMethods.DisplayTable(name).Tables[0];
                dataGridViewManager.DataSource = output;
                dataGridViewManager.Refresh();
                //StreamWriter sw = new StreamWriter(String.Format("AutoITTest\\Manager{0}Test.xml", name), false);
                //output.WriteXml(sw);
                //sw.Close();
                //sw.Dispose();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!displayed)
                return;
            if (dataGridViewManager.SelectedCells == null)	//Nie można edytować kiedy nie ma wybranej komórki oraz kiedy wybierzemy tabelę wypadki
                return;
            var radioButton = groupBoxManager.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (radioButton != null)
            {
                string name = radioButton.Text;
                if (name.Equals("Wypadki"))
                {
                    MessageBox.Show("Nie można usuwać wypadków");
                    return;
                }
                if (name.Equals("Czas_Przyjazdu"))
                {
                    MessageBox.Show("Nie można usuwać Czas_Przyjazdu");
                    return;
                }
                string id = dataGridViewManager.Rows[dataGridViewManager.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string where = dataGridViewManager.Columns[0].DataPropertyName;

                dataGridViewManager.DataSource = null;	//Resetowanie DGV
                dataGridViewManager.Rows.Clear();	//Resetowanie DGV
                dataGridViewManager.Refresh();		//Resetowanie DGV
                ManagerMethods.DeleteFromTable(name, id, where);
                dataGridViewManager.DataSource = ManagerMethods.DisplayTable(name).Tables[0];
            }
        }

        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            AddWorker addWorker = new AddWorker();
            addWorker.ShowDialog();
        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicle = new AddVehicle();
            addVehicle.ShowDialog();
        }

        private void buttonAddTimetable_Click(object sender, EventArgs e)
        {
            AddTimetable addTimetable = new AddTimetable();
            addTimetable.ShowDialog();
        }

        private void buttonAddDepot_Click(object sender, EventArgs e)
        {
            AddDepot addDepot = new AddDepot();
            addDepot.ShowDialog();
        }

        private void buttonAddStop_Click(object sender, EventArgs e)
        {
            AddStop addStop = new AddStop();
            addStop.ShowDialog();
        }

        private void buttonAddSchedule_Click(object sender, EventArgs e)
        {
            AddSchedule addSchedule = new AddSchedule();
            addSchedule.ShowDialog();
        }

        private void buttonAddNumber_Click(object sender, EventArgs e)
        {
            AddNumber addNumber = new AddNumber();
            addNumber.ShowDialog();
        }
    }
}