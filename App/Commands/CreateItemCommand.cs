using App.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Commands
{
    public record CreateItemCommand(ItemModel itemModel) : IRequest<ItemModel>;
    
}
