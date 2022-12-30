using Fruitmarket;
using Microsoft.EntityFrameworkCore;

namespace FruitmarketTests;

[Collection("Sequential")]
public class FruitMarketContextTests
{
    private FruitMarketContext GetDatabase(bool deleteDb = false)
    {
        var db = new FruitMarketContext(new DbContextOptionsBuilder()
            .UseSqlite("Data Source=FruitsMarket.db")
            .UseLazyLoadingProxies()
            .Options);
        if (deleteDb)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }
        return db;
    }
    [Fact]
    public void CreateDatabaseSuccessTest()
    {
        using var db = GetDatabase(deleteDb: true);
    }
}