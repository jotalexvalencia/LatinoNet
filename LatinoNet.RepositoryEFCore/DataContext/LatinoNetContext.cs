using LatinoNET.Entities.POCOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.RepositoryEFCore.DataContext
{
    public class LatinoNetContext: DbContext
    {
        public LatinoNetContext(
            DbContextOptions<LatinoNetContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
