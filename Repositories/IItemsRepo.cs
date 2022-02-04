using Catalog.Entities;

namespace Catalog.Repositories;

public interface IItemsRepo {
    public IEnumerable<Item> GetItems();
    public Item? GetItem(Guid id);
}