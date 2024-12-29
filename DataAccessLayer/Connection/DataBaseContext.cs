using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Connection
{
    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext() {
            InitAutoMapper.Start();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=dbds20242;User=root;Password=1512;";
                ServerVersion serverVersion = new MySqlServerVersion(new Version(11, 5, 2));
                optionsBuilder.UseMySql(connectionString,serverVersion);
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureModel(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
