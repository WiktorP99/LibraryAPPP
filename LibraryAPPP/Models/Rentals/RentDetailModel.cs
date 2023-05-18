namespace LibraryAPPP.Models.Rentals
{
    public class RentDetailDTO
    {
        public int RentDetailId { get; set; }
        public int RentHeaderId { get; set; }
        public int BookId { get; set; }
        public int Amount { get; set; }
        public int DelayDays { get; set; }
        public decimal PenaltyFee { get; set; }
    }
}
