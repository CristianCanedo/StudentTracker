using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentTracker
{
    public static class StudentDB
    {
        public static SqlConnection GetConnection()
        {
            string connStr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\RAWR\Desktop\MSSATracker\UpdatedStudentTracker-master\StudenTracker\StudenTracker\Database.mdf;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }

        public static void AddStudent(string firstName, string lastName, string field, string date, string age)
        {
            string insStmt = "INSERT INTO STUDENT (FirstName, LastName, Field, Date, Age) VALUES (@firstName, @lastName, @field, @date, @age)";
            SqlConnection conn = GetConnection();
            SqlCommand insCmd = new SqlCommand(insStmt, conn);
            insCmd.Parameters.AddWithValue("@firstName", firstName);
            insCmd.Parameters.AddWithValue("@lastName", lastName);
            insCmd.Parameters.AddWithValue("@field", field);
            insCmd.Parameters.AddWithValue("@date", date);
            insCmd.Parameters.AddWithValue("@age", age);
            try
            {
                conn.Open();
                insCmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        public static List<Student> GetStudent()
        {
            List<Student> studentList = new List<Student>();
            SqlConnection conn = GetConnection();
            string selStmt = "SELECT * FROM STUDENT ORDER BY LastName,FirstName";
            SqlCommand selCmd = new SqlCommand(selStmt, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = selCmd.ExecuteReader();
                while (reader.Read())
                {
                    Student student = new Student();
                    student.StudentID = (int)reader["StudentID"];
                    student.FirstName = reader["FirstName"].ToString();
                    student.LastName = reader["LastName"].ToString();
                    student.Field = reader["Field"].ToString();
                    student.Date = reader["Date"].ToString();
                    student.Age = reader["Age"].ToString();
                    studentList.Add(student);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return studentList;
        }

    }
}
