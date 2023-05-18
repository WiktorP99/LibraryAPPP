namespace LibraryAPPP.Repository.SalesOrderRepository
{
    public interface ISalesOrderRepository
    {
        public void BuyBook(int bookId, int clientId);
        public void OrderBook(int bookId, int clientId);
    }
}
