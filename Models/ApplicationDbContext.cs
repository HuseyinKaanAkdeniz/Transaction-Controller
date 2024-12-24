using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Gelir_Gider_İzleyicisi.Models
{
    public class ApplicationDbContext:DbContext
    {
        internal readonly object Categories;

        public ApplicationDbContext(DbContextOptions options): base(options)    
        {}
        public DbSet<Transaction> transaction { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
