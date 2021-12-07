using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.MySQL_Connector
{
    public class DataManager
    {
        MySqlConnection connection = null;

        public DataManager()
        {

            // Initializing MySQL connection object
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            connection = new MySqlConnection(connectionString);
        }

        /*
        * FUNCTION : OpenConnection
        *
        * DESCRIPTION : This function opens database connection
        *
        * PARAMETERS : none
        * 
        * Returns: boolean having db connection status, if true connection opened successfully.
        *
        */
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        break;

                    case 1045:
                        break;
                }
                return false;
            }
        }

        /*
        * FUNCTION : CloseConnection
        *
        * DESCRIPTION : This function closes database connection
        *
        * PARAMETERS : none
        * 
        * Returns: boolean having db connection status, if true connection closed successfully.
        *
        */
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }


        public T SelectOne<T>(T entity, string entityName, string whereClause = "")
        {
            DataTable dt = SelectEntity(entity, entityName, whereClause);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                string[] columnNames = dt.Columns.Cast<DataColumn>()
                                 .Select(x => x.ColumnName)
                                 .ToArray();
                foreach (string col in columnNames)
                {
                    PropertyInfo prop = entity.GetType().GetProperty(col, BindingFlags.Public | BindingFlags.Instance);
                    if (prop != null && prop.CanWrite)
                    {
                        prop.SetValue(entity, row[col], null);
                    }
                }
            }

            return entity;
        }

        public List<T> SelectMany<T>(T entity, string entityName, string whereClause = "")
        {
            var type = entity.GetType();
            List<T> list = new List<T>();

            var dt = this.SelectEntity(entity, entityName, whereClause);
            foreach (DataRow row in dt.Rows.Cast<DataRow>())
            {
                string[] columnNames = dt.Columns.Cast<DataColumn>()
                                 .Select(x => x.ColumnName)
                                 .ToArray();
                foreach (string col in columnNames)
                {
                    PropertyInfo prop = entity.GetType().GetProperty(col, BindingFlags.Public | BindingFlags.Instance);
                    if (prop != null && prop.CanWrite)
                    {
                        prop.SetValue(entity, row[col], null);
                    }
                }
                list.Add(entity);
            }
            return list;
        }


        /*
        * FUNCTION : SelectEntity
        *
        * DESCRIPTION : This function update entity into database
        *
        * PARAMETERS : 
        * T entity         -         entity to update 
        *
        */
        private DataTable SelectEntity<T>(T entity, string entityName, string whereClause = "")
        {
            DataTable dt = new DataTable(entityName);
            var properties = entity.GetType().GetProperties();

            if (this.OpenConnection())
            {
                string query = $"SELECT * FROM {entityName} {whereClause}";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                foreach (PropertyInfo prop in properties)
                {
                    cmd.Parameters.AddWithValue($"@{prop.Name}", prop.GetValue(entity, null));
                }


                MySqlDataAdapter returnVal = new MySqlDataAdapter(cmd);
                returnVal.Fill(dt);

                //close connection
                this.CloseConnection();
            }
            return dt;
        }

        /*
        * FUNCTION : UpdateEntity
        *
        * DESCRIPTION : This function update entity into database
        *
        * PARAMETERS : 
        * T entity         -         entity to update 
        *
        */
        public T UpdateEntity<T>(T entity, string entityName, bool isEdit)
        {
            string query = "";
            var properties = entity.GetType().GetProperties();
            if (isEdit)
            {
                query = $"Update {entityName} SET ";
                for (int i = 0; i < properties.Length; i++)
                {
                    var prop = properties[i];
                    if (i == properties.Length - 1)
                    {
                        query += $"{prop.Name}=@{prop.Name}";
                    }
                    else
                    {
                        query += $"{prop.Name}=@{prop.Name}, ";
                    }
                }
            }
            else
            {
                query = $"INSERT INTO {entityName} (";
                for (int i = 0; i < properties.Length; i++)
                {
                    var prop = properties[i];
                    if (i == properties.Length - 1)
                    {
                        query += prop.Name + ")";
                    }
                    else
                    {
                        query += prop.Name + ", ";
                    }
                }
                query += " VALUES(";
                for (int i = 0; i < properties.Length; i++)
                {
                    var prop = properties[i];
                    if (i == properties.Length - 1)
                    {
                        query += "@" + prop.Name.ToString() + ")";
                    }
                    else
                    {
                        query += "@" + prop.Name.ToString() + ",";
                    }
                }
            }
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                foreach (PropertyInfo prop in properties)
                {
                    cmd.Parameters.AddWithValue($"@{prop.Name}", prop.GetValue(entity, null));
                }

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }

            return entity;
        }


    }

}
