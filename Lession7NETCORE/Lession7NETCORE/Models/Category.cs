using System;
using System.Collections.Generic;

namespace Lession7NETCORE.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
