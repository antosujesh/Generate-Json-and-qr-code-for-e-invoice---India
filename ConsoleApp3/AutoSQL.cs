using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Data;

namespace AutoExe
{
    class AutoSQL
    {

        public bool RunSqlScriptFile(string pathStoreProceduresFile,string ID, string connectionString)
        {
            try
            {

                string script = File.ReadAllText(pathStoreProceduresFile);

                // split script on GO command
                System.Collections.Generic.IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                         RegexOptions.Multiline | RegexOptions.IgnoreCase);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (string commandString in commandStrings)
                    {
                        if (commandString.Trim() != "")
                        {
                            using (var command = new SqlCommand(commandString, connection))
                            {
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (SqlException ex)
                                {
                                    string spError = commandString.Length > 100 ? commandString.Substring(0, 100) + " ...\n..." : commandString;
                                    string RESP = string.Format("Please check your SqlServer script.\nFile: {0} \nLine: {1} \nError: {2} \nSQL Command: \n{3}", pathStoreProceduresFile, ex.LineNumber, ex.Message, spError);
                                    Console.Write(RESP); Console.Write("\n\n\nSCRIPT EXE FAILED");
                                    UpdateStatus(connectionString, "FAILED", RESP,ID); 
                                    return false;
                                }
                            }
                        }
                    }
                    connection.Close();
                }
                UpdateStatus(connectionString, "SUCCESS", "SCRIPT EXE SUCCESSFULLY ", ID);
                Console.Write("SCRIPT EXE SUCCESSFULLY");
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                UpdateStatus(connectionString, "FAILED", ex.Message, ID);
                Console.Write("SCRIPT EXE FAILED");
                return false;
            }
        }

        public void Loop_Pending_Script(string Connection, string SQL, string ScriptPath) //ScriptPath
        {
            DataTable dt = GetDataTable(Connection, SQL);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    RunSqlScriptFile(ScriptPath + dt.Rows[i]["FILE_NAME"].ToString(), dt.Rows[i]["ID"].ToString(), Connection);
                }
            }
        }


        public static DataTable GetDataTable(string connection, string sql)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public void UpdateStatus(string Connection, string status,string Response,  string ID)
        {
            SqlConnection connection = new SqlConnection(Connection);
            SqlCommand cmd = new SqlCommand("update EXE_SCRIPT set STATUS=@STATUS ,RESPONSE=@RESPONSE where ID=@ID ", connection);
            cmd.Parameters.AddWithValue("@STATUS", status);
            cmd.Parameters.AddWithValue("@RESPONSE", Response);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.CommandType = CommandType.Text;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void InsertRecord(string Connection, string USER_NAME, string PASSWORD, string CONTACT_NUMBER, string EMAIL, string Code)
        {
            SqlConnection connection = new SqlConnection(Connection);
            SqlCommand cmd = new SqlCommand("insert into Oman (USER_NAME,PASSWORD,CONTACT_NUMBER,EMAIL,Code) values (@USER_NAME,@PASSWORD,@CONTACT_NUMBER,@EMAIL,@Code) ", connection);
            cmd.Parameters.AddWithValue("@USER_NAME", USER_NAME);
            cmd.Parameters.AddWithValue("@PASSWORD", PASSWORD);
            cmd.Parameters.AddWithValue("@CONTACT_NUMBER", CONTACT_NUMBER);
            cmd.Parameters.AddWithValue("@EMAIL", EMAIL);
            cmd.Parameters.AddWithValue("@Code", Code);
            cmd.CommandType = CommandType.Text;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void UpdateRecord(string Connection, string USER_NAME, string CONTACT_NUMBER, string EMAIL, string Code)
        {
            SqlConnection connection = new SqlConnection(Connection);
            SqlCommand cmd = new SqlCommand("update Oman set Code =@Code where (CONTACT_NUMBER=@CONTACT_NUMBER and EMAIL=@EMAIL) or CONTACT_NUMBER=@CONTACT_NUMBER or EMAIL=@EMAIL ", connection);
            cmd.Parameters.AddWithValue("@CONTACT_NUMBER", CONTACT_NUMBER);
            cmd.Parameters.AddWithValue("@EMAIL", EMAIL);
            cmd.Parameters.AddWithValue("@Code", Code);
            cmd.CommandType = CommandType.Text;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }


    }
}
