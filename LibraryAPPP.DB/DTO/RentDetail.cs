using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryAPPP.DB.DTO
{
    public partial class RentDetail
    {
        public int RentDetailId { get; set; }
        public int RentHeaderId { get; set; }
        public int BookId { get; set; }
        public short Amount { get; set; }
        public short? DelayDays { get; set; }
        public decimal? PenaltyFee { get; set; }

        public virtual Book Book { get; set; }
        public virtual RentHeader RentHeader { get; set; }
    }
}
