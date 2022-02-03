using Microsoft.AspNetCore.Mvc;

using Catalog.Repositories;
using Catalog.Entities;

namespace Catalog.Controllers;

[ApiController]
[Route("items")]
public class ItemsController: ControllerBase {

    private readonly InMemItemsRepo repo;
    public ItemsController() {
        this.repo = new InMemItemsRepo();
    }

    [HttpGet]
    public ActionResult<IEnumerable<Item>> GetItems(){
        return Ok(this.repo.GetItems());
    }

    [HttpGet("{id}")]
    public ActionResult<Item> GetItem(Guid id) {
        Item item = this.repo.GetItem(id);

        if (item is null) {
            return NotFound();
        }

        return Ok(this.repo.GetItem(id));
    }
}