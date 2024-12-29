using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Connection
{
    public partial class DataBaseContext
    {
        private void ConfigureModel(ModelBuilder modelBuilder) {
            modelBuilder.Entity<TPerson>().ToTable("tperson");
        }

        public DbSet<TPerson> Persons { get; set; }
    }
}
