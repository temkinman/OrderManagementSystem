using Microsoft.AspNetCore.Mvc;

namespace Catalog.Api.Controllers;

[Produces("application/json")]
public class CatalogController : BaseController
{
    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        return Ok("Catalogs");
    }
}
