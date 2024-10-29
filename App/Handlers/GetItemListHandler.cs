using App.Models;
using App.Queries;
using Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Handlers
{
    public class GetItemListHandler : IRequestHandler<GetItemListQuery, List<ItemModel>>
    {
        private readonly Context _context;
        public GetItemListHandler(Context context)
        {
            _context = context;
        }



        public async Task<List<ItemModel>> Handle(GetItemListQuery request, CancellationToken cancellationToken)
        {

            var items = await _context.Items.ToListAsync(cancellationToken);

            if (items.Count == 0)
            {
                return new List<ItemModel>();
            }
            var res = new List<ItemModel>();
            foreach (var item in items)
            {
                var itemModel = new ItemModel()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Description = item.Description,
                    Status = item.Status,
                };
                res.Add(itemModel);
            }


            return res;
        }
    }
}
