namespace BillSplitter.Models
{
    public class ApplicationDbContext : DbContext
    {
        public string DBPath { get; }

        public ApplicationDbContext()
        {
            //var folder = Environment.CurrentDirectory;
            //var path = $"{folder}/Database/";
            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}
            //DBPath = Path.Combine(path, "BillSplitter.db");
            DBPath = "BillSplitter.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DBPath}");
        }

        public DbSet<Employee> Employees { get; set; }

    }
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
