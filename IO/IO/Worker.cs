using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace IO
{
    public partial class Worker : Form
    {
        private DataTable dt = new DataTable();

        public Worker()
        {
            InitializeComponent();
            dataGridViewWorker.Rows.Clear();
            dataGridViewWorker.Refresh();
            dataGridViewWorker.DataSource = WorkerMethods.DisplaySchedule().Tables[0];
        }

        private void btn_info_Click(object sender, EventArgs e)                         //Przycisk "O mnie"
        {
            if (DBConnector.Open())
            {
                dataGridViewWorker.DataSource = null;
                dataGridViewWorker.Rows.Clear();
                dataGridViewWorker.Refresh();
                dataGridViewWorker.DataSource = WorkerMethods.DisplayInformation().Tables[0];
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
                dataGridViewWorker.DataSource = WorkerMethods.DisplaySchedule().Tables[0];
            }
            DBConnector.Close();
        }
    }
}