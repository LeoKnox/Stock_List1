using System;

namespace Stocks.Data
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DatePurchased { get; set; }
        public DateTime? DateSold { get; set; }
    }
}