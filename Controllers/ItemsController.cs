using Microsoft.AspNetCore.Mvc;

using Catalog.Repositories;
using Catalog.DTOs;

namespace Catalog.Controllers;

[ApiController]
[Route("items")]
public class ItemsController: ControllerBase {

    private readonly IItemsRepo repo;
    public ItemsController(IItemsRepo repo) {
        this.repo = repo;
    }

    [HttpGet]
    public ActionResult<IEnumerable<GetItemDto>> GetItems(){
        return Ok(this.repo.GetItems().Select(item => item.AsDto()));
    }

    [HttpGet("{id}")]
    public ActionResult<GetItemDto> GetItem(Guid id) {
        var item = this.repo.GetItem(id);

        if (item is null) {
            return NotFound();
        }

        return Ok(item.AsDto());
    }
}