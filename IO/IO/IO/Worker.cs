using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DB;

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
            var output = WorkerMethods.DisplaySchedule().Tables[0];
            dataGridViewWorker.DataSource = output;
            //StreamWriter sw = new StreamWriter("AutoITTest\\WorkerScheduleApp.xml", false);
            //output.WriteXml(sw);
            //sw.Close();
            //sw.Dispose();
        }

        private void btn_info_Click(object sender, EventArgs e)                         //Przycisk "O mnie"
        {
            if (DBConnector.Open())
            {
                dataGridViewWorker.DataSource = null;
                dataGridViewWorker.Rows.Clear();
                dataGridViewWorker.Refresh();
                var output = WorkerMethods.DisplayInformation().Tables[0];
                dataGridViewWorker.DataSource = output;
                //StreamWriter sw = new StreamWriter("AutoITTest\\WorkerInformationApp.xml", false);
                //output.WriteXml(sw);
                //sw.Close();
                //sw.Dispose();
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