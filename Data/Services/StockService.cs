using System.Collections.Generic;
using System.Linq;

namespace Stocks.Data
{
    public class StockService : IStockService
    {
        public void AddStock(Stock stock)
        {
            Data.Stock.Add(stock)
        }

        public void DeleteStock(int stockId)
        {
            throw new System.NotImplementedException();
        }

        public List<Stock> GetAllStocks() => Data.Stock.ToList();

        public Stock GetStockById(int stockId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateStock(int stockId, Stock stock)
        {
            throw new System.NotImplementedException();
        }
    }
}