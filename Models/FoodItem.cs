using burgershack.Interfaces;

namespace burgershack.Models
{
  public abstract class FoodItem : IConsumable, IPurchasable
  {
    public string Name { get; set; }
    public int Calories { get; set; }
    public int Fat { get; set; }
    public int Protein { get; set; }
    public int Carbohydrates { get; set; }
    public double BasePrice { get; set; }

    public virtual string GetTemplate()
    {
      return $@"
Item: {Name}

Nutritional Details:
Calories - {Calories}
Fat - {Fat} g
Protein -  {Protein} g
Carbohydrates - {Carbohydrates}

Cost: {BasePrice:c}
";
    }


    public FoodItem(string name, int calories, int fat, int protein, int carbohydrates, double price)
    {
      Name = name;
      Calories = calories;
      Fat = fat;
      Protein = protein;
      Carbohydrates = carbohydrates;
      BasePrice = price;
    }
  }
}