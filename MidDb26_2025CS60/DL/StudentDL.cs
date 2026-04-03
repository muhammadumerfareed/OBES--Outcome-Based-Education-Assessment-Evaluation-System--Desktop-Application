using System;
using System.Data;
using MidDb26_2025CS60.Utilities;

namespace MidDb26_2025CS60.DL
{
    public class StudentDL
    {
        // get all students with status name joined
        public DataTable GetAll()
        {
            string query = @"SELECT s.Id, s.FirstName, s.LastName, s.Contact, 
                             s.Email, s.RegistrationNumber, s.Status, l.Name AS StatusName 
                             FROM student s 
                             JOIN lookup l ON s.Status = l.LookupId";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // add new student
        
        public bool Add(string firstName, string lastName, string contact,
                        string email, string regNumber, int status)
        {
            // check if reg number already exists
            string checkQuery = $"SELECT COUNT(*) FROM student WHERE RegistrationNumber='{regNumber}'";
            object count = DatabaseHelper.ExecuteScalar(checkQuery);
            if (count != null && Convert.ToInt32(count) > 0)
                throw new Exception("A student with this registration number already exists.");

            string query = $@"INSERT INTO student (FirstName, LastName, Contact, Email, RegistrationNumber, Status)
                      VALUES ('{firstName}', '{lastName}', '{contact}', '{email}', '{regNumber}', {status})";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        // update existing student
        public bool Update(int id, string firstName, string lastName, string contact,
                           string email, string regNumber, int status)
        {
            string query = $@"UPDATE student SET FirstName='{firstName}', LastName='{lastName}',
                              Contact='{contact}', Email='{email}', 
                              RegistrationNumber='{regNumber}', Status={status}
                              WHERE Id={id}";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        // delete student by id
        public bool Delete(int id)
        {
            // delete child records first 
            DatabaseHelper.ExecuteNonQuery($"DELETE FROM studentattendance WHERE StudentId={id}");
            DatabaseHelper.ExecuteNonQuery($"DELETE FROM studentresult WHERE StudentId={id}");
            string query = $"DELETE FROM student WHERE Id={id}";
            return DatabaseHelper.ExecuteNonQuery(query);
        }
        // for dropdowns
       
        public DataTable GetForDropdown()
        {
            string query = "SELECT Id, CONCAT(RegistrationNumber, ' | ', FirstName, ' ', LastName) AS FullName FROM student";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}