using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace TestDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            TestConnection1();
            TestConnection2();
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////
        /// </summary>
        void TestConnection1()
        {
            string baseName = "TestSensorData.db3";
            //Create file
            if (!File.Exists(baseName))
                SQLiteConnection.CreateFile(baseName);


            SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
            using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
            {
                connection.ConnectionString = "Data Source = " + baseName;
                connection.Open();

                //CreateSensor
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"CREATE TABLE [Sensors] (
                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [date] integer NOT NULL,
                    [ObjTemp] real NOT NULL,
                    [ATemp] real NOT NULL,
                    [BTemp] real,
                    [Press] real 

                    );";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }

            text1.Text = "Create table Query executed";

            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = DateTime.Now.ToUniversalTime() - origin;
            int UnixTS = Convert.ToInt32(Math.Floor(diff.TotalSeconds));


            using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
            {
                connection.ConnectionString = "Data Source = " + baseName;
                connection.Open();

                //CreateSensor
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"INSERT INTO [Sensors] (date, ObjTemp, ATemp) VALUES (@dt, @objtemp, @atemp);";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add(new SQLiteParameter("@dt", UnixTS));
                    command.Parameters.Add(new SQLiteParameter("@objtemp", "99"));
                    command.Parameters.Add(new SQLiteParameter("@atemp", "13"));

                    try
                    {
                        command.ExecuteNonQuery();
                        text1.Text = "Query executed";
                    }
                    catch (Exception ex)
                    {
                        text1.Text = ex.Message;
                    }
                }


            }
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        void TestConnection2()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=TestSensorData.db3; Version=3;"))
            {
                try
                {
                    conn.Open();
                }
                catch (SQLiteException ex)
                {
                    text1.Text = ex.Message;
                }

                if (conn.State == ConnectionState.Open)
                {

                    SQLiteCommand cmd = new SQLiteCommand(conn);

                    cmd.CommandText = "SELECT count(id) FROM Sensors";
                    object amount = -1;
                    try
                    {
                        amount = cmd.ExecuteScalar();
                        text1.Text = amount.ToString();
                    }
                    catch (SQLiteException ex)
                    {
                        text1.Text = ex.Message;
                    }


                }

            }
        }
    }

}
