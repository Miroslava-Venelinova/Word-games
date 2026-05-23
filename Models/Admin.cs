using System;
using System.Collections.Generic;

namespace WinFormsApp.Models;

public partial class Admin
{
    public int AdminId { get; set; }

    public string AdminUsername { get; set; } = null!;

    public string AdminPassword { get; set; } = null!;
}
