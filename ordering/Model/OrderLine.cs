﻿namespace KubTechChallange.Ordering.Model;

public class OrderLine
{
    public Guid ConcertId { get; set; }
    public int TicketCount { get; set; }
    public int Price { get; set; }
}
