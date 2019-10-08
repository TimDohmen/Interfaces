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
    public List<FoodMerch> Pies { get; private set; }


    public List<string> Messages { get; set; }


    public void Setup()
    {
      Burger burgerOne = new Burger("Biggest Baddest Burger", 5000, 250, 25, 500, "Ground Angus", 27.96, new List<string>() { "Bacon", "More Bacon", "Some Eggs" }, 3);
      Burger burgerTwo = new Burger("V-Burg", 650, 15, 35, 100, "Impossible Patty", 16.95, new List<string>() { "V-Cheese", "Tomato", "Lettuce" }, 2);
      Burger burgerThree = new Burger("Cowboys Last Ride", 777, 20, 70, 50, "Minecraft Horse Meat", 19.20, new List<string>() { "Freshly Ground Creeper", "Arrow Shot From Skeleton", "Blaze Rod Powder" }, 3);
      Burgers.AddRange(new FoodItem[] { burgerOne, burgerTwo, burgerThree });
      Milkshake shakeone = new Milkshake("Chocolate", "Malt", "Chocolate Thundas Protein Shake", 200, 10, 50, 00, 9.99, 1);
      Milkshake shaketwo = new Milkshake("Vanilla", "Classic Shake", "Vanilla Willy's Olde Fashioned", 200, 50, 5, 100, 12.15, 2);
      Milkshake shakeThree = new Milkshake("Strawberry", "Float", "Strawberry Sink or Float", 350, 25, 5, 0, 7.99, 2);
      Shakes.AddRange(new FoodItem[] { shakeone, shaketwo, shakeThree });
      Fries fryOne = new Fries("Sweet Potato", "Criss-Cut", "Sweeties Sweet Potato Frydish", 750, 300, 20, 200, 8.75, 3);
      Fries fryTwo = new Fries("Golden Russett", "Classic French", "Golden Frenchies", 400, 95, 10, 100, 5.95, 1);
      Fries fryThree = new Fries("Purple Potato", "Tater Tot", "Purple Power Balls", 450, 75, 17, 20, 12.39, 2);
      Fries.AddRange(new FoodItem[] { fryOne, fryTwo, fryThree });
      FrontDeskPie pieOne = new FrontDeskPie("Hostess", 125, 9, 5, 25, 7.25, "Chocolate Sunrise", true);
      FrontDeskPie pieTwo = new FrontDeskPie("Grandma", 200, 0, 20, 50, 12.12, "Mostly Love But Some Rhubarb Crisp", false);
      FrontDeskPie pieThree = new FrontDeskPie("Neighbor Joe", 150, 5, 10, 40, 10.99, "Mystery", true);
      Pies.AddRange(new FoodMerch[] { pieOne, pieTwo, pieThree });
      Food = Burgers;

      Messages.Add($@"
 _                                   _                _    
| |                                 | |              | |   
| |__  _   _ _ __ __ _  ___ _ __ ___| |__   __ _  ___| | __
| '_ \| | | | '__/ _` |/ _ \ '__/ __| '_ \ / _` |/ __| |/ /
| |_) | |_| | | | (_| |  __/ |  \__ \ | | | (_| | (__|   < 
|_.__/ \__,_|_|  \__, |\___|_|  |___/_| |_|\__,_|\___|_|\_\
                  __/ |                                    
                 |___/           ");
      Messages.Add("\nBurgers Available\n");

    }
    public void changeMenu(string x)
    {
      Console.Clear();
      Messages.Add($@"
 _                                   _                _    
| |                                 | |              | |   
| |__  _   _ _ __ __ _  ___ _ __ ___| |__   __ _  ___| | __
| '_ \| | | | '__/ _` |/ _ \ '__/ __| '_ \ / _` |/ __| |/ /
| |_) | |_| | | | (_| |  __/ |  \__ \ | | | (_| | (__|   < 
|_.__/ \__,_|_|  \__, |\___|_|  |___/_| |_|\__,_|\___|_|\_\
                  __/ |                                    
                 |___/           ");
      if (x == "shakes")
      {
        Messages.Add("\nShakes Available\n");
        Food = Shakes;

      }
      else if (x == "burgers")
      {
        Messages.Add("\nBurgers Available\n");
        Food = Burgers;

      }
      else if (x == "fries")
      {
        Food = Fries;
        Messages.Add("\nFries Available\n");
      }
      else if (x == "pies")
      {
        Food = null;
        Messages.Add("\nComing Soon\n");
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
        Messages.Add($"{i + 1}: {f.Name} - {f.BasePrice}\n");
      }
      Messages.Add("Type a number to see details.\n");
      Messages.Add(" - - - or - - - \n");
      if (Food == Burgers)
      {
        Messages.Add("Press S to see Shakes, F to see Fries or Q to quit");
      }
      else if (Food == Shakes)
      {
        Messages.Add("Press B to see Burgers, F to see Fries or Q to quit");
      }
      else if (Food == Fries)
      {
        Messages.Add("Press S to see Shakes, B to see Burgers or Q to quit");
      }
    }


    public MenuService()
    {
      Messages = new List<string>();
      Food = new List<FoodItem>();
      Burgers = new List<FoodItem>();
      Shakes = new List<FoodItem>();
      Fries = new List<FoodItem>();
      Pies = new List<FoodMerch>();


      Setup();
    }
  }
}