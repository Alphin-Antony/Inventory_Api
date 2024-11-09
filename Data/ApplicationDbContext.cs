using Microsoft.EntityFrameworkCore;
using Project_Api.Models.Entities;

namespace Project_Api.Data
{
    public class ApplicationDbContext:DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
       
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Registration> registrations { get; set; }
        public DbSet<UserLogin> Users { get; set; }
        public DbSet<AddtoCart> AddtoCarts { get; set; }
        public DbSet<Itemdetails> Itemdetails { get; set; }
        public DbSet<AddProducts> AddProducts { get; set; }


    }
}
