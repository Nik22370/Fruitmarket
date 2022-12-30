namespace Fruitmarket;

public class FruitsAndVegetables : Product
{
    
    public string Weight { get; set; }
    public bool IsFruit { get; set; }
    public FruitsAndVegetables(Product product, string weight, bool isfruit) : base(product.Name, product.Price)
    {
        Weight = weight;
        IsFruit = isfruit;
    }

    public void changeWeight(string weight)
    {
        Weight = weight;
    }

    public void setStatus(bool isfruit)
    {
        IsFruit = isfruit;
    }
}