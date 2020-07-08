using System;
using System.Collections.Generic;

namespace Stocks.Data
{
    public static class Data
    {
        public static List<Stock> Stock => allStocks;
        static List<Stock> allStocks = new List<Stock>()
    {
        new Stock()
        {
            Id=1,
            Name="Google",
            Description="Strong Tech stock. Purchase on sale.",
            DatePurchased= new DateTime(2020, 6,6),
            DateSold = null
        },
        new Stock()
        {
            Id=2,
            Name="Sam Adams",
            Description="Beer is good! Purchased when drunk.",
            DatePurchased= new DateTime(2020, 6, 3),
            DateSold = new DateTime(2020, 6, 7)
        }
    };
    }
}