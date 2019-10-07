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
    public List<FoodItem> Fries { get; private set; }

    public List<string> Messages { get; set; }


    public void Setup()
    {
      Burger burgerOne = new Burger("Biggest Baddest Burger", 5000, 250, 25, 500, "Ground Angus", 27.96, new List<string>() { "Bacon", "More Bacon", "Some Eggs" }, 3);
      Burger burgerTwo = new Burger("V-Burg", 650, 15, 35, 100, "Impossible Patty", 16.95, new List<string>() { "V-Cheese", "Tomato", "Lettuce" }, 2);
      Burgers.AddRange(new FoodItem[] { burgerOne, burgerTwo });
      Milkshake shakeone = new Milkshake("Chocolate", "Malt", "Chocolate Thundas Protein Shake", 200, 10, 50, 00, 9.99, 1);
      Milkshake shaketwo = new Milkshake("Vanilla", "Classic Shake", "Vanilla Willy's Olde Fashioned", 200, 50, 5, 100, 12.15, 2);
      Shakes.AddRange(new FoodItem[] { shakeone, shaketwo });
      Fries fryOne = new Fries("Sweet Potato", "Criss-Cut", "Sweeties Sweet Potato Frydish", 750, 300, 20, 200, 8.75, 3);
      Fries fryTwo = new Fries("Golden Russett", "Classic French", "Golden Frenchies", 400, 95, 10, 100, 5.95, 1);
      Fries.AddRange(new FoodItem[] { fryOne, fryTwo });

      Food = Burgers;
      Messages.Add("Burgers Available");

    }
    public void changeMenu(string x)
    {
      if (x == "shakes")
      {
        Food = Shakes;
        Messages.Add("Shakes Available");

      }
      else if (x == "burgers")
      {
        Food = Burgers;
        Messages.Add("Burgers Available");

      }
      else if (x == "fries")
      {
        Food = Fries;
        Messages.Add("Fries Available");
      }
    }
    public void getMenu(int index)
    {
      if (index < Food.Count && index > -1)
      {
        Messages.Add("Currently Selected");
        FoodItem f = Food[index];
        Console.Clear();

        Messages.Add(f.GetTemplate());
      }
      else
      {
        Messages.Add("Enter Valid Number");
      }
    }
    public void getMenu()
    {
      // Messages.Add("Food Available");
      for (int i = 0; i < Food.Count; i++)
      {
        FoodItem f = Food[i];
        Messages.Add($"{i + 1}: {f.Name} - {f.BasePrice}");
      }
      Messages.Add("Type a number to see details or Q to quit.");
      Messages.Add(" - - - ");
      if (Food == Burgers)
      {
        Messages.Add("Press S to see Shakes or F to see Fries");
      }
      else if (Food == Shakes)
      {
        Messages.Add("Press B to see Burgers or F to see Fries");
      }
      else if (Food == Fries)
      {
        Messages.Add("Press S to see Shakes or B to see Burgers");
      }
    }

    public MenuService()
    {
      Messages = new List<string>();
      Food = new List<FoodItem>();
      Burgers = new List<FoodItem>();
      Shakes = new List<FoodItem>();
      Fries = new List<FoodItem>();

      Setup();
    }
  }
}