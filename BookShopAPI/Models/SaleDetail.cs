using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Contracts;
using BookShop.Models;

namespace BookShopAPI.Models
{
    public class SaleDetail : IKey
    {
        public string Id { get; set; }
        public string SaleId { get; set; }
        public Sale Sale { get; set; }
        public string BookId { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}