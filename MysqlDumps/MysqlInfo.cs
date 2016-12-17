using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Validators;

namespace MysqlDumps
{
    class MysqlInfo
    {
        public static MySqlConnection connection;

        public static MySqlCommand command;

        public static MySqlDataReader reader;

        public static MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();


        public static List<string> GetDatabaseName(string ip, string user, string password)
        {

            try
            {

                builder.Server = ip;

                builder.UserID = user;

                builder.Password = password;

                List<string> databases = new List<string>();

                using (connection = new MySqlConnection(builder.GetConnectionString(true)))
                {
                    using (command = connection.CreateCommand())
                    {
                        command.CommandText = "show databases; ";

                        connection.Open();

                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                databases.Add(reader["Database"].ToString());
                            }
                        }
                    }

                }

                return databases;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static List<string> GetTables(string ip, string database, string user, string password)
        {

            try
            {
                
                builder.Server = ip;

                builder.UserID = user;

                builder.Password = password;

                builder.Database = database;

                List<string> tables = new List<string>();
                
                using (connection = new MySqlConnection(builder.GetConnectionString(true)))
                {
                    using (command = connection.CreateCommand())
                    {
                        command.CommandText = "show tables; ";

                        connection.Open();

                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tables.Add(reader["Tables_in_" + database].ToString());
                            }
                        }

                    }
                }

                return tables;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

/*
 if (!Str.ValidateIP(ip))
                {
                    Message.Warn("Invalid IP");

                    return;
                }

                if (!Str.Validate(user))
                {
                    Message.Warn("Username required");

                    return;
                }

                if (!Str.Validate(password))
                {
                    Message.Warn("Password required");

                    return;
                }
 
 */