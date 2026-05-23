using System;
using System.Collections.Generic;

namespace WinFormsApp.Models;

public partial class Player
{
    public int PlayerId { get; set; }

    public string PlayerUsername { get; set; } = null!;

    public string PlayerPassword { get; set; } = null!;

    public int PlayerTotalGames { get; set; }

    public int PlayerHangmanWins { get; set; }

    public int PlayerWordlWins { get; set; }
}
