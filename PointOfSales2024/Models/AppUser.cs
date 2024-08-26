﻿using System.ComponentModel.DataAnnotations;

namespace PointOfSales2024.Models;

public class AppUser
    {
    public int AppUserId { get; set; }
    
    public required string Name { get; set; }
    public required string UserName { get; set; }
    public required string Password { get; set; }
    public bool IsAdmin { get; set; }

    public ICollection<Product> Products { get; } = new List<Product>();// One app user many products going to be entered.
    //public ICollection<Order> Orders { get; } = new List<Order>();// One app user many products going to be entered.


}
