using System;

namespace LibraryAPPP.Models
{
    public class BooksDTO
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
