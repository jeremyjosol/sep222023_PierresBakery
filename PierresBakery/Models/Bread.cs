namespace PierresBakery.Models
{
  public interface IBread
  {
    int CalculateTotalBreadPrice(int orderQuantity);
  }
  // Buy 2 get 1 free
  public class WhiteOrWheat : IBread
  {
    public int LoafPrice { get; }
    public int LoafCount { get; set; }
    public int TotalBreadPrice { get; set; }

    public WhiteOrWheat()
    {
      LoafPrice = 5;
    }
    public int CalculateTotalBreadPrice(int orderQuantity)
    {
      LoafCount = orderQuantity;
      TotalBreadPrice = 0;
      for (int i = 1; i <= orderQuantity; i++)
      {
        TotalBreadPrice += LoafPrice;
        if (i % 3 == 0)
        {
          TotalBreadPrice -= LoafPrice;
        }
      }
      return TotalBreadPrice;
    }
  }
  // Buy 1 get 1 free
  public class Baguette : IBread
  {
    public int LoafPrice { get; }
    public int LoafCount { get; set; }
    public int TotalBreadPrice { get; set; }
    public Baguette()
    {
      LoafPrice = 6;
    }
    public int CalculateTotalBreadPrice(int orderQuantity)
    {
      TotalBreadPrice = 0;
      LoafCount = (orderQuantity / 2) + (orderQuantity % 2);
      TotalBreadPrice = LoafCount * LoafPrice;
      return TotalBreadPrice;
    }
  }
  // Buy 1 get 1 50% off
  public class Brioche : IBread
  {
    public int LoafPrice { get; }
    public int LoafCount { get; set; }
    public int TotalBreadPrice { get; set; }
    public Brioche()
    {
      LoafPrice = 8;
    }
    public int CalculateTotalBreadPrice(int orderQuantity)
    {
      TotalBreadPrice = 0;
      int halfOff = orderQuantity / 2;


      return TotalBreadPrice;
      
    }
  }
}