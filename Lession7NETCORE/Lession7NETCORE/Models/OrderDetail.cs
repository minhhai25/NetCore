﻿using System;
using System.Collections.Generic;

namespace Lession7NETCORE.Models;

public partial class OrderDetail
{
    public int Id { get; set; }

    public int? OdersId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public double? Price { get; set; }

    public double? TotalPrice { get; set; }

    public virtual Oder? Oders { get; set; }

    public virtual Product? Product { get; set; }
}
