using System;
using System.ComponentModel;

public class Price_Item_Value
{
    //codes for declaring variables which accessible in different areas of the application
    public String price, itemname, discount_amount;

    //codes for setting value for item name and item price which to be stored inside the itemname and price variables
    public void SetPriceItemValue(string item_name, string item_price)
    {
        this.itemname = item_name;
        this.price = item_price;
    }

    //codes for getting the value of item and use it as needed in the application
    public String GetItemName()
    {
        return itemname;
    }

    //codes for getting the value of the price and use it as needed in the application
    public String GetPrice()
    {
        return price;
    }

    //codes for setting value for discount amount and item price which to be stored inside the discount_amt and priceItem variables
    public void SetPriceDiscountAmountValue(string discount_amt, string priceItem)
    {
        this.price = priceItem;
        this.discount_amount = discount_amt;
    }

    //codes for getting the value of price and use it as needed in the application
    public String GetPriceItem()
    {
        return price;
    }

    //codes for getting the value of discount_amount and use it as needed in the application
    public String GetDiscountAmount()
    {
        return discount_amount;
    }
}