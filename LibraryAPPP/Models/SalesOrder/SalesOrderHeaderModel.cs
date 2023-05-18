using System;
using System.Net.NetworkInformation;

namespace LibraryAPPP.Models.SalesOrder
{
    public class SalesOrderHeaderDTO
    {
        public int SalesOrderHeaderId { get; set; }
        public int SalesOrderStatusId { get; set; }
        public int ClientId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
