using System.Collections.Generic;

namespace LibraryAPPP.Models
{
    public class ClientDTO
    {
        public string ClientId { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string Email { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
    }
}
