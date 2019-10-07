using burgershack.Interfaces;
using burgershack.Models;

namespace burgershack.Models
{
  public class Milkshake : FoodItem, ISize
  {
    public string Flavor { get; set; }
    public string Style { get; set; }

    public double SizeMultiplier { get; set; }

    public double GetPrice(Size s)
    {
      throw new System.NotImplementedException();
    }

    public override string GetTemplate()
    {
      return $@"
Item: {Name}
Flavor - Style: {Flavor} - {Style}
Size: {SizeMultiplier}


Nutritional Details:
Calories - {Calories}
Fat - {Fat} g
Protein -  {Protein} g
Carbohydrates - {Carbohydrates}

Cost: {BasePrice:c}
";
    }

    public Milkshake(string flavor, string style, string name, int calories, int fat, int protein, int carbohydrates, double price, double size) : base(name, calories, fat, protein, carbohydrates, price)
    {
      Flavor = flavor;
      Style = style;
      SizeMultiplier = size;

    }
  }
}