namespace burgershack.Interfaces
{
  public interface IConsumable
  {
    int Calories { get; set; }
    int Fat { get; set; }
    int Protein { get; set; }
    int Carbohydrates { get; set; }
  }
}