using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TashasPizzeria.Models;

namespace TashasPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }

        public float PizzaPrice { get; set; }

        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoPizzaSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Pepperoni) PizzaPrice += 1;
            if (Pizza.Ham) PizzaPrice += 1;
            if (Pizza.Capsicum) PizzaPrice += 1;
            if (Pizza.Mushroom) PizzaPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});


        }
    }
}
