using System;
using System.Collections.Generic;

namespace CleanArchi.Core.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public int QuantityInStock { get; set; }

    public int CategoryId { get; set; }

    public DateTime DateAjout { get; set; }

    public DateTime DateMaj { get; set; }

    public virtual Category Category { get; set; } = null!;
}
