using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckbookBuddy.Models
{
    public class OrderModel
    {
        public int OrderID { get; set; }

        public List<Transaction> Transactions { get; set; }

        public string LastBalanced { get; set; }

        public string FinalRegisterBalance { get; set; }

        public string FinalRegisterDate { get; set; }

        public string ErrorCorrection { get; set; }

    }
}