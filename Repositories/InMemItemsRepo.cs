using Catalog.Entities;

namespace Catalog.Repositories;
public class InMemItemsRepo {
    public readonly List<Item> items = new()
    {
        new Item() { Id = Guid.NewGuid(), Name="Potion", Price=9, CreatedDate = DateTimeOffset.UtcNow },
        new Item() { Id = Guid.NewGuid(), Name="Iron Sword", Price=20, CreatedDate = DateTimeOffset.UtcNow },
        new Item() { Id = Guid.NewGuid(), Name="Bronze Shield", Price=18, CreatedDate = DateTimeOffset.UtcNow }
    };

    public IEnumerable<Item> GetItems() {
        return this.items;
    }

    public Item? GetItem(Guid id) {
        return this.items.Where(item => item.Id == id).SingleOrDefault();
    }
}