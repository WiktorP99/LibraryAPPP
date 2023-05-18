using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryAPPP.DB.DTO
{
    public partial class Book
    {
        public Book()
        {
            RentDetails = new HashSet<RentDetail>();
            SalesOrderDetails = new HashSet<SalesOrderDetail>();
        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public DateTime? PublicationDate { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }

        public virtual Author Author { get; set; }
        public virtual ICollection<RentDetail> RentDetails { get; set; }
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}
