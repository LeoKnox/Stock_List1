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
            Id = 1,
            Name = "Google",
            Description = "Strong solid tech stock",
            DatePurchased = new DateTime(2020,06,01),
            DateSold = null
        },
        new Stock()
        {
            Id = 2,
            Name = "Sam Adams",
            Description = "Beer Stock purchased while drunk.",
            DatePurchased = new DateTime(2020,06,03),
            DateSold = new DateTime(2020, 6, 6)
        }
    };
    }
}