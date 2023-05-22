using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruMart.Util
{
    class Database
    {
        private DBConfig connStr;
        private Functions fxn;
        public Database()
        {
            connStr = new DBConfig();
            Server = connStr.Server;
            DatabaseName = connStr.Database;
            UserName = connStr.User;
            Password = connStr.Password;
            fxn = new Functions();
        }

        public string Server { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public MySqlConnection Connection { get; set; }

        private static Database _instance = null;
        public static Database Instance()
        {
            if (_instance == null)
                _instance = new Database();
            return _instance;
        }

        public bool IsConnect()
        {
            try
            {
                if (Connection == null)
                {
                    if (String.IsNullOrEmpty(DatabaseName))
                        return false;
                    string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, DatabaseName, UserName, Password);
                    Connection = new MySqlConnection(connstring);
                    Connection.Open();
                }
                if (Connection.State == System.Data.ConnectionState.Closed)
                    Open();
            }
            catch (MySqlException e)
            {
                //System.Windows.Forms.MessageBox.Show(e.Message, "Database Connection Error");
                return false;
            }
            return true;
        }

        public void Close()
        {
            Connection.Close();
        }

        public void Open()
        {
            Connection.Open();
        }

        public MySqlDataReader Select(String stmt, Hashtable attr)
        {
            MySqlDataReader data = null;
            if (IsConnect())
            {
                try
                {
                    string cmdText = stmt;
                    MySqlCommand cmd = new MySqlCommand(cmdText, Connection);
                    if (attr.Count > 0)
                    {
                        foreach (DictionaryEntry element in attr)
                        {
                            cmd.Parameters.AddWithValue((string)element.Key, element.Value);
                        }
                    }
                    //

                    data = cmd.ExecuteReader();

                }
                catch (MySqlException ex)
                {
                    //fxn.ErrorPrompt(null, ex.Message, "Error");
                    Console.WriteLine(ex.Message); 
                }
            }
            else
            {
                fxn.ErrorPrompt(null, "No connection found, check your server is running properly and try again", "Error!");
            }
            return data;
        }

        public bool Insert(String stmt, Hashtable attr)
        {
            bool status = false;

            if (IsConnect())
            {
                try
                {
                    string cmdText = stmt;
                    MySqlCommand cmd = new MySqlCommand(cmdText, Connection);

                    if (attr.Count > 0)
                    {
                        foreach (DictionaryEntry element in attr)
                        {
                            cmd.Parameters.AddWithValue((string)element.Key, element.Value);
                        }
                    }
                    
                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                    {
                        status = true;
                    }
                    else
                    {
                        status = false;
                    }

                    Close();
                }
                catch (MySqlException e)
                {
                    if (e.Number.Equals(1062))
                    {
                        fxn.ErrorPrompt(null, "Duplicate entry of ID", "Insert - ERROR!");
                        status = false;
                    }
                    else
                    {
                        fxn.ErrorPrompt(null, e.Message, "Error");
                        status = false;
                    }
                    
                }
            }
            else
            {
                fxn.ErrorPrompt(null, "No connection found, check your server is running properly and try again", "Error!");
            }

            return status;
        }

        public bool Update(String stmt, Hashtable attr)
        {
            bool status = false;

            if (IsConnect())
            {
                try
                {
                    string cmdText = stmt;
                    MySqlCommand cmd = new MySqlCommand(cmdText, Connection);

                    if (attr.Count > 0)
                    {
                        foreach (DictionaryEntry element in attr)
                        {
                            cmd.Parameters.AddWithValue((string)element.Key, element.Value);
                        }
                    }
                    
                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                    {
                        status = true;
                    }
                    else
                    {
                        status = false;
                    }

                    Close();
                }
                catch (MySqlException e)
                {
                    fxn.ErrorPrompt(null, e.Message, "Error");
                    status = false;
                }
            }
            else
            {
                fxn.ErrorPrompt(null, "No connection found, check your server is running properly and try again", "Error!");
            }

            return status;
        }

        public bool Delete(String stmt, Hashtable attr)
        {
            bool status = false;

            if (IsConnect())
            {
                try
                {
                    string cmdText = stmt;
                    MySqlCommand cmd = new MySqlCommand(cmdText, Connection);

                    if (attr.Count > 0)
                    {
                        foreach (DictionaryEntry element in attr)
                        {
                            cmd.Parameters.AddWithValue((string)element.Key, element.Value);
                        }
                    }
                    //cmd.Parameters.AddWithValue("@id", StuId);
                    //cmd.Parameters.AddWithValue("@psw", psw1.Text.Trim());

                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                    {
                        status = true;
                    }
                    else
                    {
                        status = false;
                    }

                    Close();
                }
                catch (MySqlException e)
                {
                    fxn.ErrorPrompt(null, e.Message, "Error");
                    status = false;
                }
            }
            else
            {
                fxn.ErrorPrompt(null, "No connection found, check your server is running properly and try again", "Error!");
            }

            return status;
        }

        public void UpdateAssignee(string asset_id, string assignee_id)
        {

            if (IsConnect())
            {
                try
                {
                    string stmt = "UPDATE assets SET assignee_id=@as WHERE asset_id=@id LIMIT 1";
                    Hashtable attr = new Hashtable();
                    attr.Add("@id", asset_id.Trim());
                    attr.Add("@as", assignee_id.Trim());
                    string cmdText = stmt;
                    
                    MySqlCommand cmd = new MySqlCommand(cmdText, Connection);

                    if (attr.Count > 0)
                    {
                        foreach (DictionaryEntry element in attr)
                        {
                            cmd.Parameters.AddWithValue((string)element.Key, element.Value);
                        }
                    }

                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                    {
                    }
                    else
                    {
                    }

                    Close();
                }
                catch (MySqlException e)
                {
                    fxn.ErrorPrompt(null, e.Message, "Error");
                }
            }
            else
            {
                fxn.ErrorPrompt(null, "No connection found, check your server is running properly and try again", "Error!");
            }

        }

        public void UpdateAssetId(string asset_id, string assignee_id)
        {

            if (IsConnect())
            {
                try
                {
                    string stmt = "UPDATE employees SET asset_id=@as WHERE employee_id=@id LIMIT 1";
                    Hashtable attr = new Hashtable();
                    attr.Add("@as", asset_id.Trim());
                    attr.Add("@id", assignee_id.Trim());
                    string cmdText = stmt;

                    MySqlCommand cmd = new MySqlCommand(cmdText, Connection);

                    if (attr.Count > 0)
                    {
                        foreach (DictionaryEntry element in attr)
                        {
                            cmd.Parameters.AddWithValue((string)element.Key, element.Value);
                        }
                    }

                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                    {
                    }
                    else
                    {
                    }

                    Close();
                }
                catch (MySqlException e)
                {
                    fxn.ErrorPrompt(null, e.Message, "Error");
                }
            }
            else
            {
                fxn.ErrorPrompt(null, "No connection found, check your server is running properly and try again", "Error!");
            }
            
        }

        public bool UpdateReportId(string report_id, string asset_id)
        {
            bool isSuc = false;
            if (IsConnect())
            {
                try
                {
                    string stmt = "UPDATE assets SET rep_id=@rp, status=@st WHERE asset_id=@id LIMIT 1";
                    Hashtable attr = new Hashtable();
                    attr.Add("@rp", report_id.Trim());
                    attr.Add("@st", 1);
                    attr.Add("@id", asset_id.Trim());
                    string cmdText = stmt;

                    MySqlCommand cmd = new MySqlCommand(cmdText, Connection);

                    if (attr.Count > 0)
                    {
                        foreach (DictionaryEntry element in attr)
                        {
                            cmd.Parameters.AddWithValue((string)element.Key, element.Value);
                        }
                    }

                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                    {
                        isSuc = true;
                    }
                    else
                    {
                    }

                    Close();
                }
                catch (MySqlException e)
                {
                    fxn.ErrorPrompt(null, e.Message, "Error");
                }
            }
            else
            {
                fxn.ErrorPrompt(null, "No connection found, check your server is running properly and try again", "Error!");
            }
            return isSuc;

        }
    }
}
