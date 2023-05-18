using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryAPPP.DB.DTO
{
    public partial class SalesOrderHeader
    {
        public SalesOrderHeader()
        {
            SalesOrderDetails = new HashSet<SalesOrderDetail>();
        }

        public int SalesOrderHeaderId { get; set; }
        public int SalesOrderStatusId { get; set; }
        public int ClientId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public virtual Client Client { get; set; }
        public virtual SalesOrderStatus SalesOrderStatus { get; set; }
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}
