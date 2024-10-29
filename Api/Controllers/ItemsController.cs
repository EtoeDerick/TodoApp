using App.Commands;
using App.Models;
using App.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        IMediator _mediator;
        public ItemsController( IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<List<ItemModel>> GetItems() 
        {
            var model = new GetItemListQuery();
            var results = await _mediator.Send(model);    
            return results;
        }

        [HttpPost]
        public async Task<ItemModel> CreateAnItem([FromBody] ItemModel itemModel)
        {
            var model = new CreateItemCommand(itemModel);
            var response = await _mediator.Send(model);
            return response;
        }
    }
}
