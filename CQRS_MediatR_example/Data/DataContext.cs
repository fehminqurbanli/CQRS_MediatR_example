using CQRS_MediatR_example.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_MediatR_example.Data
{
    public class DataContext : DbContext
    {
        protected DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }


        public DbSet<Customer>? Customers { get; set; }
    }
}
