using Estate_Agency.Models.Data;
using Estate_Agency.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Agency.Controllers
{
    public class SearchController : Controller
    {
        SearchModel searchModel = new SearchModel();
        private readonly ApplicationDbContext _context;
        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Index(SearchModel searchModel)
        {
            SearchOrder searchOrder = new SearchOrder();
            searchOrder.PhoneNumber = searchModel.PhoneNumber;
            searchOrder.Type = searchModel.Type;
            searchOrder.Country = searchModel.Country;
            searchOrder.Beds = searchModel.Beds;
            searchOrder.Garages = searchModel.Garages;
            searchOrder.Washrooms = searchModel.Washrooms;
            searchOrder.Cost = searchModel.Cost;
            _context.SearchOrders.Add(searchOrder);
            _context.SaveChanges();
        }
        
    }
}
