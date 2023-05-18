using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryAPPP.DB.DTO
{
    public partial class RentHeader
    {
        public RentHeader()
        {
            RentDetails = new HashSet<RentDetail>();
        }

        public int RentHeaderId { get; set; }
        public int RentStatusId { get; set; }
        public int ClientId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public virtual Client Client { get; set; }
        public virtual RentStatus RentStatus { get; set; }
        public virtual ICollection<RentDetail> RentDetails { get; set; }
    }
}
