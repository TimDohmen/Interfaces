using System.Collections.Generic;
using burgershack.Interfaces;

namespace burgershack.Models
{
  public class Burger : FoodItem, ISize
  {
    public string MeatType { get; set; }
    public IEnumerable<string> Ingredients { get; set; }
    public double SizeMultiplier { get; set; }


    public double GetPrice(Size size)
    {
      return BasePrice + (SizeMultiplier * (double)size);
    }


    public override string GetTemplate()
    {
      return $@"
Item: {Name}
Meat: {MeatType}
Size: {SizeMultiplier}

Ingredients: {Ingredients}

Nutritional Details:
Calories - {Calories}
Fat - {Fat} g
Protein -  {Protein} g
Carbohydrates - {Carbohydrates}

Cost: {BasePrice:c}
";
    }



    public Burger(string name, int calories, int fat, int protein, int carbohydrates, string meat, double price, IEnumerable<string> ingredients, double size) : base(name, calories, fat, protein, carbohydrates, price)
    {
      MeatType = meat;
      Ingredients = ingredients;
      SizeMultiplier = size;
    }
  }
}