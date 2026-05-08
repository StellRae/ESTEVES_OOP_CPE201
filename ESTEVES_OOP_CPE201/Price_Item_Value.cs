using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTEVES_OOP_CPE201
{
    internal class Price_Item_Value
    {
       
        public String price, itemname, discount_amount;

        public void SetPriceItemValue(string item_name, string item_price)
        {
            this.itemname = item_name;
            this.price = item_price;
        }

        public string GetItemName()
        {
            return itemname;
        }

        public string GetPrice()
        {
            return price;
        }
        public void SetPriceDiscountAmountValue(string discount_amt, string priceItem)
        {
            this.price = priceItem;
            this.discount_amount = discount_amt;
        }
        public String GetPriceItem()
        {
            return price;
        }
        public String GetDiscountAmount()
        {
            return discount_amount;
        }
    }
}
