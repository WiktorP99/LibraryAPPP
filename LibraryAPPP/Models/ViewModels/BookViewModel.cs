using System;

namespace LibraryAPPP.Models.ViewModels
{
    public class BookViewModel 
    {
        public int? ClientId { get; set; }
        public int BookId { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }
    }
}
