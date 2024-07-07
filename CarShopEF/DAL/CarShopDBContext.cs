using CarShopEF.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarShopEF.DAL;

public class CarShopDBContext: DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Colour> Colours { get; set; }   
    public DbSet<Model> Models { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<CarColours> CarColours { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=ILAHA\\SQLEXPRESS01;Database=CarShopDB;Trusted_Connection=True;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }
}

