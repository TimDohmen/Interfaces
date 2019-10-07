using burgershack.Interfaces;

namespace burgershack.Models
{
  public abstract class Merchandise : IPurchasable
  {
    public double BasePrice { get; set; }

    public virtual string GetTemplate()
    {
      throw new System.NotImplementedException();
    }
  }
}