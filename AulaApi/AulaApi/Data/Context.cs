using AulaApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AulaApi.Data
{
    public class Context: DbContext
    {   /*fazer a mao*/
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
