using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl_2
{
    public class CItem
    {
        private string itemCode, itemName;
        private decimal costPrice, retailPrice;
        private int quantity;

        #region Constructors
        //constructor
        public CItem()
        {
        }
        public CItem(string _itemCode, string _itemName, decimal _costPrice,
                    decimal _retailPrice, int _quantity)
        {
            itemCode = _itemCode;
            ItemName = _itemName;
            CostPrice = _costPrice;
            RetailPrice = _retailPrice;
            quantity = _quantity;
        }
        #endregion Constructors

        #region Properties
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

        public static double MarkUp { get; set; }

        public string ItemName { get => itemName; set => itemName = value; }
        public decimal CostPrice { get => costPrice; set => costPrice = value; }
        public decimal RetailPrice
        {
            get { return retailPrice; }
            set
            {
                if (value >= costPrice)
                    retailPrice = value;
                else
                    //make retail price at least as much as the cost price
                    retailPrice = costPrice;
            }
        }

        public int Quantity { get => quantity; set => quantity = value; }
        //public string Quantity
        //{
        //    get { return quantity.ToString(); }
        //    set { int.TryParse(value, out quantity); }
        //}
        #endregion Properties

        public static string Instructions()
        {
            return "INSTRUCTIONS FOR ENTERING A NEW ITEM\n"
                + "======================================\n\n"
                + "1. Enter all data fields for a new stock item.\n"
                + "2. The retail price should be larger thatn or equal to the cost price.\n"
                + "3. Cost price, retail price and quantity on hand should be valid positive numeric values.";

        }

        public void SetRetailPrice(double _markUp)
        {
            RetailPrice = CostPrice + CostPrice * (decimal)_markUp / 100;
        }

        public bool Sale()
        {
            if (quantity > 0)
            {
                quantity--;
                return true;
            }
            else
                return false;
        }
        
    }
}
