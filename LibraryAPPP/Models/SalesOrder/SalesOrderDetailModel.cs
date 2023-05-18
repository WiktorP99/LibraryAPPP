namespace LibraryAPPP.Models.SalesOrder
{
    public class SalesOrderDetailDTO
    {
        public int SalesOrderDetailId { get; set; }
        public int SalesOrderHeaderId { get; set; }
        public int BookId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
    }
}
