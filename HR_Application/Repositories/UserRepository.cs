using HR_Application.Data;
using HR_Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace HR_Application.Repositories
{
    //public class UserRepository : IUserRepository
    //{
    //    private readonly ApplicationDbContext _context;

    //    public UserRepository(ApplicationDbContext context)
    //    {
    //        _context = context;
    //    }

    //    public User GetUserByUsername(string username)
    //    {
    //        return _context.Users
    //            .FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
    //    }
    //}

    public class UserRepository : IUserRepository
    {
        public User GetUserByUsername(string username)
        {
            User user = null;

            // Query to fetch user by username
            string query = "SELECT Username, Role, PasswordHash FROM Users WHERE Username = @Username";

            using (var connection = DbConnectionHelper.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                Username = reader["Username"].ToString(),
                                Role = reader["Role"].ToString(),
                                PasswordHash = reader["PasswordHash"].ToString()
                            };
                        }
                    }
                }
            }

            return user;
        }
    }
}
