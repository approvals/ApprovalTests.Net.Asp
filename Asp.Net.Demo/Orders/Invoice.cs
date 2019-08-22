using System;
using System.Collections.Generic;
using System.Linq;

namespace Asp.Net.Demo.Orders
{
    public class Invoice
    {
        public List<LineItem> lineItems = new List<LineItem>();
        public string OrderNumber { get; set; }
        public string CompanyName { get; set; }
        public DateTime OrderDate { get; set; }

        public double Total
        {
            get { return lineItems.Sum(l => l.SubTotal); }
        }

        public void AddLineItem(string name, double price, double quantity)
        {
            lineItems.Add(new LineItem {ItemName = name, ItemPrice = price, ItemQuantity = quantity});
        }

        public List<LineItem> GetLineItems()
        {
            return lineItems;
        }
    }
}