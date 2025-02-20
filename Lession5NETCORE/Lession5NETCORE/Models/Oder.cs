using System;
using System.Collections.Generic;

namespace Lession5NETCORE.Models;

public partial class Oder
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public double? TotalPrice { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
