using cine_printWayy.Models;
using System;
using System.Data.SqlClient;

namespace cine_printWayy.Repository
{
    public class UserRepository : IDisposable
    {
        private SqlConnection connection;

        public UserRepository()
        {
            string strConn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=cine;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection = new SqlConnection(strConn);
            connection.Open();
        }
 
        public void Create(User user)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"INSERT INTO User VALUES (@Nome, @Senha)";

            cmd.Parameters.AddWithValue("@Nome", user.Username);
            cmd.Parameters.AddWithValue("@Senha", user.Password);

            cmd.ExecuteNonQuery();
        }

        public User Find(string login, string senha)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT * FROM [dbo].Users WHERE Username=@nome AND Password=@senha";
                cmd.Parameters.AddWithValue("@nome", login);
                cmd.Parameters.AddWithValue("@senha", senha);
                SqlDataReader reader = cmd.ExecuteReader();
                User user = new User();
                while (reader.Read())
                {
                    user.Id = (int)reader["Id"];
                    user.Username = (string)reader["Username"];
                    user.Password = (string)reader["Password"];
                }
                return user;
            }
            catch
            {
                return null;
            }

        }
        public void Dispose()
        {
            connection.Close();
        }

    }
}