using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_91_EF01.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
