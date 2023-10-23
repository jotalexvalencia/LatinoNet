using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.RepositoryEFCore.DataContext
{
    class LatinoNetContextFactory : IDesignTimeDbContextFactory<LatinoNetContext>
    {
        public LatinoNetContext CreateDbContext(string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<LatinoNetContext>();
            //OptionsBuilder.UseSqlServer(
            //    "Server=(localdb)\\mssqllocaldb;LatinoNet");
            OptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LatinoNet;Trusted_Connection=True;");

            return new LatinoNetContext(OptionsBuilder.Options);
        }
    }
}
