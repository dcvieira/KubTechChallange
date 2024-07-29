using KubTechChallange.Frontend.Models.View;

namespace KubTechChallange.Frontend.Services.Ordering;

public interface IOrderSubmissionService
{
    Task<Guid> SubmitOrder(CheckoutViewModel checkoutViewModel);
}
