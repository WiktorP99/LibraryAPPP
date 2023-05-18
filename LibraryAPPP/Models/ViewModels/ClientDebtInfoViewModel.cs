using System;
using System.Collections.Generic;
using LibraryAPPP.DB.DTO;

namespace LibraryAPPP.Models.ViewModels
{
    public class ClientDebtInfoViewModel
    {
        public Client Client { get; set; }
        public List<ClientDebtDetailModel> DebtDetails { get; set; }
    }
}
