namespace Insight_bott;
using Microsoft.EntityFrameworkCore;


public class ApplicationContext : DbContext
{
    
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Insight> Insights { get; set; } = null!;

    public ApplicationContext()
    {
        //Database.EnsureCreated();
        
        // нужна чтобы timestamp работал (поле даты в классе Insight
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true); 
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres");
    }
}
