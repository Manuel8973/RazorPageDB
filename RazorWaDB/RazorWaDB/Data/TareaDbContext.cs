using Microsoft.EntityFrameworkCore;
using RazorWaDB.Models;

namespace RazorWaDB.Data
{
    public class TareaDbContext: DbContext
    {
        public TareaDbContext(DbContextOptions<TareaDbContext> options) : base(options) 
        { 
        }
        public DbSet<Tarea> Tareas { get; set; }
        protected TareaDbContext()
        { 
        }
    }
}
