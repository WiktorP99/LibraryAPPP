using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryAPPP.DB.DTO
{
    public partial class Client
    {
        public Client()
        {
            RentHeaders = new HashSet<RentHeader>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        }

        public int ClientId { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string Email { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }

        public virtual ICollection<RentHeader> RentHeaders { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
