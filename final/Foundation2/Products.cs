public class Products
{
    private string _productName;
    private string _productId;
    private double _productPrice;
    private int _productQuantity;

    public Products(string productName, string productId, double productPrice, int productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }
}