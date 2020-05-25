using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADODemo {
    class Program {
    static void Main(string[] args) {
        Program p = new Program();
        Console.WriteLine("InsertAuthor:莫言");
        InsertAuthor();
        QueryAuthors();

        Console.WriteLine("DeleteAuthor:莫言");
        DeleteAuthor();
        QueryAuthors();

        Console.WriteLine("QueryBookAndAuthor:");
        QueryBookAndAuthor();
        Console.ReadKey();
}

    private static void InsertAuthor() {
      using (MySqlConnection connection = GetConnection()) {
        using (MySqlCommand cmd = new MySqlCommand
        ("INSERT INTO Authors(Name) VALUES(@Name)", connection)) {
          cmd.Prepare();
          cmd.Parameters.AddWithValue("@Name", "莫言");
          cmd.ExecuteNonQuery();
        }
      }
    }

    private static void DeleteAuthor() {
      using (MySqlConnection connection = GetConnection()) {
        using (MySqlCommand cmd = new MySqlCommand
        ("DELETE FROM Authors where Name= '莫言'", connection)) {
          cmd.ExecuteNonQuery();
        }
      }
    }

    private static void QueryAuthors() {
      using (MySqlConnection connection = GetConnection()) {
        string stm = "SELECT * FROM Authors";
        using (MySqlCommand cmd = new MySqlCommand(stm, connection)) {
          using (MySqlDataReader reader = cmd.ExecuteReader()) {
            while (reader.Read()) {
              Console.WriteLine(reader.GetInt32(0) + ": "
                  + reader.GetString(1));
            }
          }
        }
      }
    }

    private static void QueryBookAndAuthor() {
      using (MySqlConnection connection = GetConnection()) {
        string stm = @"SELECT Title,Name FROM Authors,
                Books WHERE Authors.Id=Books.AuthorId";
        using (MySqlCommand cmd = new MySqlCommand(stm, connection)) {
          using (MySqlDataReader reader = cmd.ExecuteReader()) {
            while (reader.Read()) {
              Console.WriteLine(reader.GetString(0) + "\t" +
               reader.GetString(1));
            }
          }
        }
      }
    }


    private static MySqlConnection GetConnection() {
      MySqlConnection connection = new MySqlConnection(
          "server=localhost;user id=root;password=13317108945;database=book");
      connection.Open();
      return connection;
    }
  }

}
