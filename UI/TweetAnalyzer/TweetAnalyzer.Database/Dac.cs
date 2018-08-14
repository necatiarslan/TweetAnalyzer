using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetAnalyzer.Database
{
    public class Dac
    {

        public static Dac Current { get; private set; }

        public Dac()
        {
            Dac.Current = this;
            this.LoadDatabaseFileLocationFromReqistry();
        }

        public string ConnectionString { get => "Data Source=" + this.DatabaseFileLocation + ";Version=3"; }

        public MethodResult ExecuteNonQuery(string comandText)
        {
            MethodResult result = new MethodResult();

            try
            {
                SQLiteConnection sQLiteConnection = new SQLiteConnection(this.ConnectionString);
                sQLiteConnection.Open();

                SQLiteCommand sQLiteCommand = new SQLiteCommand(comandText, sQLiteConnection);
                sQLiteCommand.ExecuteNonQuery();

                result.IsSuccessful = true;
                sQLiteConnection.Close();
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.IsSuccessful = false;
            }

            return result;
        }

        public MethodResult<object> ExecuteScalar(string comandText)
        {
            MethodResult<object> result = new MethodResult<object>();

            try
            {
                SQLiteConnection sQLiteConnection = new SQLiteConnection(this.ConnectionString);
                sQLiteConnection.Open();

                SQLiteCommand sQLiteCommand = new SQLiteCommand(comandText, sQLiteConnection);
                result.Result = sQLiteCommand.ExecuteScalar();
                result.IsSuccessful = true;
                sQLiteConnection.Close();
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.IsSuccessful = false;
            }

            return result;
        }

        public MethodResult<DataTable> ExecuteDataTable(string comandText)
        {
            MethodResult<DataTable> result = new MethodResult<DataTable>();
            result.Result = new DataTable();

            try
            {
                SQLiteConnection sQLiteConnection = new SQLiteConnection(this.ConnectionString);
                sQLiteConnection.Open();

                SQLiteCommand sQLiteCommand = new SQLiteCommand(comandText, sQLiteConnection);

                SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(sQLiteCommand);
                sQLiteDataAdapter.Fill(result.Result);

                sQLiteConnection.Close();

                result.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.IsSuccessful = true;
            }

            return result;
        }

        public string DatabaseFileLocation { get; set; }

        public void SaveDatabaseFileLocationToReqistry()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\TweetAnalyzer");
            key.SetValue("DatabaseFileLocation", this.DatabaseFileLocation);

            key.Close();
        }

        public void LoadDatabaseFileLocationFromReqistry()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\TweetAnalyzer");
            this.DatabaseFileLocation = (string)key.GetValue("DatabaseFileLocation");

            key.Close();
        }

        public static MethodResult<bool> TestDatabaseConnection(string databaseFileLocation)
        {
            MethodResult<bool> result = new MethodResult<bool>();

            if (databaseFileLocation == null)
            {
                result.IsSuccessful = false;
                result.Exception = new NullReferenceException();
                return result;
            }

            if (databaseFileLocation == string.Empty)
            {
                result.IsSuccessful = false;
                result.Exception = new Exception("Empty String");
                return result;
            }

            if (!System.IO.File.Exists(databaseFileLocation))
            {
                result.IsSuccessful = false;
                result.Exception = new Exception("File Not Found");
                return result;
            }

            try
            {
                SQLiteConnection sQLiteConnection = new SQLiteConnection("Data Source=" + databaseFileLocation + ";version=3");
                sQLiteConnection.Open();
                result.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                result.IsSuccessful = false;
                result.Exception = ex;
            }

            return result;
        }

        public MethodResult Insert(string tableName, Dictionary<string, object> columns)
        {
            MethodResult result = new MethodResult();

            if (tableName == null || tableName.Length == 0 || columns == null || columns.Count == 0)
                return result;

            string columnNames = string.Empty;
            string values = string.Empty;
            bool firstLoop = true;

            foreach (string columnName in columns.Keys)
            {
                columnNames += (!firstLoop ? "," : "") + columnName;
                firstLoop = false;
            }

            firstLoop = true;
            foreach (object value in columns.Values)
            {
                values += (!firstLoop ? "," : "") + GetValueString(value);
                firstLoop = false;
            }

            string commandText = "INSERT INTO " + tableName + " (" + columnNames + ") VALUES (" + values + ")";

            result = this.ExecuteNonQuery(commandText);

            return result;
        }

        private string GetValueString(object value)
        {
            string result = string.Empty;

            if (value == null)
                result = "NULL";

            else if (value is string)
                result = "'" + ((string)value).Replace("'", "''") + "'";

            else if (value is bool && (bool)value == true)
                result = "1";

            else if (value is bool && (bool)value == false)
                result = "0";

            else if (value is DateTime)
                result = "'" + ((DateTime)value).ToString("yyyyMMdd HH:mm:ss") + "'";

            else
                result = value.ToString();

            return result;
        }

        public MethodResult Update(string tableName, string primaryKeyColumn, object primaryKeyValue, Dictionary<string, object> columns)
        {
            MethodResult result = new MethodResult();

            if (tableName == null || tableName.Length == 0 || primaryKeyColumn == null || primaryKeyColumn.Length == 0 || primaryKeyValue == null || columns == null || columns.Count == 0)
                return result;

            string setText = string.Empty;
            bool firstLoop = true; ;

            foreach (string columnName in columns.Keys)
            {
                setText += (!firstLoop ? "," : "") + columnName + "=" + GetValueString(columns[columnName]);
                firstLoop = false;
            }

            string commandText = "UPDATE " + tableName + " SET " + setText + " WHERE " + primaryKeyColumn + "=" + GetValueString(primaryKeyValue);

            result = this.ExecuteNonQuery(commandText);

            return result;
        }

        public MethodResult Delete(string tableName, string primaryKeyColumn, object primaryKeyValue)
        {
            MethodResult result = new MethodResult();

            if (tableName == null || tableName.Length == 0 || primaryKeyColumn == null || primaryKeyColumn.Length == 0 || primaryKeyValue == null)
                return result;


            string commandText = "DELETE FROM " + tableName + " WHERE " + primaryKeyColumn + "=" + GetValueString(primaryKeyValue);

            result = this.ExecuteNonQuery(commandText);

            return result;
        }

        public MethodResult<Dictionary<string, object>> Select(string tableName, string primaryKeyColumn, object primaryKeyValue)
        {
            MethodResult<Dictionary<string, object>> result = new MethodResult<Dictionary<string, object>>();
            result.Result = new Dictionary<string, object>();

            if (tableName == null || tableName.Length == 0 || primaryKeyColumn == null || primaryKeyColumn.Length == 0 || primaryKeyValue == null)
                return result;

            string commandText = "SELECT * FROM " + tableName + " WHERE " + primaryKeyColumn + "=" + GetValueString(primaryKeyValue);

            DataTable resultDataTable = this.ExecuteDataTable(commandText).Result;

            if (resultDataTable == null || resultDataTable.Rows.Count == 0)
                return result;

            foreach (DataColumn dataColumn in resultDataTable.Columns)
            {
                result.Result.Add(dataColumn.ColumnName, resultDataTable.Rows[0][dataColumn]);
                result.IsSuccessful = true;
            }

            return result;
        }

        public MethodResult<bool> Exists(string tableName, string primaryKeyColumn, object primaryKeyValue)
        {
            MethodResult<bool> result = new MethodResult<bool>();

            if (tableName == null || tableName.Length == 0 || primaryKeyColumn == null || primaryKeyColumn.Length == 0 || primaryKeyValue == null)
                return result;

            string commandText = "SELECT " + primaryKeyColumn + " FROM " + tableName + " WHERE " + primaryKeyColumn + "=" + GetValueString(primaryKeyValue);

            MethodResult<DataTable> executeResult = this.ExecuteDataTable(commandText);

            if(executeResult.IsSuccessful)
            {
                result.IsSuccessful = true;

                DataTable resultDataTable = this.ExecuteDataTable(commandText).Result;

                if (resultDataTable == null || resultDataTable.Rows.Count == 0)
                {
                    result.Result = false;
                }
                else
                {
                    result.Result = true; 
                }                            
            }
            else
            {
                result.Exception = executeResult.Exception;
                result.IsSuccessful = false;
            }
            
            return result;
        }
    }
}
