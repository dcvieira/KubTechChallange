namespace KubTechChallange.Ordering.Model;

public record OrderForCreation(
    DateTimeOffset Date, CustomerDetails CustomerDetails, IEnumerable<OrderLine> Lines);
