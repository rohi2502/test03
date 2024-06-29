using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Employe
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string Deprt { get; set; } = null!;

    public decimal Salary { get; set; }
}
