using MediatR_CQRS.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatR_CQRS.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
