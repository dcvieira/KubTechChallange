﻿namespace KubTechChallange.Frontend.Models.Api;

public class OrderLine
{
    public Guid ConcertId { get; set; }
    public int TicketCount { get; set; }
    public int Price { get; set; }

}
