using System;
using System.Collections.Generic;

namespace BlazorTrainingGD_238276.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
