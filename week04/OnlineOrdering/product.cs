class Product
{
    private string name;
    private string productId;
    private float price;
    private int quantity;

    public Product(string name, string productId, float price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public float GetTotalPrice()
    {
        return price * quantity;
    }

    public string GetName() => name;
    public string GetProductId() => productId;
}
