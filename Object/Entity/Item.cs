using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.Entity
{
    public class Item
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public bool Status { get; set; }
    }
}
