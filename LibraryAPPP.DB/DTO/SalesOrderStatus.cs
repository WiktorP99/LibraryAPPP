using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryAPPP.DB.DTO
{
    public partial class SalesOrderStatus
    {
        public SalesOrderStatus()
        {
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        }

        public int SalesOrderStatus1 { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
