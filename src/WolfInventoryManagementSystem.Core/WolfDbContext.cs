using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace WolfInventoryManagementSystem.Core;

public class WimsDbContext : DbContext
{
    public DbSet<Item> Items => Set<Item>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Sale> Sales => Set<Sale>();
    public DbSet<SaleLineItem> SaleLineItems => Set<SaleLineItem>();
    public DbSet<InventoryAdjustment> InventoryAdjustments => Set<InventoryAdjustment>();
    public DbSet<SaleReturn> SaleReturns => Set<SaleReturn>();
    public DbSet<Supplier> Suppliers => Set<Supplier>();

    public WimsDbContext(DbContextOptions<WimsDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure ImmutableList<int> for Supplier.LeadTimeHistory
        _ = modelBuilder.Entity<Supplier>()
            .Property(static s => s.LeadTimeHistory)
            .HasConversion(
                v => string.Join(",", v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToImmutableList()
            );
    }
}
