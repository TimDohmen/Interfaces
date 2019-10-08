using burgershack.Interfaces;

namespace burgershack.Models
{
  public class FoodMerch : Merchandise, IConsumable, IPurchasable
  {

    public string Vendor { get; set; }
    public int Calories { get; set; }
    public int Fat { get; set; }
    public int Protein { get; set; }
    public int Carbohydrates { get; set; }



    public FoodMerch(string vendor, int calories, int fat, int protein, int carbohydrates)
    {
      Vendor = vendor;
      Calories = calories;
      Fat = fat;
      Protein = protein;
      Carbohydrates = carbohydrates;

    }
  }

}