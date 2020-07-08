﻿namespace Stocks.Data
{
    public interface IStockService
    {
        System.Collections.Generic.List<Stock> GetAllStrocks();
        Stock GetStockById(int stockId);
        void UpdateStock(int stockId, Stock stock);
        void DeleteStock(int stockId);
        void AddStock(Stock stock);
    }
}