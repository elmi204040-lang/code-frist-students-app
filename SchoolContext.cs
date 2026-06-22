using System.Data.Entity;

namespace CodeFirstStudentApp
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolDB")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
