//ex1
public class ReceiptFormatter
{
    public string FormatRecipe(string shopName, string itemName, int quantity, double price)
    {
        double total = quantity*price;
        return $@"
        SHOP: {shopName}
        ----------------- 
        Item:   {itemName} 
        Qty:     {quantity} 
        Price:   {price} 
        Total:   {total}";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var print = new ReceiptFormatter();
        string receipt = print.FormatRecipe("Corne Shop", "Notebook",2,5.99);
        Console.WriteLine(receipt);
    }
}