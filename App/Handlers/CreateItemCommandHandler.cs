using App.Commands;
using App.Models;
using Data;
using MediatR;
using Object.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Handlers
{
    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, ItemModel>
    {
        Context _context;

        public CreateItemCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<ItemModel> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            var item = new Item()
            {
                Title = request.itemModel.Title,
                Description = request.itemModel.Description,
            };

            //_context.Items.Add(item);
            _context.Items.Add(item);
            await _context.SaveChangesAsync();

            request.itemModel.Id = item.Id;

            return request.itemModel;
        }
    }
}
