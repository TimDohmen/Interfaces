using System.Collections.Generic;
using burgershack.Models;

namespace burgershack.Services
{
  public class MenuService
  {
    public List<FoodItem> Food { get; private set; }
    public List<string> Messages { get; set; }


    public void Setup()
    {
      Burger burgerOne = new Burger("Biggest Baddest Burger", 5000, 250, 25, 500, "Ground Angus", 27.96, new string[] { "Bacon", "More Bacon", "Some Eggs" }, 3);
      Burger burgerTwo = new Burger("V-Burg", 650, 15, 35, 100, "Impossible Patty", 16.95, new string[] { "V-Cheese", "Tomato", "Lettuce" }, 2);
      Food.AddRange(new FoodItem[] { burgerOne, burgerTwo });
    }
    public void getFood()
    {
      Messages.Add("Food Available");
      for (int i = 0; i < Food.Count; i++)
      {
        FoodItem f = Food[i];
        Messages.Add($"{i + 1}: {f.Name} - {f.BasePrice}");
      }
      Messages.Add("Type a number to see details or Q to quit.");
    }
    public MenuService()
    {
      Messages = new List<string>();
      Food = new List<FoodItem>();
      Setup();
    }
  }
}