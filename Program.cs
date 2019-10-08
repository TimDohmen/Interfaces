using System;
using burgershack.Controllers;

namespace burgershack
{
  class Program
  {
    static void Main(string[] args)
    {
      MenuController mc = new MenuController();
      Console.Clear();

      while (true)
      {

        mc.UserInput();
      }
    }
  }
}
