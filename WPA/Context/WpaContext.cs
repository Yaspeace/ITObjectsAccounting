using Microsoft.EntityFrameworkCore;

namespace BD_Kursach_WPF
{
    public class WpaContext : DbContext
    {
        public DbSet<ITObject> it_objects { get; set; }
        public DbSet<Location> locations { get; set; }
        public DbSet<Unit> units { get; set; }
        public DbSet<Position> positions { get; set; }
        public DbSet<SoftwareReq> software_requirements { get; set; }
        public DbSet<UnitBinding> unit_bindings { get; set; }
        public DbSet<LocationBinding> location_bindings { get; set; }
        public DbSet<PositionSoftBinding> position_software_bindings { get; set; }
        public DbSet<PositionObjBinding> position_obj_bindings { get; set; }
        public WpaContext(DbContextOptions opt) : base(opt)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }
    }
}