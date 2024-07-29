using KubTechChallange.Frontend.Extensions;
using KubTechChallange.Frontend.Models;
using KubTechChallange.Frontend.Models.Api;
using KubTechChallange.Frontend.Models.View;
using KubTechChallange.Frontend.Services;
using KubTechChallange.Frontend.Services.ShoppingBasket;
using Microsoft.AspNetCore.Mvc;

namespace KubTechChallange.Frontend.Controllers;

public class ConcertCatalogController : Controller
{
    private readonly IConcertCatalogService concertCatalogService;
    private readonly IShoppingBasketService shoppingBasketService;
    private readonly Settings settings;

    public ConcertCatalogController(IConcertCatalogService concertCatalogService, IShoppingBasketService shoppingBasketService, Settings settings)
    {
        this.concertCatalogService = concertCatalogService;
        this.shoppingBasketService = shoppingBasketService;
        this.settings = settings;
    }

    public async Task<IActionResult> Index()
    {
        var currentBasketId = Request.Cookies.GetCurrentBasketId(settings);

        var getBasket = shoppingBasketService.GetBasket(currentBasketId);
        var getConcerts = concertCatalogService.GetAll();

        await Task.WhenAll(new Task[] { getBasket, getConcerts });

        var numberOfItems = getBasket.Result.NumberOfItems;

        return View(
            new ConcertListModel
            {
                Concerts = getConcerts.Result,
                NumberOfItems = numberOfItems,
            }
        );
    }

    public async Task<IActionResult> Detail(Guid concertId)
    {
        var ev = await concertCatalogService.GetConcert(concertId);
        return View(ev);
    }
}
