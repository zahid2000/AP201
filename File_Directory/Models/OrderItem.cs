﻿namespace File_Directory.Models;

public class OrderItem
{
    public int Id { get; set; }
    public Product Product { get; set; }
    public int Count { get; set; }
    public decimal TotalPrice { get; set; }
}
