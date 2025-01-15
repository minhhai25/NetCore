using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lession03_model.Models.DataModels;

namespace Lession03_model.Data
{
    public class Lession03_modelContext : DbContext
    {
        public Lession03_modelContext (DbContextOptions<Lession03_modelContext> options)
            : base(options)
        {
        }

        public DbSet<Lession03_model.Models.DataModels.Product> Product { get; set; } = default!;
    }
}
