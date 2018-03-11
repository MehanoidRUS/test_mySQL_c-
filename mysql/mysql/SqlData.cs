using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql
{
    class SqlData
    {
        string ConnectionString = "server=localhost; database=test;user=root;password=12345;";

        /// <summary>
        /// Добавляет запись в таблицу
        /// </summary>
        public void AddData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {

                    connection.Open();
                    for (int i = 0; i < 10; i++)
                    {
                        MySqlCommand command = new MySqlCommand($@"INSERT INTO departments(Name)  VALUES('Departments_{i}')", connection);
                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// считывает данные 
        /// </summary>
        public void ReadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {

                    connection.Open();
                    MySqlCommand command = new MySqlCommand($@"SELECT * FROM departments", connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["id"],3} | {reader["Name"]}");
                    }
                }
            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
