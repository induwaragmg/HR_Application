using HR_Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace HR_Application.Data
{
    //public class ApplicationDbContext : DbContext
    //{
    //    public DbSet<User> Users { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=HR_Application;Integrated Security=True");
    //    }
    //}

    public static class DbConnectionHelper
    {
        private const string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HR_Application;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}