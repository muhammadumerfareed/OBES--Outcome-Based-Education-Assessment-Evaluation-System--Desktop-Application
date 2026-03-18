using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MidDb26_2025CS60.Models;

namespace MidDb26_2025CS60.DAL
{
    public class StudentRepository
    {
        public List<Student> GetAll()
        {
            List<Student> list = new List<Student>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM student";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Student
                    {
                        Id = reader.GetInt32("Id"),
                        FirstName = reader.GetString("FirstName"),
                        LastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? "" : reader.GetString("LastName"),
                        Email = reader.GetString("Email"),
                        Contact = reader.IsDBNull(reader.GetOrdinal("Contact")) ? "" : reader.GetString("Contact"),
                        RegistrationNumber = reader.GetString("RegistrationNumber"),
                        Status = reader.GetInt32("Status")
                    });
                }
            }
            return list;
        }

        public void Add(Student s)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO student 
                                (FirstName, LastName, Email, Contact, RegistrationNumber, Status) 
                                VALUES (@fn, @ln, @em, @co, @rn, @st)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fn", s.FirstName);
                cmd.Parameters.AddWithValue("@ln", s.LastName);
                cmd.Parameters.AddWithValue("@em", s.Email);
                cmd.Parameters.AddWithValue("@co", s.Contact);
                cmd.Parameters.AddWithValue("@rn", s.RegistrationNumber);
                cmd.Parameters.AddWithValue("@st", s.Status);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Student s)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE student SET 
                                FirstName=@fn, LastName=@ln, Email=@em, 
                                Contact=@co, RegistrationNumber=@rn, Status=@st 
                                WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fn", s.FirstName);
                cmd.Parameters.AddWithValue("@ln", s.LastName);
                cmd.Parameters.AddWithValue("@em", s.Email);
                cmd.Parameters.AddWithValue("@co", s.Contact);
                cmd.Parameters.AddWithValue("@rn", s.RegistrationNumber);
                cmd.Parameters.AddWithValue("@st", s.Status);
                cmd.Parameters.AddWithValue("@id", s.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM student WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}