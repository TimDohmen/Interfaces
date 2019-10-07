using System;
using System.Collections.Generic;
using burgershack.Models;

namespace burgershack.Services
{
  public class MenuService
  {
    public List<FoodItem> Food { get; private set; }
    public List<FoodItem> Burgers { get; private set; }
    public List<FoodItem> Shakes { get; private set; }

    public List<string> Messages { get; set; }


    public void Setup()
    {
      Burger burgerOne = new Burger("Biggest Baddest Burger", 5000, 250, 25, 500, "Ground Angus", 27.96, new List<string>() { "Bacon", "More Bacon", "Some Eggs" }, 3);
      Burger burgerTwo = new Burger("V-Burg", 650, 15, 35, 100, "Impossible Patty", 16.95, new List<string>() { "V-Cheese", "Tomato", "Lettuce" }, 2);
      Burgers.AddRange(new FoodItem[] { burgerOne, burgerTwo });
      Milkshake shakeone = new Milkshake("Chocolate", "Malt", "Chocolate Thundas Protein Shake", 200, 10, 50, 00, 9.99, 1);
      Milkshake shaketwo = new Milkshake("Vanilla", "Classic Shake", "Vanilla Willy's Olde Fashioned", 200, 50, 5, 100, 12.15, 2);
      Shakes.AddRange(new FoodItem[] { shakeone, shaketwo });

      Food = Burgers;
    }
    public void changeMenu()
    {
      if (Food == Burgers)
      {
        Food = Shakes;
      }
      else if (Food == Shakes)
      {
        Food = Burgers;
      }
    }
    public void getMenu(int index)
    {
      Messages.Add("Currently Selected");
      FoodItem f = Food[index];
      Console.Clear();

      Messages.Add(f.GetTemplate());
    }
    public void getMenu()
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
      Burgers = new List<FoodItem>();
      Shakes = new List<FoodItem>();
      Setup();
    }
  }
}