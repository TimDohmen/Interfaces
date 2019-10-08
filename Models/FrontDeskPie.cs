
namespace burgershack.Models
{
  public class FrontDeskPie : FoodMerch
  {
    public string PieFlavor { get; set; }
    public bool hasDairy { get; set; }

    public override string GetTemplate()
    {
      return $@"
Pie flavor?: {PieFlavor}

Contains Dairy: {hasDairy}

Vendor: {Vendor}

Nutritional Details:
Calories - {Calories}
Fat - {Fat} g
Protein -  {Protein} g
Carbohydrates - {Carbohydrates}

Cost: {BasePrice:c}
";
    }

    public FrontDeskPie(string vendor, int calories, int fat, int protein, int carbohydrates, double BasePrice, string flavor, bool dairy) : base(vendor, calories, fat, protein, carbohydrates)
    {
      PieFlavor = flavor;
      hasDairy = dairy;
    }
  }
}