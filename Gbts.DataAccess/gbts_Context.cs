using Gbts.DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbts.DataAccess
{
    public class gbts_Context:DbContext
    {
        public gbts_Context()
            : base("name=DefaultConnection") 
        {
           // Database.SetInitializer(new MigrateDatabaseToLatestVersion<gbts_Context, Gbts.DataAccess.Migrations.Configuration>("DefaultConnection"));
        }
        public DbSet<TestData> data { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
