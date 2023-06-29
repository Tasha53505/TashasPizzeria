using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TashasPizzeria.Models;

namespace TashasPizzeria.Pages
{
    public class PizzaModel : PageModel
    {

        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita", PizzaName="Margerita", BasePrice=10, TomatoPizzaSauce=true, Cheese=true, Pepperoni=false, Ham=false, Capsicum=false, Mushroom=false},
            new PizzasModel(){ImageTitle="Pepperoni", PizzaName="Pepperoni", BasePrice=10, TomatoPizzaSauce=true, Cheese=true, Pepperoni=true, Ham=false, Capsicum=false, Mushroom=false},
            new PizzasModel(){ImageTitle="MeatFeast", PizzaName="MeatFeast", BasePrice=10, TomatoPizzaSauce=true, Cheese=true, Pepperoni=false, Ham=true, Capsicum=false, Mushroom=false},
            
            new PizzasModel(){ImageTitle="Mushroom", PizzaName="Mushroom", BasePrice=10, TomatoPizzaSauce=true, Cheese=true, Pepperoni=false, Ham=false, Capsicum=true, Mushroom=true},
            new PizzasModel(){ImageTitle="MeatFeast", PizzaName="MeatFeast", BasePrice=10, TomatoPizzaSauce=true, Cheese=true, Pepperoni=false, Ham=true, Capsicum=false, Mushroom=false},
            new PizzasModel(){ImageTitle="Pepperoni", PizzaName="Pepperoni", BasePrice=10, TomatoPizzaSauce=true, Cheese=true, Pepperoni=true, Ham=false, Capsicum=false, Mushroom=false},
            
            
        };

        public void OnGet()
        {
        }



    }
}
