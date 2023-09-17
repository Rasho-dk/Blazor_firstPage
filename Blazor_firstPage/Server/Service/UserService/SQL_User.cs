using Blazor_firstPage.Shared;
using System.Data.SqlClient;

namespace Blazor_firstPage.Server.Service.UserService
{
    public class SQL_User
    {
        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TESTSS;Integrated Security=True;Connect Timeout=30;";

        public static List<User> GetUsers()
        {
            string sql = "SELECT * FROM Customer";
            List<User> users = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.Id = Convert.ToInt32(reader[0]);
                        user.Name = Convert.ToString(reader[1]);
                        user.Email = Convert.ToString(reader[2]);

                        users.Add(user);
                    }
                }                   
            }
            return users;
        }
    }
}
