using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopClientShare.Models.Responses
{
    public class SaleResponse
    {
        public string SaleId { get; set; }
        public string BookId { get; set; }
        public string BookTitle { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
