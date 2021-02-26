using System;
using System.Collections;

public class Cart
{
	public Cart()
	{
        items = new ArrayList();
    }
    public void addItem(string ProdTitle, string ProdQuantity, double Price)
    {
        items.Add(new CartItem(ProdTitle, ProdQuantity, Price));
    }
    public ArrayList getItems()
    {
        return  items;
    }
    ArrayList items;
    
}

public class CartItem
{
    public string ProdTitle;
    public string ProdQuantity;
    public double Price;

    public CartItem(string prodTitle, string prodQuantity, double ProdPrice)
    {
        ProdTitle = prodTitle;
        ProdQuantity = prodQuantity;
        Price = ProdPrice; 
    }
}


