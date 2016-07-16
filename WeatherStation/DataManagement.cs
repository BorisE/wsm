using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;

namespace WeatherStation
{
    class DataManagement
    {
        string baseName = "SensorData.db3";

        /// <summary>
        /// Create DB and Table (1st run)
        /// </summary>
        void Check_NeedToCreateDB()
        {
            if (!File.Exists(baseName))
                CreateDB();
        }

        void Check_NeedToCreateTables()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source="+ baseName + "; Version=3;"))
            {
                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {

                        SQLiteCommand cmd = new SQLiteCommand(conn);

                        cmd.CommandText = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'table_name';";
                        object amount = -1;
                        try
                        {
                            amount = cmd.ExecuteScalar();
                            //text1.Text = amount.ToString();
                        }
                        catch (SQLiteException ex)
                        {
                           // text1.Text = ex.Message;
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    CreateDB();
                }

            }

            
        }

        /// <summary>
        /// Create DB and Table (1st run)
        /// </summary>
        void CreateDB()
        {
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
                    [] real NOT NULL,
                    [BTemp] real NOT NULL,
                    [Press] real NOT NULL,
                    [Hum1] real NOT NULL,
                    [DTemp1] real NOT NULL,
                    [Hum2] real NOT NULL,
                    [DTemp2] real NOT NULL,
                    [Illum] real NOT NULL,
                    [Temp1] real NOT NULL,
                    [Temp2] real NOT NULL,
                    [Wet] integer NOT NULL,
                    [RGC] integer NOT NULL,
                    [RL1] integer NOT NULL,
                    [WSp] real NOT NULL,
                    [CloudIdx] real NOT NULL,
                    [CloudIdxCorr] real NOT NULL,
                    );";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// Save sensors
        /// </summary>
        void SaveSensorDataIntoDB()
        {

            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = DateTime.Now.ToUniversalTime() - origin;
            int UnixTS= Convert.ToInt32(Math.Floor(diff.TotalSeconds));


            SQLiteConnection.CreateFile(baseName);

            SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
            using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
            {
                connection.ConnectionString = "Data Source = " + baseName;
                connection.Open();

                //CreateSensor
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"INSERT INTO TABLE [Sensors] SET
                    date="+ UnixTS.ToString() + 
                    "ObjTemp = "+ 99 +
                    "ATemp="+11+
                    ";";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
