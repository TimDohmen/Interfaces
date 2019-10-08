namespace burgershack.Interfaces
{
  public interface IPurchasable
  {
    double BasePrice { get; set; }

    string GetTemplate();


  }
}