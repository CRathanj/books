using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopClientShare.Models.Responses
{
    public class ReportResponse
    {
        public string ISBN { get; set; }
        public string EmployeeName { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeId { get; set; }
        public string CustomerId { get; set; }
        public string Contact { get; set; }
        public string BookTitle { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
