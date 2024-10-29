using App.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Queries
{
    public record GetItemListQuery() : IRequest<List<ItemModel>>;
    //internal class GetItemListQuery
    //{
    //}
}
