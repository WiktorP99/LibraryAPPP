using System;

namespace LibraryAPPP.Models.ViewModels
{
    public class ClientDebtDetailModel
    {
        public DateTime? ReturnDate { get; set; }
        public decimal? PenaltyFee { get; set; }
        public short? DelayDays { get; set; }
        public string BookTitle { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
    }
}
