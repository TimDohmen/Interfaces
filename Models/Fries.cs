using burgershack.Interfaces;

namespace burgershack.Models
{
  public class Fries : FoodItem, ISize
  {

    public string PotatoBreed { get; set; }
    public string CutStyle { get; set; }

    public double SizeMultiplier { get; set; }

    public double GetPrice(Size size)
    {
      return BasePrice + (SizeMultiplier * (double)size);
    }

    public override string GetTemplate()
    {
      return $@"
Item: {Name}

Size: {SizeMultiplier}

Potato: {PotatoBreed}
Cut: {CutStyle}

Nutritional Details:
Calories - {Calories}
Fat - {Fat} g
Protein -  {Protein} g
Carbohydrates - {Carbohydrates}

Cost: {BasePrice:c}
";
    }

    public Fries(string potato, string cut, string name, int calories, int fat, int protein, int carbohydrates, double price, double size) : base(name, calories, fat, protein, carbohydrates, price)
    {
      PotatoBreed = potato;
      CutStyle = cut;
      SizeMultiplier = size;
    }
  }
}