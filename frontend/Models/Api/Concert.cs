﻿namespace KubTechChallange.Frontend.Models.Api;

public class Concert
{
    public Guid ConcertId { get; set; }
    public string Name { get; set; } = String.Empty;
    public int Price { get; set; }
    public string Artist { get; set; } = String.Empty;
    public DateTime Date { get; set; }
    public string Description { get; set; } = String.Empty;
    public string ImageUrl { get; set; } = String.Empty;
}
