using System;
using burgershack.Services;

namespace burgershack.Controllers
{
  public class MenuController
  {
    private MenuService _menuService { get; set; } = new MenuService();

    public void UserInput()
    {

      _menuService.getMenu();
      Print();

      string choice = Console.ReadLine().ToLower();
      Console.Clear();

      switch (choice)
      {

        case "q":
          Environment.Exit(1);
          break;
        case "s":
          _menuService.changeMenu("shakes");
          Print();
          break;
        case "b":
          _menuService.changeMenu("burgers");
          Print();
          break;
        case "f":
          _menuService.changeMenu("fries");
          Print();
          break;
        default:
          if (int.TryParse(choice, out int index))
          {

            _menuService.getMenu(index - 1);
            Print();
          }
          else
          {
            System.Console.WriteLine("Invalid Key");
          }
          break;
      }

    }

    private void Print()
    {
      foreach (string message in _menuService.Messages)
      {
        System.Console.WriteLine(message);
      }
      _menuService.Messages.Clear();

    }

  }
}