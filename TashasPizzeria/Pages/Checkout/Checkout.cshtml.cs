using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TashasPizzeria.Data;
using TashasPizzeria.Models;

namespace TashasPizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)] // accessible in the view
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }

            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;
            // Don't need to create an id ad the framework does this automatically
            
            _context.PizzaOrders.Add(pizzaOrder); // Adds to our DB
            _context.SaveChanges(); // Saves changes to our DB


        }
    }
}
