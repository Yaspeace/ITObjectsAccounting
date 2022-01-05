using Microsoft.EntityFrameworkCore;

namespace BD_Kursach_WPF
{
    public class WpaContext : DbContext
    {
        public WpaContext(DbContextOptions opt) : base(opt)
        {
            Database.EnsureCreated();
        }
    }
}