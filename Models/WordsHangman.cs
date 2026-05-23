using System;
using System.Collections.Generic;

namespace WinFormsApp.Models;

public partial class WordsHangman
{
    public int WordId { get; set; }

    public string Word { get; set; } = null!;

    public string WordLevel { get; set; } = null!;
}
