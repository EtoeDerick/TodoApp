using Microsoft.EntityFrameworkCore;
using Object.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class IContext
    {
        DbSet<Item>? items { get; set; }
    }
}
