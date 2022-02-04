using Catalog.DTOs;
using Catalog.Entities;

namespace Catalog;

public static class Extensions {
    public static GetItemDto AsDto(this Item item) {
        return new GetItemDto {
            Id = item.Id,
            Name = item.Name,
            Price = item.Price,
            CreatedDate = item.CreatedDate
        };
    }
}