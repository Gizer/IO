using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
using DB;
using System.IO;

namespace Guru99Demo
{
    internal class Guru99Demo
    {
        private AutoItX3 auto = new AutoItX3();
        private StreamWriter sw;

        [SetUp]
        public void setup()
        {
            //DBConnector.SetLogin("kiero");
            //DBConnector.SetPass("kierownik1");
            //DBConnector.Open();
            //string[] testFileNames = new string[appFileNames.Length];
            //for (int j = 0; j < appFileNames.Length; j++)
            //{
            //    testFileNames[j] = appFileNames[j].Replace("App.xml", "Test.xml");
            //}
            //short i = 0;
            //sw = new StreamWriter(testFileNames[i++], false);
            //UserMethods.DisplayTimetable().WriteXml(sw);
            //sw.Close();

            //sw = new StreamWriter(testFileNames[i++], false);
            //WorkerMethods.DisplayInformation().WriteXml(sw);
            //sw.Close();

            //sw = new StreamWriter(testFileNames[i++], false);
            //WorkerMethods.DisplaySchedule().WriteXml(sw);
            //sw.Close();

            //sw = new StreamWriter(testFileNames[i++], false);
            //ManagerMethods.DisplayTable("Pojazdy").WriteXml(sw);
            //sw.Close();
        }

        [Test]
        public void UserTest()
        {
            Process.Start("C:\\Users\\Arkadiusz Cichy\\Desktop\\IOauto\\IO\\IO\\bin\\Debug\\IO.exe");
            auto.Sleep(1000);
            auto.MouseClick("LEFT", 985, 483, 1, 0);
            auto.Sleep(2000);
            auto.WinClose("User");
            string appFileName = "C:\\Users\\Arkadiusz Cichy\\Desktop\\IOauto\\IO\\IO\\bin\\Debug\\AutoITTest\\UserApp.xml";
            string testFileName = "C:\\Users\\Arkadiusz Cichy\\Desktop\\IOauto\\IO\\IO\\bin\\Debug\\AutoITTest\\UserTest.xml";
            Assert.AreEqual(new StreamReader(testFileName).ReadToEnd(), new StreamReader(appFileName).ReadToEnd());
        }

        [Test]
        public void WorkerTest()
        {
            Process.Start("C:\\Users\\Arkadiusz Cichy\\Desktop\\IOauto\\IO\\IO\\bin\\Debug\\IO.exe");
            auto.Sleep(1000);
            auto.MouseClick("LEFT", 985, 517, 1, 0);
            auto.Send("Heindrick");
            auto.Sleep(500);
            auto.MouseClick("LEFT", 985, 544, 1, 0);
            auto.Send("Hackford");
            auto.Sleep(500);
            auto.MouseClick("LEFT", 985, 574, 1, 0);
            auto.Sleep(2000);
            auto.WinClose("Worker");
            string appFileName = "C:\\Users\\Arkadiusz Cichy\\Desktop\\IOauto\\IO\\IO\\bin\\Debug\\AutoITTest\\WorkerScheduleApp.xml";
            string testFileName = "C:\\Users\\Arkadiusz Cichy\\Desktop\\IOauto\\IO\\IO\\bin\\Debug\\AutoITTest\\WorkerScheduleTest.xml";
            Assert.AreEqual(new StreamReader(testFileName).ReadToEnd(), new StreamReader(appFileName).ReadToEnd());
        }

        [Test]
        public void ManagerTest()
        {
            Process.Start("C:\\Users\\Arkadiusz Cichy\\Desktop\\IOauto\\IO\\IO\\bin\\Debug\\IO.exe");
            auto.Sleep(1000);
            auto.MouseClick("LEFT", 985, 517, 1, 0);
            auto.Send("Adelle");
            auto.Sleep(500);
            auto.MouseClick("LEFT", 985, 544, 1, 0);
            auto.Send("Dominighi");
            auto.Sleep(500);
            auto.MouseClick("LEFT", 985, 574, 1, 0);
            auto.Sleep(1000);
            auto.MouseClick("LEFT", 585, 482, 1, 0);
            auto.Sleep(2000);
            auto.WinClose("Manager");
            string appFileName = "C:\\Users\\Arkadiusz Cichy\\Desktop\\IOauto\\IO\\IO\\bin\\Debug\\AutoITTest\\ManagerGrafikApp.xml";
            string testFileName = "C:\\Users\\Arkadiusz Cichy\\Desktop\\IOauto\\IO\\IO\\bin\\Debug\\AutoITTest\\ManagerGrafikTest.xml";
            Assert.AreEqual(new StreamReader(testFileName).ReadToEnd(), new StreamReader(appFileName).ReadToEnd());
        }
    }
}