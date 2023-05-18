using System;

namespace LibraryAPPP.Models.Rentals
{
    public class RentHeaderDTO
    {
        public int RentHeaderId { get; set; }
        public int RentStatusId { get; set; }
        public int ClientId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
