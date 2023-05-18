using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryAPPP.DB.DTO
{
    public partial class RentStatus
    {
        public RentStatus()
        {
            RentHeaders = new HashSet<RentHeader>();
        }

        public int RentStatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<RentHeader> RentHeaders { get; set; }
    }
}
